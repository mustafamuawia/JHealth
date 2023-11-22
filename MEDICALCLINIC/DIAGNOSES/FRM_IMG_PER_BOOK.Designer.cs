namespace MEDICALCLINIC.DIAGNOSES
{
    partial class FRM_IMG_PER_BOOK
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_IMG_PER_BOOK));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MAIN_PIC = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.BB_PIC1 = new System.Windows.Forms.PictureBox();
            this.BB_PIC2 = new System.Windows.Forms.PictureBox();
            this.BB_PIC3 = new System.Windows.Forms.PictureBox();
            this.BB_PIC4 = new System.Windows.Forms.PictureBox();
            this.BB_PIC5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.TXT_ID_BOOK = new System.Windows.Forms.Label();
            this.TXT_PERSON = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.p_GET_A_SUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.p_GET_A_ITEMS_BARCODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_A_ITEMS_BARCODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_ITEMS_BARCODETableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.p_GET_A_SUPPLIERSTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_SUPPLIERSTableAdapter();
            this.p_GET_IMG_BY_CODE_BOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_IMG_BY_CODE_BOOKTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_IMG_BY_CODE_BOOKTableAdapter();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MAIN_PIC)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BB_PIC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BB_PIC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BB_PIC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BB_PIC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BB_PIC5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_SUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_ITEMS_BARCODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_IMG_BY_CODE_BOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label6.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(963, 4);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(157, 34);
            label6.TabIndex = 82;
            label6.Text = "أسم المريض";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(1286, 4);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 34);
            label2.TabIndex = 85;
            label2.Text = "رقم الحجز";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1364, 729);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.MAIN_PIC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 518);
            this.panel2.TabIndex = 61;
            // 
            // MAIN_PIC
            // 
            this.MAIN_PIC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MAIN_PIC.Location = new System.Drawing.Point(0, 0);
            this.MAIN_PIC.Name = "MAIN_PIC";
            this.MAIN_PIC.Size = new System.Drawing.Size(1356, 516);
            this.MAIN_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MAIN_PIC.TabIndex = 0;
            this.MAIN_PIC.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 64);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1358, 144);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BB_PIC1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.BB_PIC2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BB_PIC3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BB_PIC4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BB_PIC5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1352, 125);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("STV", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(219, 119);
            this.button8.TabIndex = 107;
            this.button8.Text = "خروج";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // BB_PIC1
            // 
            this.BB_PIC1.BackColor = System.Drawing.Color.White;
            this.BB_PIC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BB_PIC1.Location = new System.Drawing.Point(1128, 3);
            this.BB_PIC1.Name = "BB_PIC1";
            this.BB_PIC1.Size = new System.Drawing.Size(221, 119);
            this.BB_PIC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BB_PIC1.TabIndex = 9;
            this.BB_PIC1.TabStop = false;
            this.BB_PIC1.Click += new System.EventHandler(this.BB_PIC1_Click);
            // 
            // BB_PIC2
            // 
            this.BB_PIC2.BackColor = System.Drawing.Color.White;
            this.BB_PIC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BB_PIC2.Location = new System.Drawing.Point(903, 3);
            this.BB_PIC2.Name = "BB_PIC2";
            this.BB_PIC2.Size = new System.Drawing.Size(219, 119);
            this.BB_PIC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BB_PIC2.TabIndex = 8;
            this.BB_PIC2.TabStop = false;
            this.BB_PIC2.Click += new System.EventHandler(this.BB_PIC2_Click);
            // 
            // BB_PIC3
            // 
            this.BB_PIC3.BackColor = System.Drawing.Color.White;
            this.BB_PIC3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BB_PIC3.Location = new System.Drawing.Point(678, 3);
            this.BB_PIC3.Name = "BB_PIC3";
            this.BB_PIC3.Size = new System.Drawing.Size(219, 119);
            this.BB_PIC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BB_PIC3.TabIndex = 7;
            this.BB_PIC3.TabStop = false;
            this.BB_PIC3.Click += new System.EventHandler(this.BB_PIC3_Click);
            // 
            // BB_PIC4
            // 
            this.BB_PIC4.BackColor = System.Drawing.Color.White;
            this.BB_PIC4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BB_PIC4.Location = new System.Drawing.Point(453, 3);
            this.BB_PIC4.Name = "BB_PIC4";
            this.BB_PIC4.Size = new System.Drawing.Size(219, 119);
            this.BB_PIC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BB_PIC4.TabIndex = 6;
            this.BB_PIC4.TabStop = false;
            this.BB_PIC4.Click += new System.EventHandler(this.BB_PIC4_Click);
            // 
            // BB_PIC5
            // 
            this.BB_PIC5.BackColor = System.Drawing.Color.White;
            this.BB_PIC5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BB_PIC5.Location = new System.Drawing.Point(228, 3);
            this.BB_PIC5.Name = "BB_PIC5";
            this.BB_PIC5.Size = new System.Drawing.Size(219, 119);
            this.BB_PIC5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BB_PIC5.TabIndex = 0;
            this.BB_PIC5.TabStop = false;
            this.BB_PIC5.Click += new System.EventHandler(this.BB_PIC5_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonX3);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.TXT_ID_BOOK);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.TXT_PERSON);
            this.panel1.Controls.Add(label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 48);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(219, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 33);
            this.button3.TabIndex = 105;
            this.button3.Text = "تدوير";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(325, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 106;
            this.button2.Text = "تدوير";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX3.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX3.Font = new System.Drawing.Font("STV", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX3.Image = ((System.Drawing.Image)(resources.GetObject("buttonX3.Image")));
            this.buttonX3.Location = new System.Drawing.Point(-27, 3);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX3.Size = new System.Drawing.Size(57, 34);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 88;
            this.buttonX3.Text = "Zoom";
            this.buttonX3.Visible = false;
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click_1);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX1.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX1.Font = new System.Drawing.Font("STV", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.Location = new System.Drawing.Point(36, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.buttonX1.Size = new System.Drawing.Size(39, 34);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 90;
            this.buttonX1.Text = "Zoom ";
            this.buttonX1.Visible = false;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // TXT_ID_BOOK
            // 
            this.TXT_ID_BOOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.TXT_ID_BOOK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_ID_BOOK.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_ID_BOOK.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_ID_BOOK.Location = new System.Drawing.Point(1174, 4);
            this.TXT_ID_BOOK.Name = "TXT_ID_BOOK";
            this.TXT_ID_BOOK.Size = new System.Drawing.Size(122, 34);
            this.TXT_ID_BOOK.TabIndex = 86;
            this.TXT_ID_BOOK.Text = "0";
            this.TXT_ID_BOOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TXT_ID_BOOK.UseCompatibleTextRendering = true;
            // 
            // TXT_PERSON
            // 
            this.TXT_PERSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.TXT_PERSON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PERSON.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_PERSON.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_PERSON.Location = new System.Drawing.Point(422, 4);
            this.TXT_PERSON.Name = "TXT_PERSON";
            this.TXT_PERSON.Size = new System.Drawing.Size(541, 34);
            this.TXT_PERSON.TabIndex = 83;
            this.TXT_PERSON.Text = "لم تحدد اي مريض";
            this.TXT_PERSON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TXT_PERSON.UseCompatibleTextRendering = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // p_GET_A_SUPPLIERSBindingSource
            // 
            this.p_GET_A_SUPPLIERSBindingSource.DataMember = "P_GET_A_SUPPLIERS";
            this.p_GET_A_SUPPLIERSBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_GET_A_ITEMS_BARCODEBindingSource
            // 
            this.p_GET_A_ITEMS_BARCODEBindingSource.DataMember = "P_GET_A_ITEMS_BARCODE";
            this.p_GET_A_ITEMS_BARCODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_A_ITEMS_BARCODETableAdapter
            // 
            this.p_GET_A_ITEMS_BARCODETableAdapter.ClearBeforeFill = true;
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
            // p_GET_A_SUPPLIERSTableAdapter
            // 
            this.p_GET_A_SUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_IMG_BY_CODE_BOOKBindingSource
            // 
            this.p_GET_IMG_BY_CODE_BOOKBindingSource.DataMember = "P_GET_IMG_BY_CODE_BOOK";
            this.p_GET_IMG_BY_CODE_BOOKBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_IMG_BY_CODE_BOOKTableAdapter
            // 
            this.p_GET_IMG_BY_CODE_BOOKTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_IMG_PER_BOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 729);
            this.Controls.Add(this.groupBox2);
            this.Name = "FRM_IMG_PER_BOOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_IMG_PER_BOOK_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MAIN_PIC)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BB_PIC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BB_PIC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BB_PIC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BB_PIC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BB_PIC5)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_SUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_ITEMS_BARCODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_IMG_BY_CODE_BOOKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.BindingSource p_GET_A_ITEMS_BARCODEBindingSource;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_ITEMS_BARCODETableAdapter p_GET_A_ITEMS_BARCODETableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource p_GET_A_SUPPLIERSBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_SUPPLIERSTableAdapter p_GET_A_SUPPLIERSTableAdapter;
        private System.Windows.Forms.PictureBox MAIN_PIC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox BB_PIC1;
        private System.Windows.Forms.PictureBox BB_PIC2;
        private System.Windows.Forms.PictureBox BB_PIC3;
        private System.Windows.Forms.PictureBox BB_PIC4;
        private System.Windows.Forms.PictureBox BB_PIC5;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label TXT_PERSON;
        private System.Windows.Forms.BindingSource p_GET_IMG_BY_CODE_BOOKBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_IMG_BY_CODE_BOOKTableAdapter p_GET_IMG_BY_CODE_BOOKTableAdapter;
        public System.Windows.Forms.Label TXT_ID_BOOK;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
    }
}