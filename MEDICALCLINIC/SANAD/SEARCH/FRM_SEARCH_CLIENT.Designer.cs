namespace MEDICALCLINIC.SEARCH
{
    partial class FRM_SEARCH_CLIENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SEARCH_CLIENT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cLIENTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNAMEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNAMEENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTBARCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTPHONE1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTPHONE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTPHONE3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEMAILEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAXDEBITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURRANCYCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTTYPECODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTSEQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTACTIVEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gET_CLIENT_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gET_DOCTOR_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_ALL_ACCOUNT_FRO_TOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_BOX_ALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_BOX_ALLTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.gET_ALL_ACCOUNT_FRO_TOTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_ACCOUNT_FRO_TOTableAdapter();
            this.gET_DOCTOR_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_DOCTOR_NAME_CODETableAdapter();
            this.gET_CLIENT_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_CLIENT_NAME_CODETableAdapter();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_CLIENT_NAME_CODEBindingSource)).BeginInit();
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
            CLIENT_CODELabel.Location = new System.Drawing.Point(435, 22);
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
            this.groupBox1.Size = new System.Drawing.Size(556, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(74, 19);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(355, 28);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(556, 425);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTCODEDataGridViewTextBoxColumn,
            this.cLIENTNAMEARDataGridViewTextBoxColumn,
            this.cLIENTNAMEENDataGridViewTextBoxColumn,
            this.cLIENTBARCODEDataGridViewTextBoxColumn,
            this.cLIENTPHONE1DataGridViewTextBoxColumn,
            this.cLIENTPHONE2DataGridViewTextBoxColumn,
            this.cLIENTPHONE3DataGridViewTextBoxColumn,
            this.cLIENTEMAILEDataGridViewTextBoxColumn,
            this.cLIENTNOTEDataGridViewTextBoxColumn,
            this.mAXDEBITDataGridViewTextBoxColumn,
            this.cURRANCYCODEDataGridViewTextBoxColumn,
            this.cLIENTTYPECODEDataGridViewTextBoxColumn,
            this.aCCOUNTCODEDataGridViewTextBoxColumn,
            this.cLIENTSEQDataGridViewTextBoxColumn,
            this.cLIENTACTIVEDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.gET_CLIENT_NAME_CODEBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 21);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
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
            this.dataGridView2.Size = new System.Drawing.Size(550, 401);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // cLIENTCODEDataGridViewTextBoxColumn
            // 
            this.cLIENTCODEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_CODE";
            this.cLIENTCODEDataGridViewTextBoxColumn.HeaderText = "كود المورد";
            this.cLIENTCODEDataGridViewTextBoxColumn.Name = "cLIENTCODEDataGridViewTextBoxColumn";
            this.cLIENTCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTNAMEARDataGridViewTextBoxColumn
            // 
            this.cLIENTNAMEARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cLIENTNAMEARDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NAME_AR";
            this.cLIENTNAMEARDataGridViewTextBoxColumn.HeaderText = "أسم المورد";
            this.cLIENTNAMEARDataGridViewTextBoxColumn.Name = "cLIENTNAMEARDataGridViewTextBoxColumn";
            this.cLIENTNAMEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTNAMEENDataGridViewTextBoxColumn
            // 
            this.cLIENTNAMEENDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NAME_EN";
            this.cLIENTNAMEENDataGridViewTextBoxColumn.HeaderText = "CLIENT_NAME_EN";
            this.cLIENTNAMEENDataGridViewTextBoxColumn.Name = "cLIENTNAMEENDataGridViewTextBoxColumn";
            this.cLIENTNAMEENDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTNAMEENDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTBARCODEDataGridViewTextBoxColumn
            // 
            this.cLIENTBARCODEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_BARCODE";
            this.cLIENTBARCODEDataGridViewTextBoxColumn.HeaderText = "CLIENT_BARCODE";
            this.cLIENTBARCODEDataGridViewTextBoxColumn.Name = "cLIENTBARCODEDataGridViewTextBoxColumn";
            this.cLIENTBARCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTBARCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTPHONE1DataGridViewTextBoxColumn
            // 
            this.cLIENTPHONE1DataGridViewTextBoxColumn.DataPropertyName = "CLIENT_PHONE1";
            this.cLIENTPHONE1DataGridViewTextBoxColumn.HeaderText = "رقم الهاتف";
            this.cLIENTPHONE1DataGridViewTextBoxColumn.Name = "cLIENTPHONE1DataGridViewTextBoxColumn";
            this.cLIENTPHONE1DataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTPHONE1DataGridViewTextBoxColumn.Width = 200;
            // 
            // cLIENTPHONE2DataGridViewTextBoxColumn
            // 
            this.cLIENTPHONE2DataGridViewTextBoxColumn.DataPropertyName = "CLIENT_PHONE2";
            this.cLIENTPHONE2DataGridViewTextBoxColumn.HeaderText = "CLIENT_PHONE2";
            this.cLIENTPHONE2DataGridViewTextBoxColumn.Name = "cLIENTPHONE2DataGridViewTextBoxColumn";
            this.cLIENTPHONE2DataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTPHONE2DataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTPHONE3DataGridViewTextBoxColumn
            // 
            this.cLIENTPHONE3DataGridViewTextBoxColumn.DataPropertyName = "CLIENT_PHONE3";
            this.cLIENTPHONE3DataGridViewTextBoxColumn.HeaderText = "CLIENT_PHONE3";
            this.cLIENTPHONE3DataGridViewTextBoxColumn.Name = "cLIENTPHONE3DataGridViewTextBoxColumn";
            this.cLIENTPHONE3DataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTPHONE3DataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTEMAILEDataGridViewTextBoxColumn
            // 
            this.cLIENTEMAILEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_EMAILE";
            this.cLIENTEMAILEDataGridViewTextBoxColumn.HeaderText = "CLIENT_EMAILE";
            this.cLIENTEMAILEDataGridViewTextBoxColumn.Name = "cLIENTEMAILEDataGridViewTextBoxColumn";
            this.cLIENTEMAILEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTEMAILEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTNOTEDataGridViewTextBoxColumn
            // 
            this.cLIENTNOTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NOTE";
            this.cLIENTNOTEDataGridViewTextBoxColumn.HeaderText = "CLIENT_NOTE";
            this.cLIENTNOTEDataGridViewTextBoxColumn.Name = "cLIENTNOTEDataGridViewTextBoxColumn";
            this.cLIENTNOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTNOTEDataGridViewTextBoxColumn.Visible = false;
            // 
            // mAXDEBITDataGridViewTextBoxColumn
            // 
            this.mAXDEBITDataGridViewTextBoxColumn.DataPropertyName = "MAX_DEBIT";
            this.mAXDEBITDataGridViewTextBoxColumn.HeaderText = "MAX_DEBIT";
            this.mAXDEBITDataGridViewTextBoxColumn.Name = "mAXDEBITDataGridViewTextBoxColumn";
            this.mAXDEBITDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAXDEBITDataGridViewTextBoxColumn.Visible = false;
            // 
            // cURRANCYCODEDataGridViewTextBoxColumn
            // 
            this.cURRANCYCODEDataGridViewTextBoxColumn.DataPropertyName = "CURRANCY_CODE";
            this.cURRANCYCODEDataGridViewTextBoxColumn.HeaderText = "CURRANCY_CODE";
            this.cURRANCYCODEDataGridViewTextBoxColumn.Name = "cURRANCYCODEDataGridViewTextBoxColumn";
            this.cURRANCYCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cURRANCYCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTTYPECODEDataGridViewTextBoxColumn
            // 
            this.cLIENTTYPECODEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_TYPE_CODE";
            this.cLIENTTYPECODEDataGridViewTextBoxColumn.HeaderText = "CLIENT_TYPE_CODE";
            this.cLIENTTYPECODEDataGridViewTextBoxColumn.Name = "cLIENTTYPECODEDataGridViewTextBoxColumn";
            this.cLIENTTYPECODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTTYPECODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTCODEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTCODEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_CODE";
            this.aCCOUNTCODEDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_CODE";
            this.aCCOUNTCODEDataGridViewTextBoxColumn.Name = "aCCOUNTCODEDataGridViewTextBoxColumn";
            this.aCCOUNTCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTSEQDataGridViewTextBoxColumn
            // 
            this.cLIENTSEQDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_SEQ";
            this.cLIENTSEQDataGridViewTextBoxColumn.HeaderText = "CLIENT_SEQ";
            this.cLIENTSEQDataGridViewTextBoxColumn.Name = "cLIENTSEQDataGridViewTextBoxColumn";
            this.cLIENTSEQDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTSEQDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTACTIVEDataGridViewCheckBoxColumn
            // 
            this.cLIENTACTIVEDataGridViewCheckBoxColumn.DataPropertyName = "CLIENT_ACTIVE";
            this.cLIENTACTIVEDataGridViewCheckBoxColumn.HeaderText = "CLIENT_ACTIVE";
            this.cLIENTACTIVEDataGridViewCheckBoxColumn.Name = "cLIENTACTIVEDataGridViewCheckBoxColumn";
            this.cLIENTACTIVEDataGridViewCheckBoxColumn.ReadOnly = true;
            this.cLIENTACTIVEDataGridViewCheckBoxColumn.Visible = false;
            // 
            // gET_CLIENT_NAME_CODEBindingSource
            // 
            this.gET_CLIENT_NAME_CODEBindingSource.DataMember = "GET_CLIENT_NAME_CODE";
            this.gET_CLIENT_NAME_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
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
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 95);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SteelBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("STV", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(293, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(201, 73);
            this.button9.TabIndex = 116;
            this.button9.Text = "تفاصيل";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("STV", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(25, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 73);
            this.button1.TabIndex = 117;
            this.button1.Text = "خروج";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableAdapterManager.T_CASH_DEBTTableAdapter = null;
            this.tableAdapterManager.T_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.T_CLASS_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_CLIENT_TYPETableAdapter = null;
            this.tableAdapterManager.T_CLIENTTableAdapter = null;
            this.tableAdapterManager.T_CURRANNCYTableAdapter = null;
            this.tableAdapterManager.T_DESCRPTIONTableAdapter = null;
            this.tableAdapterManager.T_DISEASETableAdapter = null;
            this.tableAdapterManager.T_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_DRAGE_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_DRAGETableAdapter = null;
            this.tableAdapterManager.T_GROUP_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_IMAGETableAdapter = null;
            this.tableAdapterManager.T_IMG_PERSTableAdapter = null;
            this.tableAdapterManager.T_ITEMSTableAdapter = null;
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
            // gET_ALL_ACCOUNT_FRO_TOTableAdapter
            // 
            this.gET_ALL_ACCOUNT_FRO_TOTableAdapter.ClearBeforeFill = true;
            // 
            // gET_DOCTOR_NAME_CODETableAdapter
            // 
            this.gET_DOCTOR_NAME_CODETableAdapter.ClearBeforeFill = true;
            // 
            // gET_CLIENT_NAME_CODETableAdapter
            // 
            this.gET_CLIENT_NAME_CODETableAdapter.ClearBeforeFill = true;
            // 
            // FRM_SEARCH_CLIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "FRM_SEARCH_CLIENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_SEARCH_SANAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_CLIENT_NAME_CODEBindingSource)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TXT_SEARCH;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource p_BOX_ALLBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter p_BOX_ALLTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource gET_ALL_ACCOUNT_FRO_TOBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_ACCOUNT_FRO_TOTableAdapter gET_ALL_ACCOUNT_FRO_TOTableAdapter;
        private System.Windows.Forms.BindingSource gET_DOCTOR_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_DOCTOR_NAME_CODETableAdapter gET_DOCTOR_NAME_CODETableAdapter;
        private System.Windows.Forms.BindingSource gET_CLIENT_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_CLIENT_NAME_CODETableAdapter gET_CLIENT_NAME_CODETableAdapter;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNAMEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNAMEENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTBARCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTPHONE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTPHONE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTPHONE3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEMAILEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAXDEBITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURRANCYCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTTYPECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTSEQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cLIENTACTIVEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
    }
}