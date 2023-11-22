using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_LIST_PRINTER : USERSE.masterfrm
    {
        public FRM_LIST_PRINTER()
        {
            InitializeComponent();
        }

        private void FRM_LIST_PRINTER_Load(object sender, EventArgs e)
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                comboBox1.Items.Add(printer);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PRINTER_NAME = comboBox1.Text;
            Properties.Settings.Default.Save();
            if (comboBox1 .Text != string .Empty )
            MessageBox.Show("تم تحديد الطابعة بنجاح");
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PRINTER_NAME = comboBox1.Text;
            Properties.Settings.Default.Save();
            if (comboBox1.Text != string.Empty)
                MessageBox.Show("تم تحديد الطابعة بنجاح");
            this.Close();
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
