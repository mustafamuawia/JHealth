namespace MEDICALCLINIC.OPERATION_PP
{
    partial class FRM_ALL_OPERTION_PRICE
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ALL_OPERTION_PRICE));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bOOKINGCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKINGTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISEASETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEBOOKINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEBOOKINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERTIONPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kSHFIAPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.DATE_TIME = new System.Windows.Forms.DateTimePicker();
            this.dOCTOR_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.v_A_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_A_DOCTORTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.gET_PERSON_BY_DOCT_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_PERSON_BY_DOCT_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_PERSON_BY_DOCT_CODETableAdapter();
            this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PRICE_OPERTION_BY_GRIDTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            dOCTOR_NAMELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PERSON_BY_DOCT_CODEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dOCTOR_NAMELabel
            // 
            dOCTOR_NAMELabel.AutoSize = true;
            dOCTOR_NAMELabel.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dOCTOR_NAMELabel.ForeColor = System.Drawing.Color.Yellow;
            dOCTOR_NAMELabel.Location = new System.Drawing.Point(782, 77);
            dOCTOR_NAMELabel.Name = "dOCTOR_NAMELabel";
            dOCTOR_NAMELabel.Size = new System.Drawing.Size(98, 21);
            dOCTOR_NAMELabel.TabIndex = 0;
            dOCTOR_NAMELabel.Text = "أسم الدكتور:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label1.ForeColor = System.Drawing.Color.Yellow;
            label1.Location = new System.Drawing.Point(782, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 21);
            label1.TabIndex = 73;
            label1.Text = "التـــأريــــخ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 515);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(884, 8);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(884, 405);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "كل البيانات";
            // 
            // p_GET_PRICE_OPERTION_BY_GRIDDataGridView
            // 
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.AllowUserToAddRows = false;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.AllowUserToDeleteRows = false;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.AutoGenerateColumns = false;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.ColumnHeadersHeight = 35;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.bOOKINGCODEDataGridViewTextBoxColumn,
            this.pERSONNAMEDataGridViewTextBoxColumn,
            this.bOOKINGTYPEDataGridViewTextBoxColumn,
            this.dISEASETYPEDataGridViewTextBoxColumn,
            this.dATEBOOKINGDataGridViewTextBoxColumn,
            this.tIMEBOOKINGDataGridViewTextBoxColumn,
            this.oPERTIONPRICEDataGridViewTextBoxColumn,
            this.pERSONCODEDataGridViewTextBoxColumn,
            this.dOCTORCODEDataGridViewTextBoxColumn,
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn,
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn,
            this.kSHFIAPRICEDataGridViewTextBoxColumn});
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.DataSource = this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.Location = new System.Drawing.Point(3, 21);
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.Name = "p_GET_PRICE_OPERTION_BY_GRIDDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.RowHeadersVisible = false;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.RowHeadersWidth = 51;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.RowTemplate.Height = 40;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.Size = new System.Drawing.Size(878, 381);
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.TabIndex = 0;
            this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BOOKING_CODE";
            this.Column1.HeaderText = "دفع الحساب";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "دفع الحساب";
            this.Column1.ToolTipText = "دفع الحساب";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 125;
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
            // pERSONNAMEDataGridViewTextBoxColumn
            // 
            this.pERSONNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pERSONNAMEDataGridViewTextBoxColumn.DataPropertyName = "PERSON_NAME";
            this.pERSONNAMEDataGridViewTextBoxColumn.HeaderText = "أسم المريض";
            this.pERSONNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONNAMEDataGridViewTextBoxColumn.Name = "pERSONNAMEDataGridViewTextBoxColumn";
            // 
            // bOOKINGTYPEDataGridViewTextBoxColumn
            // 
            this.bOOKINGTYPEDataGridViewTextBoxColumn.DataPropertyName = "BOOKING_TYPE";
            this.bOOKINGTYPEDataGridViewTextBoxColumn.HeaderText = "BOOKING_TYPE";
            this.bOOKINGTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bOOKINGTYPEDataGridViewTextBoxColumn.Name = "bOOKINGTYPEDataGridViewTextBoxColumn";
            this.bOOKINGTYPEDataGridViewTextBoxColumn.Visible = false;
            this.bOOKINGTYPEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dISEASETYPEDataGridViewTextBoxColumn
            // 
            this.dISEASETYPEDataGridViewTextBoxColumn.DataPropertyName = "DISEASE_TYPE";
            this.dISEASETYPEDataGridViewTextBoxColumn.HeaderText = "نوع المرض";
            this.dISEASETYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dISEASETYPEDataGridViewTextBoxColumn.Name = "dISEASETYPEDataGridViewTextBoxColumn";
            this.dISEASETYPEDataGridViewTextBoxColumn.Width = 150;
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
            // oPERTIONPRICEDataGridViewTextBoxColumn
            // 
            this.oPERTIONPRICEDataGridViewTextBoxColumn.DataPropertyName = "OPERTION_PRICE";
            this.oPERTIONPRICEDataGridViewTextBoxColumn.HeaderText = "المبلغ";
            this.oPERTIONPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oPERTIONPRICEDataGridViewTextBoxColumn.Name = "oPERTIONPRICEDataGridViewTextBoxColumn";
            this.oPERTIONPRICEDataGridViewTextBoxColumn.Width = 150;
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
            // pRECENTAGEDOCTDataGridViewTextBoxColumn
            // 
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.DataPropertyName = "PRECENTAGE_DOCT";
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.HeaderText = "PRECENTAGE_DOCT";
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.Name = "pRECENTAGEDOCTDataGridViewTextBoxColumn";
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.Visible = false;
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRECENTAGEKSHFIADataGridViewTextBoxColumn
            // 
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.DataPropertyName = "PRECENTAGE_KSHFIA";
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.HeaderText = "PRECENTAGE_KSHFIA";
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.Name = "pRECENTAGEKSHFIADataGridViewTextBoxColumn";
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.Visible = false;
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.Width = 125;
            // 
            // kSHFIAPRICEDataGridViewTextBoxColumn
            // 
            this.kSHFIAPRICEDataGridViewTextBoxColumn.DataPropertyName = "KSHFIA_PRICE";
            this.kSHFIAPRICEDataGridViewTextBoxColumn.HeaderText = "KSHFIA_PRICE";
            this.kSHFIAPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kSHFIAPRICEDataGridViewTextBoxColumn.Name = "kSHFIAPRICEDataGridViewTextBoxColumn";
            this.kSHFIAPRICEDataGridViewTextBoxColumn.Visible = false;
            this.kSHFIAPRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // p_GET_PRICE_OPERTION_BY_GRIDBindingSource
            // 
            this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource.DataMember = "P_GET_PRICE_OPERTION_BY_GRID";
            this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(this.DATE_TIME);
            this.groupBox3.Controls.Add(dOCTOR_NAMELabel);
            this.groupBox3.Controls.Add(this.dOCTOR_NAMEComboBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(884, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(370, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 91);
            this.button1.TabIndex = 104;
            this.button1.Text = "بحث";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(6, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 91);
            this.button8.TabIndex = 105;
            this.button8.Text = "خروج";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // DATE_TIME
            // 
            this.DATE_TIME.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_TIME.Location = new System.Drawing.Point(454, 15);
            this.DATE_TIME.Name = "DATE_TIME";
            this.DATE_TIME.Size = new System.Drawing.Size(322, 30);
            this.DATE_TIME.TabIndex = 72;
            // 
            // dOCTOR_NAMEComboBox
            // 
            this.dOCTOR_NAMEComboBox.DataSource = this.v_A_DOCTORBindingSource;
            this.dOCTOR_NAMEComboBox.DisplayMember = "DOCTOR_NAME";
            this.dOCTOR_NAMEComboBox.Font = new System.Drawing.Font("STV", 14F, System.Drawing.FontStyle.Bold);
            this.dOCTOR_NAMEComboBox.FormattingEnabled = true;
            this.dOCTOR_NAMEComboBox.Location = new System.Drawing.Point(454, 74);
            this.dOCTOR_NAMEComboBox.Name = "dOCTOR_NAMEComboBox";
            this.dOCTOR_NAMEComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dOCTOR_NAMEComboBox.Size = new System.Drawing.Size(320, 29);
            this.dOCTOR_NAMEComboBox.TabIndex = 1;
            this.dOCTOR_NAMEComboBox.ValueMember = "USER_CODE";
            this.dOCTOR_NAMEComboBox.SelectedIndexChanged += new System.EventHandler(this.dOCTOR_NAMEComboBox_SelectedIndexChanged);
            // 
            // v_A_DOCTORBindingSource
            // 
            this.v_A_DOCTORBindingSource.DataMember = "V_A_DOCTOR";
            this.v_A_DOCTORBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
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
            // gET_PERSON_BY_DOCT_CODEBindingSource
            // 
            this.gET_PERSON_BY_DOCT_CODEBindingSource.DataMember = "GET_PERSON_BY_DOCT_CODE";
            this.gET_PERSON_BY_DOCT_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // gET_PERSON_BY_DOCT_CODETableAdapter
            // 
            this.gET_PERSON_BY_DOCT_CODETableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_PRICE_OPERTION_BY_GRIDTableAdapter
            // 
            this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_ALL_OPERTION_PRICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FRM_ALL_OPERTION_PRICE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كل العمليات";
            this.Load += new System.EventHandler(this.FRM_ALL_OPERTION_PRICE_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_PRICE_OPERTION_BY_GRIDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PERSON_BY_DOCT_CODEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource v_A_DOCTORBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter v_A_DOCTORTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox dOCTOR_NAMEComboBox;
        private System.Windows.Forms.BindingSource gET_PERSON_BY_DOCT_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_PERSON_BY_DOCT_CODETableAdapter gET_PERSON_BY_DOCT_CODETableAdapter;
        private System.Windows.Forms.BindingSource p_GET_PRICE_OPERTION_BY_GRIDBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PRICE_OPERTION_BY_GRIDTableAdapter p_GET_PRICE_OPERTION_BY_GRIDTableAdapter;
        private System.Windows.Forms.DateTimePicker DATE_TIME;
        public System.Windows.Forms.DataGridView p_GET_PRICE_OPERTION_BY_GRIDDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISEASETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEBOOKINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEBOOKINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERTIONPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECENTAGEDOCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECENTAGEKSHFIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kSHFIAPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}