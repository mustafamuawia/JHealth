namespace MEDICALCLINIC.ADDPICT_GENE
{
    partial class FRM_ADD_PIC_NEW
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dOCTOR_NAMELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD_PIC_NEW));
            this.button4 = new System.Windows.Forms.Button();
            this.LBL_PERS_NAME = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_BOOK_CODE = new System.Windows.Forms.Label();
            this.LBL_PERS_CODE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dOCTOR_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.v_A_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.COM_CAMLIST = new System.Windows.Forms.ComboBox();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.PictureBoxSave = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonX12 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX11 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX10 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX9 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX8 = new DevComponents.DotNetBar.ButtonX();
            this.N_PIC5 = new System.Windows.Forms.PictureBox();
            this.N_PIC2 = new System.Windows.Forms.PictureBox();
            this.N_PIC4 = new System.Windows.Forms.PictureBox();
            this.N_PIC1 = new System.Windows.Forms.PictureBox();
            this.N_PIC3 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.v_A_DOCTORTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            dOCTOR_NAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_PIC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_PIC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_PIC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_PIC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_PIC3)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // dOCTOR_NAMELabel
            // 
            dOCTOR_NAMELabel.AutoSize = true;
            dOCTOR_NAMELabel.Dock = System.Windows.Forms.DockStyle.Fill;
            dOCTOR_NAMELabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dOCTOR_NAMELabel.ForeColor = System.Drawing.Color.Black;
            dOCTOR_NAMELabel.Location = new System.Drawing.Point(586, 1);
            dOCTOR_NAMELabel.Name = "dOCTOR_NAMELabel";
            dOCTOR_NAMELabel.Size = new System.Drawing.Size(302, 39);
            dOCTOR_NAMELabel.TabIndex = 61;
            dOCTOR_NAMELabel.Text = "اسم الدكتور";
            dOCTOR_NAMELabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 79);
            this.button4.TabIndex = 106;
            this.button4.Text = "بحث عن حجز";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LBL_PERS_NAME
            // 
            this.LBL_PERS_NAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_PERS_NAME.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PERS_NAME.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_PERS_NAME.Location = new System.Drawing.Point(4, 41);
            this.LBL_PERS_NAME.Name = "LBL_PERS_NAME";
            this.LBL_PERS_NAME.Size = new System.Drawing.Size(234, 39);
            this.LBL_PERS_NAME.TabIndex = 0;
            this.LBL_PERS_NAME.Text = "لايتوفر أسم مريض";
            this.LBL_PERS_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "أسم المريض";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_BOOK_CODE
            // 
            this.LBL_BOOK_CODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_BOOK_CODE.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BOOK_CODE.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_BOOK_CODE.Location = new System.Drawing.Point(400, 41);
            this.LBL_BOOK_CODE.Name = "LBL_BOOK_CODE";
            this.LBL_BOOK_CODE.Size = new System.Drawing.Size(179, 39);
            this.LBL_BOOK_CODE.TabIndex = 0;
            this.LBL_BOOK_CODE.Text = "لايتوفر رقم حجز";
            this.LBL_BOOK_CODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_PERS_CODE
            // 
            this.LBL_PERS_CODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_PERS_CODE.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PERS_CODE.ForeColor = System.Drawing.Color.Maroon;
            this.LBL_PERS_CODE.Location = new System.Drawing.Point(245, 41);
            this.LBL_PERS_CODE.Name = "LBL_PERS_CODE";
            this.LBL_PERS_CODE.Size = new System.Drawing.Size(148, 39);
            this.LBL_PERS_CODE.TabIndex = 0;
            this.LBL_PERS_CODE.Text = "لايتوفر كود";
            this.LBL_PERS_CODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(400, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "رقم الحجز";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(245, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود المريض";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dOCTOR_NAMEComboBox
            // 
            this.dOCTOR_NAMEComboBox.DataSource = this.v_A_DOCTORBindingSource;
            this.dOCTOR_NAMEComboBox.DisplayMember = "DOCTOR_NAME";
            this.dOCTOR_NAMEComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dOCTOR_NAMEComboBox.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dOCTOR_NAMEComboBox.FormattingEnabled = true;
            this.dOCTOR_NAMEComboBox.Location = new System.Drawing.Point(586, 44);
            this.dOCTOR_NAMEComboBox.Name = "dOCTOR_NAMEComboBox";
            this.dOCTOR_NAMEComboBox.Size = new System.Drawing.Size(302, 33);
            this.dOCTOR_NAMEComboBox.TabIndex = 62;
            this.dOCTOR_NAMEComboBox.ValueMember = "USER_CODE";
            // 
            // v_A_DOCTORBindingSource
            // 
            this.v_A_DOCTORBindingSource.DataMember = "V_A_DOCTOR";
            this.v_A_DOCTORBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(256, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 14);
            this.button3.TabIndex = 105;
            this.button3.Text = "ألتقاط صورة";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(120, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 14);
            this.button2.TabIndex = 104;
            this.button2.Text = "حفظ الصورة";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 14);
            this.button1.TabIndex = 103;
            this.button1.Text = "أيقاف الكاميرا";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_SAVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_SAVE.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_SAVE.ForeColor = System.Drawing.Color.White;
            this.BTN_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SAVE.Location = new System.Drawing.Point(486, 3);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(226, 14);
            this.BTN_SAVE.TabIndex = 102;
            this.BTN_SAVE.Text = "تشغيل الكاميرا";
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // COM_CAMLIST
            // 
            this.COM_CAMLIST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COM_CAMLIST.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COM_CAMLIST.FormattingEnabled = true;
            this.COM_CAMLIST.Location = new System.Drawing.Point(718, 3);
            this.COM_CAMLIST.Name = "COM_CAMLIST";
            this.COM_CAMLIST.Size = new System.Drawing.Size(290, 44);
            this.COM_CAMLIST.TabIndex = 12;
            // 
            // picCapture
            // 
            this.picCapture.BackColor = System.Drawing.Color.White;
            this.picCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCapture.Location = new System.Drawing.Point(3, 3);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(503, 294);
            this.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // PictureBoxSave
            // 
            this.PictureBoxSave.BackColor = System.Drawing.Color.White;
            this.PictureBoxSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxSave.Location = new System.Drawing.Point(512, 3);
            this.PictureBoxSave.Name = "PictureBoxSave";
            this.PictureBoxSave.Size = new System.Drawing.Size(504, 294);
            this.PictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxSave.TabIndex = 11;
            this.PictureBoxSave.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("STV", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 174);
            this.button6.TabIndex = 108;
            this.button6.Text = "خروج";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("STV", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(888, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 174);
            this.button5.TabIndex = 107;
            this.button5.Text = "حفظ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonX12
            // 
            this.buttonX12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX12.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonX12.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX12.Location = new System.Drawing.Point(4, 140);
            this.buttonX12.Name = "buttonX12";
            this.buttonX12.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX12.Size = new System.Drawing.Size(151, 32);
            this.buttonX12.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX12.TabIndex = 84;
            this.buttonX12.Text = "تحميل صورة";
            this.buttonX12.Click += new System.EventHandler(this.buttonX12_Click);
            // 
            // buttonX11
            // 
            this.buttonX11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX11.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonX11.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonX11.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX11.Location = new System.Drawing.Point(162, 140);
            this.buttonX11.Name = "buttonX11";
            this.buttonX11.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX11.Size = new System.Drawing.Size(151, 32);
            this.buttonX11.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX11.TabIndex = 83;
            this.buttonX11.Text = "تحميل صورة";
            this.buttonX11.Click += new System.EventHandler(this.buttonX11_Click);
            // 
            // buttonX10
            // 
            this.buttonX10.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX10.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonX10.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonX10.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX10.Location = new System.Drawing.Point(320, 140);
            this.buttonX10.Name = "buttonX10";
            this.buttonX10.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX10.Size = new System.Drawing.Size(151, 32);
            this.buttonX10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX10.TabIndex = 82;
            this.buttonX10.Text = "تحميل صورة";
            this.buttonX10.Click += new System.EventHandler(this.buttonX10_Click);
            // 
            // buttonX9
            // 
            this.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX9.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonX9.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonX9.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX9.Location = new System.Drawing.Point(478, 140);
            this.buttonX9.Name = "buttonX9";
            this.buttonX9.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX9.Size = new System.Drawing.Size(151, 32);
            this.buttonX9.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX9.TabIndex = 81;
            this.buttonX9.Text = "تحميل صورة";
            this.buttonX9.Click += new System.EventHandler(this.buttonX9_Click);
            // 
            // buttonX8
            // 
            this.buttonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX8.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonX8.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX8.Location = new System.Drawing.Point(636, 140);
            this.buttonX8.Name = "buttonX8";
            this.buttonX8.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX8.Size = new System.Drawing.Size(154, 32);
            this.buttonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX8.TabIndex = 80;
            this.buttonX8.Text = "تحميل صورة";
            this.buttonX8.Click += new System.EventHandler(this.buttonX8_Click);
            // 
            // N_PIC5
            // 
            this.N_PIC5.BackColor = System.Drawing.Color.White;
            this.N_PIC5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.N_PIC5.Image = ((System.Drawing.Image)(resources.GetObject("N_PIC5.Image")));
            this.N_PIC5.Location = new System.Drawing.Point(4, 4);
            this.N_PIC5.Name = "N_PIC5";
            this.N_PIC5.Size = new System.Drawing.Size(151, 129);
            this.N_PIC5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.N_PIC5.TabIndex = 68;
            this.N_PIC5.TabStop = false;
            this.N_PIC5.Click += new System.EventHandler(this.N_PIC5_Click);
            // 
            // N_PIC2
            // 
            this.N_PIC2.BackColor = System.Drawing.Color.White;
            this.N_PIC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.N_PIC2.Image = ((System.Drawing.Image)(resources.GetObject("N_PIC2.Image")));
            this.N_PIC2.Location = new System.Drawing.Point(320, 4);
            this.N_PIC2.Name = "N_PIC2";
            this.N_PIC2.Size = new System.Drawing.Size(151, 129);
            this.N_PIC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.N_PIC2.TabIndex = 69;
            this.N_PIC2.TabStop = false;
            this.N_PIC2.Click += new System.EventHandler(this.N_PIC2_Click);
            // 
            // N_PIC4
            // 
            this.N_PIC4.BackColor = System.Drawing.Color.White;
            this.N_PIC4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.N_PIC4.Image = ((System.Drawing.Image)(resources.GetObject("N_PIC4.Image")));
            this.N_PIC4.Location = new System.Drawing.Point(162, 4);
            this.N_PIC4.Name = "N_PIC4";
            this.N_PIC4.Size = new System.Drawing.Size(151, 129);
            this.N_PIC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.N_PIC4.TabIndex = 70;
            this.N_PIC4.TabStop = false;
            this.N_PIC4.Click += new System.EventHandler(this.N_PIC4_Click);
            // 
            // N_PIC1
            // 
            this.N_PIC1.BackColor = System.Drawing.Color.White;
            this.N_PIC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.N_PIC1.Image = ((System.Drawing.Image)(resources.GetObject("N_PIC1.Image")));
            this.N_PIC1.Location = new System.Drawing.Point(636, 4);
            this.N_PIC1.Name = "N_PIC1";
            this.N_PIC1.Size = new System.Drawing.Size(154, 129);
            this.N_PIC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.N_PIC1.TabIndex = 71;
            this.N_PIC1.TabStop = false;
            this.N_PIC1.Click += new System.EventHandler(this.N_PIC1_Click);
            // 
            // N_PIC3
            // 
            this.N_PIC3.BackColor = System.Drawing.Color.White;
            this.N_PIC3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.N_PIC3.Image = ((System.Drawing.Image)(resources.GetObject("N_PIC3.Image")));
            this.N_PIC3.Location = new System.Drawing.Point(478, 4);
            this.N_PIC3.Name = "N_PIC3";
            this.N_PIC3.Size = new System.Drawing.Size(151, 129);
            this.N_PIC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.N_PIC3.TabIndex = 72;
            this.N_PIC3.TabStop = false;
            this.N_PIC3.Click += new System.EventHandler(this.N_PIC3_Click);
            // 
            // v_A_DOCTORTableAdapter
            // 
            this.v_A_DOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FormsNamesTableAdapter = null;
            this.tableAdapterManager.GroupRolsTableAdapter = null;
            this.tableAdapterManager.MessageTableAdapter = null;
            this.tableAdapterManager.PermessionsTableAdapter = null;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.T_ACCOUNT_TYPETableAdapter = null;
            this.tableAdapterManager.T_ACCOUNTSTableAdapter = null;
            this.tableAdapterManager.T_BILL_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOK_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_BOX_DETAILS_TTableAdapter = null;
            this.tableAdapterManager.T_BOX_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOX_TTableAdapter = null;
            this.tableAdapterManager.T_BOXTableAdapter = null;
            this.tableAdapterManager.T_CASH_DEBTTableAdapter = null;
            this.tableAdapterManager.T_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.T_CLASS_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_CLIENT_TYPETableAdapter = null;
            this.tableAdapterManager.T_CLIENTTableAdapter = null;
            this.tableAdapterManager.T_CURRANNCYTableAdapter = null;
            this.tableAdapterManager.T_DESCRPTIONTableAdapter = null;
            this.tableAdapterManager.T_DISEASETableAdapter = null;
            this.tableAdapterManager.T_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_DRAGE_GROUPTableAdapter = null;
            this.tableAdapterManager.T_DRAGE_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_DRAGETableAdapter = null;
            this.tableAdapterManager.T_EMPLOYEE_TYPETableAdapter = null;
            this.tableAdapterManager.T_EMPLOYEETableAdapter = null;
            this.tableAdapterManager.T_GROUP_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_H_B_DEPTableAdapter = null;
            this.tableAdapterManager.T_H_BEDTableAdapter = null;
            this.tableAdapterManager.T_H_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_H_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.T_H_COMBIN_FSUBTableAdapter = null;
            this.tableAdapterManager.T_H_CONVERTED_BYTableAdapter = null;
            this.tableAdapterManager.T_H_FLOORTableAdapter = null;
            this.tableAdapterManager.T_H_INVOICE_SERVICE_TYPETableAdapter = null;
            this.tableAdapterManager.T_H_ITEMS_OPERATIONSTableAdapter = null;
            this.tableAdapterManager.T_H_ITEMSTableAdapter = null;
            this.tableAdapterManager.T_H_MAIN_DEPTableAdapter = null;
            this.tableAdapterManager.T_H_OP_TYP_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_H_OP_TYPTableAdapter = null;
            this.tableAdapterManager.T_H_OPERATION_CATEGTableAdapter = null;
            this.tableAdapterManager.T_H_OPERATION_PORCEDTableAdapter = null;
            this.tableAdapterManager.T_H_ORGANIZATION_INFOTableAdapter = null;
            this.tableAdapterManager.T_H_ROOMTableAdapter = null;
            this.tableAdapterManager.T_H_RPT_NAME_IMAGETableAdapter = null;
            this.tableAdapterManager.T_H_SCHDUEL_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_H_SERVICE_TYPETableAdapter = null;
            this.tableAdapterManager.T_H_SERVICESTableAdapter = null;
            this.tableAdapterManager.T_H_TYPE_BEDTableAdapter = null;
            this.tableAdapterManager.T_H_TYPE_ROOMTableAdapter = null;
            this.tableAdapterManager.T_IMAGETableAdapter = null;
            this.tableAdapterManager.T_IMG_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_IMG_PERSTableAdapter = null;
            this.tableAdapterManager.T_IMG_RAISTableAdapter = null;
            this.tableAdapterManager.T_INVOICE_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_INVOICESTableAdapter = null;
            this.tableAdapterManager.T_ITEMSTableAdapter = null;
            this.tableAdapterManager.T_L_CAETGORESTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTRAYDETAILSTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTRAYTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTTESTDETAILSTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTTESTTableAdapter = null;
            this.tableAdapterManager.T_L_TESTSTableAdapter = null;
            this.tableAdapterManager.T_L_UNITTableAdapter = null;
            this.tableAdapterManager.T_LAB_NAMETableAdapter = null;
            this.tableAdapterManager.T_LIYTableAdapter = null;
            this.tableAdapterManager.T_MAJOR_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_MAJORTableAdapter = null;
            this.tableAdapterManager.T_MEDICAL_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_MEDICAL_QUESTIONTableAdapter = null;
            this.tableAdapterManager.T_ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_ORDERTableAdapter = null;
            this.tableAdapterManager.T_PERSONTableAdapter = null;
            this.tableAdapterManager.T_PURCHES_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_PURCHESTableAdapter = null;
            this.tableAdapterManager.T_RAY_NAMETableAdapter = null;
            this.tableAdapterManager.T_RAYROOM_NAMETableAdapter = null;
            this.tableAdapterManager.T_REGION_TYPETableAdapter = null;
            this.tableAdapterManager.T_REGIONS_BODYTableAdapter = null;
            this.tableAdapterManager.T_RPT_IMG_LABTableAdapter = null;
            this.tableAdapterManager.T_RPT_IMGTableAdapter = null;
            this.tableAdapterManager.T_SEX_STATETableAdapter = null;
            this.tableAdapterManager.T_STATETableAdapter = null;
            this.tableAdapterManager.T_TOOTH_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_TRATMENT_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_TYPE_MOVETableAdapter = null;
            this.tableAdapterManager.T_TYPE_PAYTableAdapter = null;
            this.tableAdapterManager.T_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1023, 609);
            this.tableLayoutPanel3.TabIndex = 59;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.picCapture, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PictureBoxSave, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1019, 300);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 306);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.04555F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.95445F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1019, 301);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.83965F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.16035F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel6.Controls.Add(this.button5, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.button6, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 119);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1015, 180);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Controls.Add(this.N_PIC1, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.buttonX8, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.buttonX9, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.buttonX10, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.buttonX11, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.buttonX12, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.N_PIC3, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.N_PIC2, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.N_PIC4, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.N_PIC5, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(89, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.53881F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.46119F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(794, 176);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09926F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1015, 113);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 5;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.40657F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.59343F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tableLayoutPanel9.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.COM_CAMLIST, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.BTN_SAVE, 3, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1011, 20);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.41706F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.58294F));
            this.tableLayoutPanel10.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(2, 26);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1011, 85);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel11.ColumnCount = 4;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.97561F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.02439F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel11.Controls.Add(this.LBL_PERS_NAME, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.LBL_BOOK_CODE, 2, 1);
            this.tableLayoutPanel11.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.dOCTOR_NAMEComboBox, 3, 1);
            this.tableLayoutPanel11.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.LBL_PERS_CODE, 1, 1);
            this.tableLayoutPanel11.Controls.Add(dOCTOR_NAMELabel, 3, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(117, 2);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(892, 81);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // FRM_ADD_PIC_NEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 609);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "FRM_ADD_PIC_NEW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة صور كاميرا للحجز";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_IMGE_PRSN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_PIC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_PIC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_PIC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_PIC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_PIC3)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.PictureBox picCapture;
        internal System.Windows.Forms.PictureBox PictureBoxSave;
        private System.Windows.Forms.ComboBox COM_CAMLIST;
        private System.Windows.Forms.PictureBox N_PIC5;
        private System.Windows.Forms.PictureBox N_PIC2;
        private System.Windows.Forms.PictureBox N_PIC4;
        private System.Windows.Forms.PictureBox N_PIC1;
        private System.Windows.Forms.PictureBox N_PIC3;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource v_A_DOCTORBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter v_A_DOCTORTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label LBL_BOOK_CODE;
        public System.Windows.Forms.Label LBL_PERS_CODE;
        public System.Windows.Forms.Label LBL_PERS_NAME;
        private DevComponents.DotNetBar.ButtonX buttonX8;
        private DevComponents.DotNetBar.ButtonX buttonX9;
        private DevComponents.DotNetBar.ButtonX buttonX10;
        private DevComponents.DotNetBar.ButtonX buttonX11;
        private DevComponents.DotNetBar.ButtonX buttonX12;
        private System.Windows.Forms.ComboBox dOCTOR_NAMEComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
    }
}