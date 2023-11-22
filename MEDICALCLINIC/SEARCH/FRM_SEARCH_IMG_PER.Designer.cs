namespace MEDICALCLINIC.SEARCH
{
    partial class FRM_SEARCH_IMG_PER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SEARCH_IMG_PER));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.p_GET_IMG_BEF_AFTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gET_DOCTOR_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_ALL_ACCOUNT_FRO_TOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_BOX_ALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_BOX_ALLTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.gET_ALL_ACCOUNT_FRO_TOTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_ACCOUNT_FRO_TOTableAdapter();
            this.gET_DOCTOR_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_DOCTOR_NAME_CODETableAdapter();
            this.p_GET_IMG_BEF_AFTTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_IMG_BEF_AFTTableAdapter();
            this.bOOKINGCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEBOOKINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEBOOKINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKINGTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISEASETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRAGENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMGE1DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.iMGE2DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.iMGE3DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.iMGE4DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.iMGE5DataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_IMG_BEF_AFTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_DOCTOR_NAME_CODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_ACCOUNT_FRO_TOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.AutoSize = true;
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.Location = new System.Drawing.Point(657, 20);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(59, 22);
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(165, 16);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(486, 28);
            this.TXT_SEARCH.TabIndex = 58;
            this.TXT_SEARCH.TextChanged += new System.EventHandler(this.TXT_SEARCH_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(828, 364);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKINGCODEDataGridViewTextBoxColumn,
            this.pERSONNAMEDataGridViewTextBoxColumn,
            this.dATEBOOKINGDataGridViewTextBoxColumn,
            this.tIMEBOOKINGDataGridViewTextBoxColumn,
            this.dOCTORNAMEDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.sEXNAMEDataGridViewTextBoxColumn,
            this.bOOKINGTYPEDataGridViewTextBoxColumn,
            this.dISEASETYPEDataGridViewTextBoxColumn,
            this.dESCRPTIONDataGridViewTextBoxColumn,
            this.sTATENAMEDataGridViewTextBoxColumn,
            this.dRAGENAMEDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.iMGE1DataGridViewImageColumn,
            this.iMGE2DataGridViewImageColumn,
            this.iMGE3DataGridViewImageColumn,
            this.iMGE4DataGridViewImageColumn,
            this.iMGE5DataGridViewImageColumn});
            this.dataGridView2.DataSource = this.p_GET_IMG_BEF_AFTBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(822, 345);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // p_GET_IMG_BEF_AFTBindingSource
            // 
            this.p_GET_IMG_BEF_AFTBindingSource.DataMember = "P_GET_IMG_BEF_AFT";
            this.p_GET_IMG_BEF_AFTBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.buttonX3);
            this.groupBox3.Controls.Add(this.buttonX4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(828, 95);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX3.Font = new System.Drawing.Font("STV", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX3.Image = ((System.Drawing.Image)(resources.GetObject("buttonX3.Image")));
            this.buttonX3.Location = new System.Drawing.Point(412, 12);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(25, 0, 2, 25);
            this.buttonX3.Size = new System.Drawing.Size(246, 73);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 1;
            this.buttonX3.Text = "Details";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX4.Font = new System.Drawing.Font("STV", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX4.Image = ((System.Drawing.Image)(resources.GetObject("buttonX4.Image")));
            this.buttonX4.Location = new System.Drawing.Point(160, 12);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(25, 0, 2, 25);
            this.buttonX4.Size = new System.Drawing.Size(233, 73);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 5;
            this.buttonX4.Text = "Exit";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gET_DOCTOR_NAME_CODEBindingSource
            // 
            this.gET_DOCTOR_NAME_CODEBindingSource.DataMember = "GET_DOCTOR_NAME_CODE";
            this.gET_DOCTOR_NAME_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // gET_ALL_ACCOUNT_FRO_TOBindingSource
            // 
            this.gET_ALL_ACCOUNT_FRO_TOBindingSource.DataMember = "GET_ALL_ACCOUNT_FRO_TO";
            this.gET_ALL_ACCOUNT_FRO_TOBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_BOX_ALLBindingSource
            // 
            this.p_BOX_ALLBindingSource.DataMember = "P_BOX_ALL";
            this.p_BOX_ALLBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_BOX_ALLTableAdapter
            // 
            this.p_BOX_ALLTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.T_CLIENT_TYPETableAdapter = null;
            this.tableAdapterManager.T_CLIENTTableAdapter = null;
            this.tableAdapterManager.T_DESCRPTIONTableAdapter = null;
            this.tableAdapterManager.T_DISEASETableAdapter = null;
            this.tableAdapterManager.T_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_DRAGETableAdapter = null;
            this.tableAdapterManager.T_IMAGETableAdapter = null;
            this.tableAdapterManager.T_ITEMSTableAdapter = null;
            this.tableAdapterManager.T_MAJORTableAdapter = null;
            this.tableAdapterManager.T_ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_ORDERTableAdapter = null;
            this.tableAdapterManager.T_PERSONTableAdapter = null;
            this.tableAdapterManager.T_PURCHES_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_PURCHESTableAdapter = null;
            this.tableAdapterManager.T_SEX_STATETableAdapter = null;
            this.tableAdapterManager.T_STATETableAdapter = null;
            this.tableAdapterManager.T_TYPE_MOVETableAdapter = null;
            this.tableAdapterManager.T_TYPE_PAYTableAdapter = null;
            this.tableAdapterManager.T_USER_LEVELTableAdapter = null;
            this.tableAdapterManager.T_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gET_ALL_ACCOUNT_FRO_TOTableAdapter
            // 
            this.gET_ALL_ACCOUNT_FRO_TOTableAdapter.ClearBeforeFill = true;
            // 
            // gET_DOCTOR_NAME_CODETableAdapter
            // 
            this.gET_DOCTOR_NAME_CODETableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_IMG_BEF_AFTTableAdapter
            // 
            this.p_GET_IMG_BEF_AFTTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKINGCODEDataGridViewTextBoxColumn
            // 
            this.bOOKINGCODEDataGridViewTextBoxColumn.DataPropertyName = "BOOKING_CODE";
            this.bOOKINGCODEDataGridViewTextBoxColumn.HeaderText = "رقم الحجز";
            this.bOOKINGCODEDataGridViewTextBoxColumn.Name = "bOOKINGCODEDataGridViewTextBoxColumn";
            this.bOOKINGCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pERSONNAMEDataGridViewTextBoxColumn
            // 
            this.pERSONNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pERSONNAMEDataGridViewTextBoxColumn.DataPropertyName = "PERSON_NAME";
            this.pERSONNAMEDataGridViewTextBoxColumn.HeaderText = "أسم المريض";
            this.pERSONNAMEDataGridViewTextBoxColumn.Name = "pERSONNAMEDataGridViewTextBoxColumn";
            this.pERSONNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEBOOKINGDataGridViewTextBoxColumn
            // 
            this.dATEBOOKINGDataGridViewTextBoxColumn.DataPropertyName = "DATE_BOOKING";
            this.dATEBOOKINGDataGridViewTextBoxColumn.HeaderText = "تأريخ الحجز";
            this.dATEBOOKINGDataGridViewTextBoxColumn.Name = "dATEBOOKINGDataGridViewTextBoxColumn";
            this.dATEBOOKINGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIMEBOOKINGDataGridViewTextBoxColumn
            // 
            this.tIMEBOOKINGDataGridViewTextBoxColumn.DataPropertyName = "TIME_BOOKING";
            this.tIMEBOOKINGDataGridViewTextBoxColumn.HeaderText = "وقت الحجز";
            this.tIMEBOOKINGDataGridViewTextBoxColumn.Name = "tIMEBOOKINGDataGridViewTextBoxColumn";
            this.tIMEBOOKINGDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIMEBOOKINGDataGridViewTextBoxColumn.Visible = false;
            // 
            // dOCTORNAMEDataGridViewTextBoxColumn
            // 
            this.dOCTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NAME";
            this.dOCTORNAMEDataGridViewTextBoxColumn.HeaderText = "أسم الدكتور";
            this.dOCTORNAMEDataGridViewTextBoxColumn.Name = "dOCTORNAMEDataGridViewTextBoxColumn";
            this.dOCTORNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "العمر";
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            this.aGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aGEDataGridViewTextBoxColumn.Width = 50;
            // 
            // sEXNAMEDataGridViewTextBoxColumn
            // 
            this.sEXNAMEDataGridViewTextBoxColumn.DataPropertyName = "SEX_NAME";
            this.sEXNAMEDataGridViewTextBoxColumn.HeaderText = "الجنس";
            this.sEXNAMEDataGridViewTextBoxColumn.Name = "sEXNAMEDataGridViewTextBoxColumn";
            this.sEXNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEXNAMEDataGridViewTextBoxColumn.Width = 50;
            // 
            // bOOKINGTYPEDataGridViewTextBoxColumn
            // 
            this.bOOKINGTYPEDataGridViewTextBoxColumn.DataPropertyName = "BOOKING_TYPE";
            this.bOOKINGTYPEDataGridViewTextBoxColumn.HeaderText = "نوع الحجز";
            this.bOOKINGTYPEDataGridViewTextBoxColumn.Name = "bOOKINGTYPEDataGridViewTextBoxColumn";
            this.bOOKINGTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dISEASETYPEDataGridViewTextBoxColumn
            // 
            this.dISEASETYPEDataGridViewTextBoxColumn.DataPropertyName = "DISEASE_TYPE";
            this.dISEASETYPEDataGridViewTextBoxColumn.HeaderText = "نوع المرض";
            this.dISEASETYPEDataGridViewTextBoxColumn.Name = "dISEASETYPEDataGridViewTextBoxColumn";
            this.dISEASETYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRPTION";
            this.dESCRPTIONDataGridViewTextBoxColumn.HeaderText = "الوصف";
            this.dESCRPTIONDataGridViewTextBoxColumn.Name = "dESCRPTIONDataGridViewTextBoxColumn";
            this.dESCRPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRPTIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTATENAMEDataGridViewTextBoxColumn
            // 
            this.sTATENAMEDataGridViewTextBoxColumn.DataPropertyName = "STATE_NAME";
            this.sTATENAMEDataGridViewTextBoxColumn.HeaderText = "الحالة";
            this.sTATENAMEDataGridViewTextBoxColumn.Name = "sTATENAMEDataGridViewTextBoxColumn";
            this.sTATENAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTATENAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // dRAGENAMEDataGridViewTextBoxColumn
            // 
            this.dRAGENAMEDataGridViewTextBoxColumn.DataPropertyName = "DRAGE_NAME";
            this.dRAGENAMEDataGridViewTextBoxColumn.HeaderText = "العلاج";
            this.dRAGENAMEDataGridViewTextBoxColumn.Name = "dRAGENAMEDataGridViewTextBoxColumn";
            this.dRAGENAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dRAGENAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "الملاحظات";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            this.nOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn.Visible = false;
            // 
            // iMGE1DataGridViewImageColumn
            // 
            this.iMGE1DataGridViewImageColumn.DataPropertyName = "IMGE1";
            this.iMGE1DataGridViewImageColumn.HeaderText = "IMGE1";
            this.iMGE1DataGridViewImageColumn.Name = "iMGE1DataGridViewImageColumn";
            this.iMGE1DataGridViewImageColumn.ReadOnly = true;
            this.iMGE1DataGridViewImageColumn.Visible = false;
            // 
            // iMGE2DataGridViewImageColumn
            // 
            this.iMGE2DataGridViewImageColumn.DataPropertyName = "IMGE2";
            this.iMGE2DataGridViewImageColumn.HeaderText = "IMGE2";
            this.iMGE2DataGridViewImageColumn.Name = "iMGE2DataGridViewImageColumn";
            this.iMGE2DataGridViewImageColumn.ReadOnly = true;
            this.iMGE2DataGridViewImageColumn.Visible = false;
            // 
            // iMGE3DataGridViewImageColumn
            // 
            this.iMGE3DataGridViewImageColumn.DataPropertyName = "IMGE3";
            this.iMGE3DataGridViewImageColumn.HeaderText = "IMGE3";
            this.iMGE3DataGridViewImageColumn.Name = "iMGE3DataGridViewImageColumn";
            this.iMGE3DataGridViewImageColumn.ReadOnly = true;
            this.iMGE3DataGridViewImageColumn.Visible = false;
            // 
            // iMGE4DataGridViewImageColumn
            // 
            this.iMGE4DataGridViewImageColumn.DataPropertyName = "IMGE4";
            this.iMGE4DataGridViewImageColumn.HeaderText = "IMGE4";
            this.iMGE4DataGridViewImageColumn.Name = "iMGE4DataGridViewImageColumn";
            this.iMGE4DataGridViewImageColumn.ReadOnly = true;
            this.iMGE4DataGridViewImageColumn.Visible = false;
            // 
            // iMGE5DataGridViewImageColumn
            // 
            this.iMGE5DataGridViewImageColumn.DataPropertyName = "IMGE5";
            this.iMGE5DataGridViewImageColumn.HeaderText = "IMGE5";
            this.iMGE5DataGridViewImageColumn.Name = "iMGE5DataGridViewImageColumn";
            this.iMGE5DataGridViewImageColumn.ReadOnly = true;
            this.iMGE5DataGridViewImageColumn.Visible = false;
            // 
            // FRM_SEARCH_IMG_PER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "FRM_SEARCH_IMG_PER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_SEARCH_SANAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_IMG_BEF_AFTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_DOCTOR_NAME_CODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_ACCOUNT_FRO_TOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TXT_SEARCH;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource p_BOX_ALLBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter p_BOX_ALLTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource gET_ALL_ACCOUNT_FRO_TOBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_ACCOUNT_FRO_TOTableAdapter gET_ALL_ACCOUNT_FRO_TOTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource gET_DOCTOR_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_DOCTOR_NAME_CODETableAdapter gET_DOCTOR_NAME_CODETableAdapter;
        private System.Windows.Forms.BindingSource p_GET_IMG_BEF_AFTBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_IMG_BEF_AFTTableAdapter p_GET_IMG_BEF_AFTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEBOOKINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEBOOKINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISEASETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRAGENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iMGE1DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn iMGE2DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn iMGE3DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn iMGE4DataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn iMGE5DataGridViewImageColumn;
    }
}