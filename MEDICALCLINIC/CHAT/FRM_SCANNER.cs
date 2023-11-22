﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WIA;

namespace MEDICALCLINIC.CHAT
{
    public partial class FRM_SCANNER : Form
    {
        byte[] imge1;

        int BOOK_ID,FLAG_ID=0;
        public FRM_SCANNER(int BOOK_CODE,int IDFLAG)
        {
            InitializeComponent();
            BOOK_ID = BOOK_CODE;
        }


        int newDoc = 0;
        int cmbCMIndex = 0;
        Stopwatch sw = new Stopwatch();

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            bgwScan.RunWorkerAsync(5000);
            btnStartScan.Enabled = false;
            btnStopScan.Enabled = true;
            cmbColorMode.Enabled = false;
            nudWidthInch.Enabled = false;
            nudHeightInch.Enabled = false;
            nudRes.Enabled = false;
            cbxCustomPixel.Enabled = false;
            nudHeight.Enabled = false;
            nudWidth.Enabled = false;

            cmbCMIndex = cmbColorMode.SelectedIndex;
        }



        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = folderDlg.SelectedPath;
            }
        }

        private void frmAutoScan_Load(object sender, EventArgs e)
        {
            txtPath.Text = Path.GetTempPath();
            nudHeightInch.Value = 11;
            nudWidthInch.Value = 8;
            cmbColorMode.SelectedIndex = 1;
        }


        private void bgwScan_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!bgwScan.CancellationPending)
            {
                if (newDoc == 0)
                {
                    newDoc = 1;
                    ScanDoc();

                }

                for (int k = 1; k <= 10 * (int)nudTime.Value; k++)
                {

                    Thread.Sleep(100);

                    bgwScan.ReportProgress((int)(k / (int)nudTime.Value));
                    if (k == 10 * (int)nudTime.Value)
                        newDoc = 0;
                }
            }

        }


        private void btnStopScan_Click(object sender, EventArgs e)
        {
            bgwScan.CancelAsync();
            btnStartScan.Enabled = true;
            btnStopScan.Enabled = false;
            cmbColorMode.Enabled = true;

            //
            btnStartScan.Enabled = true;
            btnStopScan.Enabled = false;
            cmbColorMode.Enabled = true;
            nudWidthInch.Enabled = true;
            nudHeightInch.Enabled = true;
            nudRes.Enabled = true;
            cbxCustomPixel.Enabled = true;
            if (cbxCustomPixel.Checked == true)
            {
                nudHeight.Enabled = true;
                nudWidth.Enabled = true;
            }


            sw.Reset();
            sw.Stop();
        }

        private void bgwScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            {
                if (e.Cancelled) MessageBox.Show("Operation was canceled");
                else if (e.Error != null) MessageBox.Show(e.Error.Message);
                //else MessageBox.Show("Processing");
            }
        }

        private void bgwScan_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbWaiting.Value = (int)e.ProgressPercentage * 10;
            sw.Start();
            txtWT.Text = (int)nudTime.Value - (int)(sw.ElapsedMilliseconds / 1000) + " Secs. Remaining";

            if (pbWaiting.Value == 100)
            {
                pbWaiting.Value = 0;
                txtWT.Text = "Proccessing";
                sw.Reset();
                sw.Stop();
            }
        }


        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel,
                    int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);



        }

        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        private static void SaveImageToTiff(ImageFile image, string fileName)
        {
            ImageProcess imgProcess = new ImageProcess();
            object convertFilter = "Convert";
            string convertFilterID = imgProcess.FilterInfos.get_Item(ref convertFilter).FilterID;
            imgProcess.Filters.Add(convertFilterID, 0);
            SetWIAProperty(imgProcess.Filters[imgProcess.Filters.Count].Properties, "FormatID", WIA.FormatID.wiaFormatTIFF);
            image = imgProcess.Apply(image);
            image.SaveFile(fileName);
        }
        private void ScanDoc()
        {
            try
            {
                CommonDialogClass commonDialogClass = new CommonDialogClass();
                Device scannerDevice = commonDialogClass.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, false, false);
                if (scannerDevice != null)
                {
                    Item scannnerItem = scannerDevice.Items[1];
                    AdjustScannerSettings(scannnerItem, (int)nudRes.Value, 0, 0, (int)nudWidth.Value, (int)nudHeight.Value, 0, 0, cmbCMIndex);

                    object scanResult = commonDialogClass.ShowTransfer(scannnerItem, WIA.FormatID.wiaFormatTIFF, false);
                    //picScan.Image = (System.Drawing.Image)scanResult;
                    if (scanResult != null)
                    {
                        ImageFile image = (ImageFile)scanResult;
                        string fileName = "";

                        var files = Directory.GetFiles(txtPath.Text, "*.tiff");

                        try
                        {
                            string f = ((files.Max(p1 => Int32.Parse(Path.GetFileNameWithoutExtension(p1)))) + 1).ToString();
                            fileName = txtPath.Text + "\\" + f + ".tiff";
                        }
                        catch (Exception ex)
                        {
                            fileName = txtPath.Text + "\\" + "1.tiff";
                        }
                        SaveImageToTiff(image, fileName);
                        picScan.ImageLocation = fileName;
                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Check the Device Connection \n or \n Change the Scanner Device", "Devic Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void nudWidthInch_ValueChanged(object sender, EventArgs e)
        {
            nudWidth.Value = nudRes.Value * nudWidthInch.Value;
        }

        private void nudHeightInch_ValueChanged(object sender, EventArgs e)
        {
            nudHeight.Value = nudRes.Value * nudHeightInch.Value;
        }

        private void nudRes_ValueChanged(object sender, EventArgs e)
        {
            nudWidth.Value = nudRes.Value * nudWidthInch.Value;

            nudHeight.Value = nudRes.Value * nudHeightInch.Value;
        }

        private void cbxCustomPixel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCustomPixel.Checked == true)
            {
                nudWidth.ReadOnly = false;
                nudHeight.ReadOnly = false;
            }
            else
            {
                nudWidth.ReadOnly = true;
                nudHeight.ReadOnly = true;
            }
        }

        private void BTN_CHOOSE_PIC_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP;*TIFF";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                picScan.Image = Image.FromFile(ofd1.FileName);
            }
        }
         
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            //if (FLAG_ID==1)
            //{
                var INSERTEDP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                MemoryStream ms1 = new MemoryStream();
                picScan.Image.Save(ms1, picScan.Image.RawFormat);
                imge1 = ms1.ToArray();
                INSERTEDP.P_INSERT_T_IMG_BOOKING(imge1, BOOK_ID);
                MessageBox.Show("تم الحفظ بنجاح");
                picScan.Image = null;
            //}
            //else
            //     if (FLAG_ID == 2)
            //{
            //    var INSERTEDP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            //    MemoryStream ms1 = new MemoryStream();
            //    picScan.Image.Save(ms1, picScan.Image.RawFormat);
            //    imge1 = ms1.ToArray();
            //    INSERTEDP.P_INSERT_IMG_RAIS(BOOK_ID , imge1, ref CLS.SUBMIT_FLAG);
            //    MessageBox.Show("تم الحفظ بنجاح");
            //    picScan.Image = null;
            //}

        }
    }
}
