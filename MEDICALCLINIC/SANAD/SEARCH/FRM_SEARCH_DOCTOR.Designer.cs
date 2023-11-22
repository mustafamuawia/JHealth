namespace MEDICALCLINIC.SEARCH
{
    partial class FRM_SEARCH_DOCTOR
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
            System.Windows.Forms.Label CLIENT_CODELabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SEARCH_DOCTOR));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gET_DOCTOR_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_DETAILS = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.gET_DOCTOR_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_DOCTOR_NAME_CODETableAdapter();
            this.gET_ALL_ACCOUNT_FRO_TOTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_ACCOUNT_FRO_TOTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.p_BOX_ALLTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter();
            this.p_BOX_ALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_ALL_ACCOUNT_FRO_TOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dOCTORCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORNAMEENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNFOARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNFOENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONECLINICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSCLINICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIGSTERNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAJORCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kSHFIAPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAJORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAJORDETAILSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAJORDETAILSCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_DOCTOR_NAME_CODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_ACCOUNT_FRO_TOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.AutoSize = true;
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.Location = new System.Drawing.Point(785, 24);
            CLIENT_CODELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(73, 28);
            CLIENT_CODELabel.TabIndex = 57;
            CLIENT_CODELabel.Text = "البحث ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.TXT_SEARCH);
            this.groupBox1.Controls.Add(CLIENT_CODELabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(928, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(170, 23);
            this.TXT_SEARCH.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(607, 29);
            this.TXT_SEARCH.TabIndex = 58;
            this.TXT_SEARCH.TextChanged += new System.EventHandler(this.TXT_SEARCH_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(0, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(928, 529);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dOCTORCODEDataGridViewTextBoxColumn,
            this.dOCTORNAMEDataGridViewTextBoxColumn,
            this.dOCTORNAMEENDataGridViewTextBoxColumn,
            this.iNFOARDataGridViewTextBoxColumn,
            this.iNFOENDataGridViewTextBoxColumn,
            this.pHONECLINICDataGridViewTextBoxColumn,
            this.aDDRESSCLINICDataGridViewTextBoxColumn,
            this.rIGSTERNUMBERDataGridViewTextBoxColumn,
            this.mAJORCODEDataGridViewTextBoxColumn,
            this.kSHFIAPRICEDataGridViewTextBoxColumn,
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn,
            this.mAJORNAMEDataGridViewTextBoxColumn,
            this.mAJORDETAILSNAMEDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.mAJORDETAILSCODEDataGridViewTextBoxColumn,
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn,
            this.gROUPCODEDataGridViewTextBoxColumn,
            this.gROUPNAMEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.gET_DOCTOR_NAME_CODEBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(4, 23);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(920, 502);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // gET_DOCTOR_NAME_CODEBindingSource
            // 
            this.gET_DOCTOR_NAME_CODEBindingSource.DataMember = "GET_DOCTOR_NAME_CODE";
            this.gET_DOCTOR_NAME_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.BTN_DETAILS);
            this.groupBox3.Controls.Add(this.BTN_EXIT);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 608);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(928, 111);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // BTN_DETAILS
            // 
            this.BTN_DETAILS.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_DETAILS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DETAILS.Font = new System.Drawing.Font("STV", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_DETAILS.ForeColor = System.Drawing.Color.White;
            this.BTN_DETAILS.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DETAILS.Image")));
            this.BTN_DETAILS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DETAILS.Location = new System.Drawing.Point(318, 13);
            this.BTN_DETAILS.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_DETAILS.Name = "BTN_DETAILS";
            this.BTN_DETAILS.Size = new System.Drawing.Size(597, 90);
            this.BTN_DETAILS.TabIndex = 122;
            this.BTN_DETAILS.Text = "تفاصيل";
            this.BTN_DETAILS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_DETAILS.UseVisualStyleBackColor = false;
            this.BTN_DETAILS.Click += new System.EventHandler(this.BTN_DETAILS_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.BackColor = System.Drawing.Color.Red;
            this.BTN_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXIT.Font = new System.Drawing.Font("STV", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EXIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EXIT.Image")));
            this.BTN_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EXIT.Location = new System.Drawing.Point(13, 13);
            this.BTN_EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(297, 90);
            this.BTN_EXIT.TabIndex = 123;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // gET_DOCTOR_NAME_CODETableAdapter
            // 
            this.gET_DOCTOR_NAME_CODETableAdapter.ClearBeforeFill = true;
            // 
            // gET_ALL_ACCOUNT_FRO_TOTableAdapter
            // 
            this.gET_ALL_ACCOUNT_FRO_TOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.T_ACCOUNT_TYPETableAdapter = null;
            this.tableAdapterManager.T_ACCOUNTSTableAdapter = null;
            this.tableAdapterManager.T_BILL_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOK_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_BOX_HISTORYTableAdapter = null;
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
            this.tableAdapterManager.T_GROUP_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_IMAGETableAdapter = null;
            this.tableAdapterManager.T_IMG_PERSTableAdapter = null;
            this.tableAdapterManager.T_ITEMSTableAdapter = null;
            this.tableAdapterManager.T_MAJOR_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_MAJORTableAdapter = null;
            this.tableAdapterManager.T_ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_ORDERTableAdapter = null;
            this.tableAdapterManager.T_PERSONTableAdapter = null;
            this.tableAdapterManager.T_PURCHES_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_PURCHESTableAdapter = null;
            this.tableAdapterManager.T_SEX_STATETableAdapter = null;
            this.tableAdapterManager.T_STATETableAdapter = null;
            this.tableAdapterManager.T_TOOTH_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_TRATMENT_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_TYPE_MOVETableAdapter = null;
            this.tableAdapterManager.T_TYPE_PAYTableAdapter = null;
            
            this.tableAdapterManager.T_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p_BOX_ALLTableAdapter
            // 
            this.p_BOX_ALLTableAdapter.ClearBeforeFill = true;
            // 
            // p_BOX_ALLBindingSource
            // 
            this.p_BOX_ALLBindingSource.DataMember = "P_BOX_ALL";
            // 
            // gET_ALL_ACCOUNT_FRO_TOBindingSource
            // 
            this.gET_ALL_ACCOUNT_FRO_TOBindingSource.DataMember = "GET_ALL_ACCOUNT_FRO_TO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dOCTORCODEDataGridViewTextBoxColumn
            // 
            this.dOCTORCODEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_CODE";
            this.dOCTORCODEDataGridViewTextBoxColumn.HeaderText = "الكود";
            this.dOCTORCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCTORCODEDataGridViewTextBoxColumn.Name = "dOCTORCODEDataGridViewTextBoxColumn";
            this.dOCTORCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCTORCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOCTORNAMEDataGridViewTextBoxColumn
            // 
            this.dOCTORNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dOCTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NAME";
            this.dOCTORNAMEDataGridViewTextBoxColumn.HeaderText = "أسم الدكتور";
            this.dOCTORNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCTORNAMEDataGridViewTextBoxColumn.Name = "dOCTORNAMEDataGridViewTextBoxColumn";
            this.dOCTORNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCTORNAMEENDataGridViewTextBoxColumn
            // 
            this.dOCTORNAMEENDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NAME_EN";
            this.dOCTORNAMEENDataGridViewTextBoxColumn.HeaderText = "DOCTOR_NAME_EN";
            this.dOCTORNAMEENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCTORNAMEENDataGridViewTextBoxColumn.Name = "dOCTORNAMEENDataGridViewTextBoxColumn";
            this.dOCTORNAMEENDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCTORNAMEENDataGridViewTextBoxColumn.Visible = false;
            this.dOCTORNAMEENDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNFOARDataGridViewTextBoxColumn
            // 
            this.iNFOARDataGridViewTextBoxColumn.DataPropertyName = "INFO_AR";
            this.iNFOARDataGridViewTextBoxColumn.HeaderText = "INFO_AR";
            this.iNFOARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNFOARDataGridViewTextBoxColumn.Name = "iNFOARDataGridViewTextBoxColumn";
            this.iNFOARDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNFOARDataGridViewTextBoxColumn.Visible = false;
            this.iNFOARDataGridViewTextBoxColumn.Width = 125;
            // 
            // iNFOENDataGridViewTextBoxColumn
            // 
            this.iNFOENDataGridViewTextBoxColumn.DataPropertyName = "INFO_EN";
            this.iNFOENDataGridViewTextBoxColumn.HeaderText = "INFO_EN";
            this.iNFOENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iNFOENDataGridViewTextBoxColumn.Name = "iNFOENDataGridViewTextBoxColumn";
            this.iNFOENDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNFOENDataGridViewTextBoxColumn.Visible = false;
            this.iNFOENDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHONECLINICDataGridViewTextBoxColumn
            // 
            this.pHONECLINICDataGridViewTextBoxColumn.DataPropertyName = "PHONE_CLINIC";
            this.pHONECLINICDataGridViewTextBoxColumn.HeaderText = "PHONE_CLINIC";
            this.pHONECLINICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONECLINICDataGridViewTextBoxColumn.Name = "pHONECLINICDataGridViewTextBoxColumn";
            this.pHONECLINICDataGridViewTextBoxColumn.ReadOnly = true;
            this.pHONECLINICDataGridViewTextBoxColumn.Visible = false;
            this.pHONECLINICDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDDRESSCLINICDataGridViewTextBoxColumn
            // 
            this.aDDRESSCLINICDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS_CLINIC";
            this.aDDRESSCLINICDataGridViewTextBoxColumn.HeaderText = "ADDRESS_CLINIC";
            this.aDDRESSCLINICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDRESSCLINICDataGridViewTextBoxColumn.Name = "aDDRESSCLINICDataGridViewTextBoxColumn";
            this.aDDRESSCLINICDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDDRESSCLINICDataGridViewTextBoxColumn.Visible = false;
            this.aDDRESSCLINICDataGridViewTextBoxColumn.Width = 125;
            // 
            // rIGSTERNUMBERDataGridViewTextBoxColumn
            // 
            this.rIGSTERNUMBERDataGridViewTextBoxColumn.DataPropertyName = "RIGSTER_NUMBER";
            this.rIGSTERNUMBERDataGridViewTextBoxColumn.HeaderText = "RIGSTER_NUMBER";
            this.rIGSTERNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rIGSTERNUMBERDataGridViewTextBoxColumn.Name = "rIGSTERNUMBERDataGridViewTextBoxColumn";
            this.rIGSTERNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            this.rIGSTERNUMBERDataGridViewTextBoxColumn.Visible = false;
            this.rIGSTERNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAJORCODEDataGridViewTextBoxColumn
            // 
            this.mAJORCODEDataGridViewTextBoxColumn.DataPropertyName = "MAJOR_CODE";
            this.mAJORCODEDataGridViewTextBoxColumn.HeaderText = "MAJOR_CODE";
            this.mAJORCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAJORCODEDataGridViewTextBoxColumn.Name = "mAJORCODEDataGridViewTextBoxColumn";
            this.mAJORCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAJORCODEDataGridViewTextBoxColumn.Visible = false;
            this.mAJORCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // kSHFIAPRICEDataGridViewTextBoxColumn
            // 
            this.kSHFIAPRICEDataGridViewTextBoxColumn.DataPropertyName = "KSHFIA_PRICE";
            this.kSHFIAPRICEDataGridViewTextBoxColumn.HeaderText = "KSHFIA_PRICE";
            this.kSHFIAPRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kSHFIAPRICEDataGridViewTextBoxColumn.Name = "kSHFIAPRICEDataGridViewTextBoxColumn";
            this.kSHFIAPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.kSHFIAPRICEDataGridViewTextBoxColumn.Visible = false;
            this.kSHFIAPRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRECENTAGEDOCTDataGridViewTextBoxColumn
            // 
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.DataPropertyName = "PRECENTAGE_DOCT";
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.HeaderText = "PRECENTAGE_DOCT";
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.Name = "pRECENTAGEDOCTDataGridViewTextBoxColumn";
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.Visible = false;
            this.pRECENTAGEDOCTDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAJORNAMEDataGridViewTextBoxColumn
            // 
            this.mAJORNAMEDataGridViewTextBoxColumn.DataPropertyName = "MAJOR_NAME";
            this.mAJORNAMEDataGridViewTextBoxColumn.HeaderText = "التخصص";
            this.mAJORNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAJORNAMEDataGridViewTextBoxColumn.Name = "mAJORNAMEDataGridViewTextBoxColumn";
            this.mAJORNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAJORNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // mAJORDETAILSNAMEDataGridViewTextBoxColumn
            // 
            this.mAJORDETAILSNAMEDataGridViewTextBoxColumn.DataPropertyName = "MAJOR_DETAILS_NAME";
            this.mAJORDETAILSNAMEDataGridViewTextBoxColumn.HeaderText = "التخصص الدقيق";
            this.mAJORDETAILSNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAJORDETAILSNAMEDataGridViewTextBoxColumn.Name = "mAJORDETAILSNAMEDataGridViewTextBoxColumn";
            this.mAJORDETAILSNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAJORDETAILSNAMEDataGridViewTextBoxColumn.Width = 180;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Visible = false;
            this.expr1DataGridViewTextBoxColumn.Width = 125;
            // 
            // mAJORDETAILSCODEDataGridViewTextBoxColumn
            // 
            this.mAJORDETAILSCODEDataGridViewTextBoxColumn.DataPropertyName = "MAJOR_DETAILS_CODE";
            this.mAJORDETAILSCODEDataGridViewTextBoxColumn.HeaderText = "MAJOR_DETAILS_CODE";
            this.mAJORDETAILSCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAJORDETAILSCODEDataGridViewTextBoxColumn.Name = "mAJORDETAILSCODEDataGridViewTextBoxColumn";
            this.mAJORDETAILSCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAJORDETAILSCODEDataGridViewTextBoxColumn.Visible = false;
            this.mAJORDETAILSCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRECENTAGEKSHFIADataGridViewTextBoxColumn
            // 
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.DataPropertyName = "PRECENTAGE_KSHFIA";
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.HeaderText = "PRECENTAGE_KSHFIA";
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.Name = "pRECENTAGEKSHFIADataGridViewTextBoxColumn";
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.Visible = false;
            this.pRECENTAGEKSHFIADataGridViewTextBoxColumn.Width = 125;
            // 
            // gROUPCODEDataGridViewTextBoxColumn
            // 
            this.gROUPCODEDataGridViewTextBoxColumn.DataPropertyName = "GROUP_CODE";
            this.gROUPCODEDataGridViewTextBoxColumn.HeaderText = "GROUP_CODE";
            this.gROUPCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gROUPCODEDataGridViewTextBoxColumn.Name = "gROUPCODEDataGridViewTextBoxColumn";
            this.gROUPCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.gROUPCODEDataGridViewTextBoxColumn.Visible = false;
            this.gROUPCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // gROUPNAMEDataGridViewTextBoxColumn
            // 
            this.gROUPNAMEDataGridViewTextBoxColumn.DataPropertyName = "GROUP_NAME";
            this.gROUPNAMEDataGridViewTextBoxColumn.HeaderText = "الفئة";
            this.gROUPNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gROUPNAMEDataGridViewTextBoxColumn.Name = "gROUPNAMEDataGridViewTextBoxColumn";
            this.gROUPNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.gROUPNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // FRM_SEARCH_DOCTOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 719);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FRM_SEARCH_DOCTOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_SEARCH_SANAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_DOCTOR_NAME_CODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_ACCOUNT_FRO_TOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TXT_SEARCH;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BTN_DETAILS;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.BindingSource gET_DOCTOR_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_DOCTOR_NAME_CODETableAdapter gET_DOCTOR_NAME_CODETableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_ACCOUNT_FRO_TOTableAdapter gET_ALL_ACCOUNT_FRO_TOTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter p_BOX_ALLTableAdapter;
        private System.Windows.Forms.BindingSource p_BOX_ALLBindingSource;
        private System.Windows.Forms.BindingSource gET_ALL_ACCOUNT_FRO_TOBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNFOARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNFOENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONECLINICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSCLINICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIGSTERNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAJORCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kSHFIAPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECENTAGEDOCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAJORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAJORDETAILSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAJORDETAILSCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECENTAGEKSHFIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gROUPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gROUPNAMEDataGridViewTextBoxColumn;
    }
}