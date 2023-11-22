namespace MEDICALCLINIC.XRAY
{
    partial class FRM_BOOK_PIC_SEARCH
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BOOK_PIC_SEARCH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.DATE_BOOKING = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dOCTOR_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.v_A_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDACTIVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKINGCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKINGTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISEASETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEBOOKINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEBOOKINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHECKEDDOCDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mONEYCHECKDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEBOOKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRAGENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERTIONPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATIONFLAGDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pICTUREPERSONDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gET_BOOKING_BY_DATEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LBL_NUM_PER = new System.Windows.Forms.Label();
            this.LBL_UNTEST = new System.Windows.Forms.Label();
            this.LBL_TESTED = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LBL_NUM_NO_PAID = new System.Windows.Forms.Label();
            this.LBL_NUM_PAID = new System.Windows.Forms.Label();
            this.LBL_TOTAT_PAY_FOR = new System.Windows.Forms.Label();
            this.gET_BOOKING_BY_DATETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_BOOKING_BY_DATETableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gET_COUNT_TEST_UNTESTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_COUNT_TEST_UNTESTTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_COUNT_TEST_UNTESTTableAdapter();
            this.gET_NUM_MONEY_CHECKEDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_NUM_MONEY_CHECKEDTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_NUM_MONEY_CHECKEDTableAdapter();
            this.gET_ORDER_BY_BOOKING_NUMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_ORDER_BY_BOOKING_NUMTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ORDER_BY_BOOKING_NUMTableAdapter();
            this.gET_BOOKING_BY_ID_PER_DOCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_BOOKING_BY_ID_PER_DOCTTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_BOOKING_BY_ID_PER_DOCTTableAdapter();
            this.v_A_DOCTORTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PIC_CLOSE = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_BOOKING_BY_DATEBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_COUNT_TEST_UNTESTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_NUM_MONEY_CHECKEDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ORDER_BY_BOOKING_NUMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_BOOKING_BY_ID_PER_DOCTBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_CLOSE)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label4.ForeColor = System.Drawing.Color.Yellow;
            label4.Location = new System.Drawing.Point(291, 13);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(86, 28);
            label4.TabIndex = 94;
            label4.Text = "غير المدفوع";
            // 
            // label15
            // 
            label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label15.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label15.ForeColor = System.Drawing.Color.Yellow;
            label15.Location = new System.Drawing.Point(381, 13);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(65, 28);
            label15.TabIndex = 92;
            label15.Text = "المدفوع";
            // 
            // label17
            // 
            label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label17.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label17.ForeColor = System.Drawing.Color.White;
            label17.Location = new System.Drawing.Point(205, 13);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(76, 56);
            label17.TabIndex = 90;
            label17.Text = "المبلغ الكلي";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(748, 13);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 56);
            label3.TabIndex = 100;
            label3.Text = "العدد الكلي";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.70914F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.29086F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 76);
            this.tableLayoutPanel1.TabIndex = 107;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(314, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 64);
            this.button1.TabIndex = 104;
            this.button1.Text = "بحث";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.33268F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.66732F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.DATE_BOOKING, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dOCTOR_NAMEComboBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(398, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 66);
            this.tableLayoutPanel2.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(256, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 107;
            this.label2.Text = "التأريخ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DATE_BOOKING
            // 
            this.DATE_BOOKING.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DATE_BOOKING.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DATE_BOOKING.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_BOOKING.Location = new System.Drawing.Point(3, 36);
            this.DATE_BOOKING.Name = "DATE_BOOKING";
            this.DATE_BOOKING.Size = new System.Drawing.Size(247, 29);
            this.DATE_BOOKING.TabIndex = 82;
            this.DATE_BOOKING.Value = new System.DateTime(2016, 12, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(256, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 33);
            this.label1.TabIndex = 91;
            this.label1.Text = "الدكتور:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dOCTOR_NAMEComboBox
            // 
            this.dOCTOR_NAMEComboBox.DataSource = this.v_A_DOCTORBindingSource;
            this.dOCTOR_NAMEComboBox.DisplayMember = "DOCTOR_NAME";
            this.dOCTOR_NAMEComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dOCTOR_NAMEComboBox.Font = new System.Drawing.Font("STV", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dOCTOR_NAMEComboBox.FormattingEnabled = true;
            this.dOCTOR_NAMEComboBox.Location = new System.Drawing.Point(2, 2);
            this.dOCTOR_NAMEComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.dOCTOR_NAMEComboBox.Name = "dOCTOR_NAMEComboBox";
            this.dOCTOR_NAMEComboBox.Size = new System.Drawing.Size(249, 27);
            this.dOCTOR_NAMEComboBox.TabIndex = 106;
            this.dOCTOR_NAMEComboBox.ValueMember = "USER_CODE";
            this.dOCTOR_NAMEComboBox.SelectedIndexChanged += new System.EventHandler(this.dOCTOR_NAMEComboBox_SelectedIndexChanged);
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
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(6, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 64);
            this.button8.TabIndex = 105;
            this.button8.Text = "خروج";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(6, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(763, 340);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "كل الحجوزات";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDACTIVEDataGridViewTextBoxColumn,
            this.bOOKINGCODEDataGridViewTextBoxColumn,
            this.pERSONCODEDataGridViewTextBoxColumn,
            this.dOCTORCODEDataGridViewTextBoxColumn,
            this.pERSONNAMEDataGridViewTextBoxColumn,
            this.dOCTORNAMEDataGridViewTextBoxColumn,
            this.bOOKINGTYPEDataGridViewTextBoxColumn,
            this.dISEASETYPEDataGridViewTextBoxColumn,
            this.dATEBOOKINGDataGridViewTextBoxColumn,
            this.tIMEBOOKINGDataGridViewTextBoxColumn,
            this.cHECKEDDOCDataGridViewCheckBoxColumn,
            this.mONEYCHECKDataGridViewCheckBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.sEXNAMEDataGridViewTextBoxColumn,
            this.pRICEBOOKDataGridViewTextBoxColumn,
            this.dESCRPTIONDataGridViewTextBoxColumn,
            this.sTATENAMEDataGridViewTextBoxColumn,
            this.dRAGENAMEDataGridViewTextBoxColumn,
            this.oPERTIONPRICEDataGridViewTextBoxColumn,
            this.oPERATIONFLAGDataGridViewCheckBoxColumn,
            this.pICTUREPERSONDataGridViewImageColumn,
            this.Column1});
            this.dataGridView2.DataSource = this.gET_BOOKING_BY_DATEBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 24);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(757, 313);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            // 
            // iDACTIVEDataGridViewTextBoxColumn
            // 
            this.iDACTIVEDataGridViewTextBoxColumn.DataPropertyName = "ID_ACTIVE";
            this.iDACTIVEDataGridViewTextBoxColumn.HeaderText = "تسلسل";
            this.iDACTIVEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDACTIVEDataGridViewTextBoxColumn.Name = "iDACTIVEDataGridViewTextBoxColumn";
            this.iDACTIVEDataGridViewTextBoxColumn.Width = 170;
            // 
            // bOOKINGCODEDataGridViewTextBoxColumn
            // 
            this.bOOKINGCODEDataGridViewTextBoxColumn.DataPropertyName = "BOOKING_CODE";
            this.bOOKINGCODEDataGridViewTextBoxColumn.HeaderText = "رقم الحجز";
            this.bOOKINGCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bOOKINGCODEDataGridViewTextBoxColumn.Name = "bOOKINGCODEDataGridViewTextBoxColumn";
            this.bOOKINGCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOOKINGCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pERSONCODEDataGridViewTextBoxColumn
            // 
            this.pERSONCODEDataGridViewTextBoxColumn.DataPropertyName = "PERSON_CODE";
            this.pERSONCODEDataGridViewTextBoxColumn.HeaderText = "PERSON_CODE";
            this.pERSONCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONCODEDataGridViewTextBoxColumn.Name = "pERSONCODEDataGridViewTextBoxColumn";
            this.pERSONCODEDataGridViewTextBoxColumn.Visible = false;
            this.pERSONCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOCTORCODEDataGridViewTextBoxColumn
            // 
            this.dOCTORCODEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_CODE";
            this.dOCTORCODEDataGridViewTextBoxColumn.HeaderText = "DOCTOR_CODE";
            this.dOCTORCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCTORCODEDataGridViewTextBoxColumn.Name = "dOCTORCODEDataGridViewTextBoxColumn";
            this.dOCTORCODEDataGridViewTextBoxColumn.Visible = false;
            this.dOCTORCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pERSONNAMEDataGridViewTextBoxColumn
            // 
            this.pERSONNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pERSONNAMEDataGridViewTextBoxColumn.DataPropertyName = "PERSON_NAME";
            this.pERSONNAMEDataGridViewTextBoxColumn.HeaderText = "أسم المريض";
            this.pERSONNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONNAMEDataGridViewTextBoxColumn.Name = "pERSONNAMEDataGridViewTextBoxColumn";
            // 
            // dOCTORNAMEDataGridViewTextBoxColumn
            // 
            this.dOCTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NAME";
            this.dOCTORNAMEDataGridViewTextBoxColumn.HeaderText = "DOCTOR_NAME";
            this.dOCTORNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCTORNAMEDataGridViewTextBoxColumn.Name = "dOCTORNAMEDataGridViewTextBoxColumn";
            this.dOCTORNAMEDataGridViewTextBoxColumn.Visible = false;
            this.dOCTORNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // bOOKINGTYPEDataGridViewTextBoxColumn
            // 
            this.bOOKINGTYPEDataGridViewTextBoxColumn.DataPropertyName = "BOOKING_TYPE";
            this.bOOKINGTYPEDataGridViewTextBoxColumn.HeaderText = "نوع الحجز";
            this.bOOKINGTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bOOKINGTYPEDataGridViewTextBoxColumn.Name = "bOOKINGTYPEDataGridViewTextBoxColumn";
            this.bOOKINGTYPEDataGridViewTextBoxColumn.Visible = false;
            this.bOOKINGTYPEDataGridViewTextBoxColumn.Width = 250;
            // 
            // dISEASETYPEDataGridViewTextBoxColumn
            // 
            this.dISEASETYPEDataGridViewTextBoxColumn.DataPropertyName = "DISEASE_TYPE";
            this.dISEASETYPEDataGridViewTextBoxColumn.HeaderText = "نوع المرض";
            this.dISEASETYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dISEASETYPEDataGridViewTextBoxColumn.Name = "dISEASETYPEDataGridViewTextBoxColumn";
            this.dISEASETYPEDataGridViewTextBoxColumn.Visible = false;
            this.dISEASETYPEDataGridViewTextBoxColumn.Width = 300;
            // 
            // dATEBOOKINGDataGridViewTextBoxColumn
            // 
            this.dATEBOOKINGDataGridViewTextBoxColumn.DataPropertyName = "DATE_BOOKING";
            this.dATEBOOKINGDataGridViewTextBoxColumn.HeaderText = "DATE_BOOKING";
            this.dATEBOOKINGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dATEBOOKINGDataGridViewTextBoxColumn.Name = "dATEBOOKINGDataGridViewTextBoxColumn";
            this.dATEBOOKINGDataGridViewTextBoxColumn.Visible = false;
            this.dATEBOOKINGDataGridViewTextBoxColumn.Width = 125;
            // 
            // tIMEBOOKINGDataGridViewTextBoxColumn
            // 
            this.tIMEBOOKINGDataGridViewTextBoxColumn.DataPropertyName = "TIME_BOOKING";
            this.tIMEBOOKINGDataGridViewTextBoxColumn.HeaderText = "TIME_BOOKING";
            this.tIMEBOOKINGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIMEBOOKINGDataGridViewTextBoxColumn.Name = "tIMEBOOKINGDataGridViewTextBoxColumn";
            this.tIMEBOOKINGDataGridViewTextBoxColumn.Visible = false;
            this.tIMEBOOKINGDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHECKEDDOCDataGridViewCheckBoxColumn
            // 
            this.cHECKEDDOCDataGridViewCheckBoxColumn.DataPropertyName = "CHECKED_DOC";
            this.cHECKEDDOCDataGridViewCheckBoxColumn.HeaderText = "الفحص";
            this.cHECKEDDOCDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.cHECKEDDOCDataGridViewCheckBoxColumn.Name = "cHECKEDDOCDataGridViewCheckBoxColumn";
            this.cHECKEDDOCDataGridViewCheckBoxColumn.Visible = false;
            this.cHECKEDDOCDataGridViewCheckBoxColumn.Width = 125;
            // 
            // mONEYCHECKDataGridViewCheckBoxColumn
            // 
            this.mONEYCHECKDataGridViewCheckBoxColumn.DataPropertyName = "MONEY_CHECK";
            this.mONEYCHECKDataGridViewCheckBoxColumn.HeaderText = "الكشفية";
            this.mONEYCHECKDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.mONEYCHECKDataGridViewCheckBoxColumn.Name = "mONEYCHECKDataGridViewCheckBoxColumn";
            this.mONEYCHECKDataGridViewCheckBoxColumn.Visible = false;
            this.mONEYCHECKDataGridViewCheckBoxColumn.Width = 125;
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.aGEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            this.aGEDataGridViewTextBoxColumn.Visible = false;
            this.aGEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sEXNAMEDataGridViewTextBoxColumn
            // 
            this.sEXNAMEDataGridViewTextBoxColumn.DataPropertyName = "SEX_NAME";
            this.sEXNAMEDataGridViewTextBoxColumn.HeaderText = "SEX_NAME";
            this.sEXNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEXNAMEDataGridViewTextBoxColumn.Name = "sEXNAMEDataGridViewTextBoxColumn";
            this.sEXNAMEDataGridViewTextBoxColumn.Visible = false;
            this.sEXNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRICEBOOKDataGridViewTextBoxColumn
            // 
            this.pRICEBOOKDataGridViewTextBoxColumn.DataPropertyName = "PRICE_BOOK";
            this.pRICEBOOKDataGridViewTextBoxColumn.HeaderText = "PRICE_BOOK";
            this.pRICEBOOKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEBOOKDataGridViewTextBoxColumn.Name = "pRICEBOOKDataGridViewTextBoxColumn";
            this.pRICEBOOKDataGridViewTextBoxColumn.Visible = false;
            this.pRICEBOOKDataGridViewTextBoxColumn.Width = 125;
            // 
            // dESCRPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRPTION";
            this.dESCRPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRPTION";
            this.dESCRPTIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dESCRPTIONDataGridViewTextBoxColumn.Name = "dESCRPTIONDataGridViewTextBoxColumn";
            this.dESCRPTIONDataGridViewTextBoxColumn.Visible = false;
            this.dESCRPTIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTATENAMEDataGridViewTextBoxColumn
            // 
            this.sTATENAMEDataGridViewTextBoxColumn.DataPropertyName = "STATE_NAME";
            this.sTATENAMEDataGridViewTextBoxColumn.HeaderText = "STATE_NAME";
            this.sTATENAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTATENAMEDataGridViewTextBoxColumn.Name = "sTATENAMEDataGridViewTextBoxColumn";
            this.sTATENAMEDataGridViewTextBoxColumn.Visible = false;
            this.sTATENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dRAGENAMEDataGridViewTextBoxColumn
            // 
            this.dRAGENAMEDataGridViewTextBoxColumn.DataPropertyName = "DRAGE_NAME";
            this.dRAGENAMEDataGridViewTextBoxColumn.HeaderText = "DRAGE_NAME";
            this.dRAGENAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dRAGENAMEDataGridViewTextBoxColumn.Name = "dRAGENAMEDataGridViewTextBoxColumn";
            this.dRAGENAMEDataGridViewTextBoxColumn.Visible = false;
            this.dRAGENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // oPERTIONPRICEDataGridViewTextBoxColumn
            // 
            this.oPERTIONPRICEDataGridViewTextBoxColumn.DataPropertyName = "OPERTION_PRICE";
            this.oPERTIONPRICEDataGridViewTextBoxColumn.HeaderText = "OPERTION_PRICE";
            this.oPERTIONPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oPERTIONPRICEDataGridViewTextBoxColumn.Name = "oPERTIONPRICEDataGridViewTextBoxColumn";
            this.oPERTIONPRICEDataGridViewTextBoxColumn.Visible = false;
            this.oPERTIONPRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // oPERATIONFLAGDataGridViewCheckBoxColumn
            // 
            this.oPERATIONFLAGDataGridViewCheckBoxColumn.DataPropertyName = "OPERATION_FLAG";
            this.oPERATIONFLAGDataGridViewCheckBoxColumn.HeaderText = "OPERATION_FLAG";
            this.oPERATIONFLAGDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.oPERATIONFLAGDataGridViewCheckBoxColumn.Name = "oPERATIONFLAGDataGridViewCheckBoxColumn";
            this.oPERATIONFLAGDataGridViewCheckBoxColumn.Visible = false;
            this.oPERATIONFLAGDataGridViewCheckBoxColumn.Width = 125;
            // 
            // pICTUREPERSONDataGridViewImageColumn
            // 
            this.pICTUREPERSONDataGridViewImageColumn.DataPropertyName = "PICTURE_PERSON";
            this.pICTUREPERSONDataGridViewImageColumn.HeaderText = "PICTURE_PERSON";
            this.pICTUREPERSONDataGridViewImageColumn.MinimumWidth = 6;
            this.pICTUREPERSONDataGridViewImageColumn.Name = "pICTUREPERSONDataGridViewImageColumn";
            this.pICTUREPERSONDataGridViewImageColumn.Visible = false;
            this.pICTUREPERSONDataGridViewImageColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "حجز سابق";
            this.Column1.HeaderText = "تفاصيل";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Text = "تفاصيل";
            this.Column1.ToolTipText = "تفاصيل";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 150;
            // 
            // gET_BOOKING_BY_DATEBindingSource
            // 
            this.gET_BOOKING_BY_DATEBindingSource.DataMember = "GET_BOOKING_BY_DATE";
            this.gET_BOOKING_BY_DATEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.LBL_NUM_PER);
            this.groupBox3.Controls.Add(label3);
            this.groupBox3.Controls.Add(this.LBL_UNTEST);
            this.groupBox3.Controls.Add(this.LBL_TESTED);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.LBL_NUM_NO_PAID);
            this.groupBox3.Controls.Add(label4);
            this.groupBox3.Controls.Add(this.LBL_NUM_PAID);
            this.groupBox3.Controls.Add(label15);
            this.groupBox3.Controls.Add(this.LBL_TOTAT_PAY_FOR);
            this.groupBox3.Controls.Add(label17);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(0, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(775, 4);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // LBL_NUM_PER
            // 
            this.LBL_NUM_PER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_NUM_PER.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBL_NUM_PER.ForeColor = System.Drawing.Color.Yellow;
            this.LBL_NUM_PER.Location = new System.Drawing.Point(655, 13);
            this.LBL_NUM_PER.Name = "LBL_NUM_PER";
            this.LBL_NUM_PER.Size = new System.Drawing.Size(91, 56);
            this.LBL_NUM_PER.TabIndex = 101;
            this.LBL_NUM_PER.Text = "0";
            this.LBL_NUM_PER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_UNTEST
            // 
            this.LBL_UNTEST.AutoEllipsis = true;
            this.LBL_UNTEST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_UNTEST.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBL_UNTEST.ForeColor = System.Drawing.Color.Lime;
            this.LBL_UNTEST.Location = new System.Drawing.Point(454, 41);
            this.LBL_UNTEST.Name = "LBL_UNTEST";
            this.LBL_UNTEST.Size = new System.Drawing.Size(93, 28);
            this.LBL_UNTEST.TabIndex = 99;
            this.LBL_UNTEST.Text = "0";
            this.LBL_UNTEST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_TESTED
            // 
            this.LBL_TESTED.AutoEllipsis = true;
            this.LBL_TESTED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_TESTED.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBL_TESTED.ForeColor = System.Drawing.Color.Lime;
            this.LBL_TESTED.Location = new System.Drawing.Point(551, 41);
            this.LBL_TESTED.Name = "LBL_TESTED";
            this.LBL_TESTED.Size = new System.Drawing.Size(93, 28);
            this.LBL_TESTED.TabIndex = 98;
            this.LBL_TESTED.Text = "0";
            this.LBL_TESTED.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoEllipsis = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(551, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 28);
            this.label16.TabIndex = 97;
            this.label16.Text = "تم الفحص";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(454, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 28);
            this.label13.TabIndex = 96;
            this.label13.Text = "لم يفحص";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_NUM_NO_PAID
            // 
            this.LBL_NUM_NO_PAID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_NUM_NO_PAID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBL_NUM_NO_PAID.ForeColor = System.Drawing.Color.Lime;
            this.LBL_NUM_NO_PAID.Location = new System.Drawing.Point(291, 41);
            this.LBL_NUM_NO_PAID.Name = "LBL_NUM_NO_PAID";
            this.LBL_NUM_NO_PAID.Size = new System.Drawing.Size(86, 28);
            this.LBL_NUM_NO_PAID.TabIndex = 95;
            this.LBL_NUM_NO_PAID.Text = "0";
            this.LBL_NUM_NO_PAID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_NUM_PAID
            // 
            this.LBL_NUM_PAID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_NUM_PAID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBL_NUM_PAID.ForeColor = System.Drawing.Color.Lime;
            this.LBL_NUM_PAID.Location = new System.Drawing.Point(381, 41);
            this.LBL_NUM_PAID.Name = "LBL_NUM_PAID";
            this.LBL_NUM_PAID.Size = new System.Drawing.Size(65, 28);
            this.LBL_NUM_PAID.TabIndex = 93;
            this.LBL_NUM_PAID.Text = "0";
            this.LBL_NUM_PAID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_TOTAT_PAY_FOR
            // 
            this.LBL_TOTAT_PAY_FOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_TOTAT_PAY_FOR.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBL_TOTAT_PAY_FOR.ForeColor = System.Drawing.Color.Yellow;
            this.LBL_TOTAT_PAY_FOR.Location = new System.Drawing.Point(7, 13);
            this.LBL_TOTAT_PAY_FOR.Name = "LBL_TOTAT_PAY_FOR";
            this.LBL_TOTAT_PAY_FOR.Size = new System.Drawing.Size(196, 56);
            this.LBL_TOTAT_PAY_FOR.TabIndex = 91;
            this.LBL_TOTAT_PAY_FOR.Text = "0.00";
            this.LBL_TOTAT_PAY_FOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gET_BOOKING_BY_DATETableAdapter
            // 
            this.gET_BOOKING_BY_DATETableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_ACCOUNT_COST_TYPETableAdapter = null;
            this.tableAdapterManager.T_ACCOUNT_TYPETableAdapter = null;
            this.tableAdapterManager.T_ACCOUNTSTableAdapter = null;
            this.tableAdapterManager.T_BILL_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOK_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_BOX_DETAILS_TTableAdapter = null;
            this.tableAdapterManager.T_BOX_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOX_TTableAdapter = null;
            this.tableAdapterManager.T_BOXTableAdapter = null;
            this.tableAdapterManager.T_CASE_IS_COMPTableAdapter = null;
            this.tableAdapterManager.T_CASH_DEBTTableAdapter = null;
            this.tableAdapterManager.T_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.T_CLASS_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_CLIENT_TYPETableAdapter = null;
            this.tableAdapterManager.T_CLIENTTableAdapter = null;
            this.tableAdapterManager.T_COST_CENTERTableAdapter = null;
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
            // timer1
            // 
            this.timer1.Interval = 1200000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gET_COUNT_TEST_UNTESTBindingSource
            // 
            this.gET_COUNT_TEST_UNTESTBindingSource.DataMember = "GET_COUNT_TEST_UNTEST";
            this.gET_COUNT_TEST_UNTESTBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // gET_COUNT_TEST_UNTESTTableAdapter
            // 
            this.gET_COUNT_TEST_UNTESTTableAdapter.ClearBeforeFill = true;
            // 
            // gET_NUM_MONEY_CHECKEDBindingSource
            // 
            this.gET_NUM_MONEY_CHECKEDBindingSource.DataMember = "GET_NUM_MONEY_CHECKED";
            this.gET_NUM_MONEY_CHECKEDBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // gET_NUM_MONEY_CHECKEDTableAdapter
            // 
            this.gET_NUM_MONEY_CHECKEDTableAdapter.ClearBeforeFill = true;
            // 
            // gET_ORDER_BY_BOOKING_NUMBindingSource
            // 
            this.gET_ORDER_BY_BOOKING_NUMBindingSource.DataMember = "GET_ORDER_BY_BOOKING_NUM";
            this.gET_ORDER_BY_BOOKING_NUMBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // gET_ORDER_BY_BOOKING_NUMTableAdapter
            // 
            this.gET_ORDER_BY_BOOKING_NUMTableAdapter.ClearBeforeFill = true;
            // 
            // gET_BOOKING_BY_ID_PER_DOCTBindingSource
            // 
            this.gET_BOOKING_BY_ID_PER_DOCTBindingSource.DataMember = "GET_BOOKING_BY_ID_PER_DOCT";
            this.gET_BOOKING_BY_ID_PER_DOCTBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // gET_BOOKING_BY_ID_PER_DOCTTableAdapter
            // 
            this.gET_BOOKING_BY_ID_PER_DOCTTableAdapter.ClearBeforeFill = true;
            // 
            // v_A_DOCTORTableAdapter
            // 
            this.v_A_DOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.33813F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.66187F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(775, 468);
            this.tableLayoutPanel3.TabIndex = 108;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.PIC_CLOSE);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 26);
            this.panel3.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "ALL BOOKING";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PIC_CLOSE
            // 
            this.PIC_CLOSE.Dock = System.Windows.Forms.DockStyle.Right;
            this.PIC_CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("PIC_CLOSE.Image")));
            this.PIC_CLOSE.Location = new System.Drawing.Point(732, 0);
            this.PIC_CLOSE.Margin = new System.Windows.Forms.Padding(2);
            this.PIC_CLOSE.Name = "PIC_CLOSE";
            this.PIC_CLOSE.Size = new System.Drawing.Size(33, 26);
            this.PIC_CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_CLOSE.TabIndex = 1;
            this.PIC_CLOSE.TabStop = false;
            this.PIC_CLOSE.Click += new System.EventHandler(this.PIC_CLOSE_Click);
            // 
            // FRM_BOOK_PIC_SEARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 472);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_BOOK_PIC_SEARCH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كل الحجوزات";
            this.Load += new System.EventHandler(this.FRM_SHOW_ALL_BOOKING_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_BOOKING_BY_DATEBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gET_COUNT_TEST_UNTESTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_NUM_MONEY_CHECKEDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ORDER_BY_BOOKING_NUMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_BOOKING_BY_ID_PER_DOCTBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_CLOSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource gET_BOOKING_BY_DATEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_BOOKING_BY_DATETableAdapter gET_BOOKING_BY_DATETableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker DATE_BOOKING;
        private System.Windows.Forms.Label LBL_NUM_NO_PAID;
        private System.Windows.Forms.Label LBL_NUM_PAID;
        private System.Windows.Forms.Label LBL_TOTAT_PAY_FOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource gET_COUNT_TEST_UNTESTBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_COUNT_TEST_UNTESTTableAdapter gET_COUNT_TEST_UNTESTTableAdapter;
        private System.Windows.Forms.BindingSource gET_NUM_MONEY_CHECKEDBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_NUM_MONEY_CHECKEDTableAdapter gET_NUM_MONEY_CHECKEDTableAdapter;
        private System.Windows.Forms.Label LBL_UNTEST;
        private System.Windows.Forms.Label LBL_TESTED;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource gET_ORDER_BY_BOOKING_NUMBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ORDER_BY_BOOKING_NUMTableAdapter gET_ORDER_BY_BOOKING_NUMTableAdapter;
        private System.Windows.Forms.Label LBL_NUM_PER;
        private System.Windows.Forms.BindingSource gET_BOOKING_BY_ID_PER_DOCTBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_BOOKING_BY_ID_PER_DOCTTableAdapter gET_BOOKING_BY_ID_PER_DOCTTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.BindingSource v_A_DOCTORBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter v_A_DOCTORTableAdapter;
        private System.Windows.Forms.ComboBox dOCTOR_NAMEComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PIC_CLOSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDACTIVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISEASETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEBOOKINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEBOOKINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cHECKEDDOCDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mONEYCHECKDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEBOOKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRAGENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERTIONPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn oPERATIONFLAGDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pICTUREPERSONDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}