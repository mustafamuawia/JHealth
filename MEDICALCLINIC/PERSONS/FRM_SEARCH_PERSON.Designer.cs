namespace MEDICALCLINIC.PERSONS
{
    partial class FRM_SEARCH_PERSON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SEARCH_PERSON));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pERSONCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCOTORCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSPERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pICTUREPERSONDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nOTEPERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSHISTORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNOPERSONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRECORDPERSONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPAGEPERSONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNOFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRECORDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPAGEFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEGALMANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAHERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVEPERSONDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sEXNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gET_PERSON_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.BTN_DETAILS = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.gET_PERSON_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_PERSON_NAME_CODETableAdapter();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PERSON_NAME_CODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.AutoSize = true;
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.Location = new System.Drawing.Point(537, 23);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(59, 22);
            CLIENT_CODELabel.TabIndex = 57;
            CLIENT_CODELabel.Text = "البحث ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.groupBox1.Controls.Add(this.TXT_SEARCH);
            this.groupBox1.Controls.Add(CLIENT_CODELabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(162, 19);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(369, 28);
            this.TXT_SEARCH.TabIndex = 58;
            this.TXT_SEARCH.TextChanged += new System.EventHandler(this.TXT_SEARCH_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(736, 431);
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
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeight = 40;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pERSONCODEDataGridViewTextBoxColumn,
            this.pERSONNAMEDataGridViewTextBoxColumn,
            this.dOCOTORCODEDataGridViewTextBoxColumn,
            this.sEXDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.aDDRESSPERSDataGridViewTextBoxColumn,
            this.pICTUREPERSONDataGridViewImageColumn,
            this.nOTEPERSDataGridViewTextBoxColumn,
            this.pERSHISTORYDataGridViewTextBoxColumn,
            this.jOBDataGridViewTextBoxColumn,
            this.iDNOPERSONDataGridViewTextBoxColumn,
            this.iDRECORDPERSONDataGridViewTextBoxColumn,
            this.iDPAGEPERSONDataGridViewTextBoxColumn,
            this.iDNOFDataGridViewTextBoxColumn,
            this.iDRECORDFDataGridViewTextBoxColumn,
            this.iDPAGEFDataGridViewTextBoxColumn,
            this.lEGALMANDataGridViewTextBoxColumn,
            this.fAHERNAMEDataGridViewTextBoxColumn,
            this.aCTIVEPERSONDataGridViewCheckBoxColumn,
            this.sEXNAMEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.gET_PERSON_NAME_CODEBindingSource;
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
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(730, 412);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // pERSONCODEDataGridViewTextBoxColumn
            // 
            this.pERSONCODEDataGridViewTextBoxColumn.DataPropertyName = "PERSON_CODE";
            this.pERSONCODEDataGridViewTextBoxColumn.HeaderText = "الكود";
            this.pERSONCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONCODEDataGridViewTextBoxColumn.Name = "pERSONCODEDataGridViewTextBoxColumn";
            this.pERSONCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pERSONCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pERSONNAMEDataGridViewTextBoxColumn
            // 
            this.pERSONNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pERSONNAMEDataGridViewTextBoxColumn.DataPropertyName = "PERSON_NAME";
            this.pERSONNAMEDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.pERSONNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONNAMEDataGridViewTextBoxColumn.Name = "pERSONNAMEDataGridViewTextBoxColumn";
            this.pERSONNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCOTORCODEDataGridViewTextBoxColumn
            // 
            this.dOCOTORCODEDataGridViewTextBoxColumn.DataPropertyName = "DOCOTOR_CODE";
            this.dOCOTORCODEDataGridViewTextBoxColumn.HeaderText = "DOCOTOR_CODE";
            this.dOCOTORCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCOTORCODEDataGridViewTextBoxColumn.Name = "dOCOTORCODEDataGridViewTextBoxColumn";
            this.dOCOTORCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCOTORCODEDataGridViewTextBoxColumn.Visible = false;
            this.dOCOTORCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sEXDataGridViewTextBoxColumn
            // 
            this.sEXDataGridViewTextBoxColumn.DataPropertyName = "SEX";
            this.sEXDataGridViewTextBoxColumn.HeaderText = "SEX";
            this.sEXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEXDataGridViewTextBoxColumn.Name = "sEXDataGridViewTextBoxColumn";
            this.sEXDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEXDataGridViewTextBoxColumn.Visible = false;
            this.sEXDataGridViewTextBoxColumn.Width = 125;
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "العمر";
            this.aGEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            this.aGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aGEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pHONEDataGridViewTextBoxColumn.Visible = false;
            this.pHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aDDRESSPERSDataGridViewTextBoxColumn
            // 
            this.aDDRESSPERSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS_PERS";
            this.aDDRESSPERSDataGridViewTextBoxColumn.HeaderText = "ADDRESS_PERS";
            this.aDDRESSPERSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDRESSPERSDataGridViewTextBoxColumn.Name = "aDDRESSPERSDataGridViewTextBoxColumn";
            this.aDDRESSPERSDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDDRESSPERSDataGridViewTextBoxColumn.Visible = false;
            this.aDDRESSPERSDataGridViewTextBoxColumn.Width = 125;
            // 
            // pICTUREPERSONDataGridViewImageColumn
            // 
            this.pICTUREPERSONDataGridViewImageColumn.DataPropertyName = "PICTURE_PERSON";
            this.pICTUREPERSONDataGridViewImageColumn.HeaderText = "PICTURE_PERSON";
            this.pICTUREPERSONDataGridViewImageColumn.MinimumWidth = 6;
            this.pICTUREPERSONDataGridViewImageColumn.Name = "pICTUREPERSONDataGridViewImageColumn";
            this.pICTUREPERSONDataGridViewImageColumn.ReadOnly = true;
            this.pICTUREPERSONDataGridViewImageColumn.Visible = false;
            this.pICTUREPERSONDataGridViewImageColumn.Width = 125;
            // 
            // nOTEPERSDataGridViewTextBoxColumn
            // 
            this.nOTEPERSDataGridViewTextBoxColumn.DataPropertyName = "NOTE_PERS";
            this.nOTEPERSDataGridViewTextBoxColumn.HeaderText = "NOTE_PERS";
            this.nOTEPERSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOTEPERSDataGridViewTextBoxColumn.Name = "nOTEPERSDataGridViewTextBoxColumn";
            this.nOTEPERSDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTEPERSDataGridViewTextBoxColumn.Visible = false;
            this.nOTEPERSDataGridViewTextBoxColumn.Width = 125;
            // 
            // pERSHISTORYDataGridViewTextBoxColumn
            // 
            this.pERSHISTORYDataGridViewTextBoxColumn.DataPropertyName = "PERS_HISTORY";
            this.pERSHISTORYDataGridViewTextBoxColumn.HeaderText = "PERS_HISTORY";
            this.pERSHISTORYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSHISTORYDataGridViewTextBoxColumn.Name = "pERSHISTORYDataGridViewTextBoxColumn";
            this.pERSHISTORYDataGridViewTextBoxColumn.ReadOnly = true;
            this.pERSHISTORYDataGridViewTextBoxColumn.Visible = false;
            this.pERSHISTORYDataGridViewTextBoxColumn.Width = 125;
            // 
            // jOBDataGridViewTextBoxColumn
            // 
            this.jOBDataGridViewTextBoxColumn.DataPropertyName = "JOB";
            this.jOBDataGridViewTextBoxColumn.HeaderText = "المهنة";
            this.jOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jOBDataGridViewTextBoxColumn.Name = "jOBDataGridViewTextBoxColumn";
            this.jOBDataGridViewTextBoxColumn.ReadOnly = true;
            this.jOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDNOPERSONDataGridViewTextBoxColumn
            // 
            this.iDNOPERSONDataGridViewTextBoxColumn.DataPropertyName = "ID_NO_PERSON";
            this.iDNOPERSONDataGridViewTextBoxColumn.HeaderText = "الهوية";
            this.iDNOPERSONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNOPERSONDataGridViewTextBoxColumn.Name = "iDNOPERSONDataGridViewTextBoxColumn";
            this.iDNOPERSONDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNOPERSONDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDRECORDPERSONDataGridViewTextBoxColumn
            // 
            this.iDRECORDPERSONDataGridViewTextBoxColumn.DataPropertyName = "ID_RECORD_PERSON";
            this.iDRECORDPERSONDataGridViewTextBoxColumn.HeaderText = "ID_RECORD_PERSON";
            this.iDRECORDPERSONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRECORDPERSONDataGridViewTextBoxColumn.Name = "iDRECORDPERSONDataGridViewTextBoxColumn";
            this.iDRECORDPERSONDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRECORDPERSONDataGridViewTextBoxColumn.Visible = false;
            this.iDRECORDPERSONDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPAGEPERSONDataGridViewTextBoxColumn
            // 
            this.iDPAGEPERSONDataGridViewTextBoxColumn.DataPropertyName = "ID_PAGE_PERSON";
            this.iDPAGEPERSONDataGridViewTextBoxColumn.HeaderText = "ID_PAGE_PERSON";
            this.iDPAGEPERSONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPAGEPERSONDataGridViewTextBoxColumn.Name = "iDPAGEPERSONDataGridViewTextBoxColumn";
            this.iDPAGEPERSONDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPAGEPERSONDataGridViewTextBoxColumn.Visible = false;
            this.iDPAGEPERSONDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDNOFDataGridViewTextBoxColumn
            // 
            this.iDNOFDataGridViewTextBoxColumn.DataPropertyName = "ID_NO_F";
            this.iDNOFDataGridViewTextBoxColumn.HeaderText = "ID_NO_F";
            this.iDNOFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNOFDataGridViewTextBoxColumn.Name = "iDNOFDataGridViewTextBoxColumn";
            this.iDNOFDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNOFDataGridViewTextBoxColumn.Visible = false;
            this.iDNOFDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDRECORDFDataGridViewTextBoxColumn
            // 
            this.iDRECORDFDataGridViewTextBoxColumn.DataPropertyName = "ID_RECORD_F";
            this.iDRECORDFDataGridViewTextBoxColumn.HeaderText = "ID_RECORD_F";
            this.iDRECORDFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRECORDFDataGridViewTextBoxColumn.Name = "iDRECORDFDataGridViewTextBoxColumn";
            this.iDRECORDFDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRECORDFDataGridViewTextBoxColumn.Visible = false;
            this.iDRECORDFDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPAGEFDataGridViewTextBoxColumn
            // 
            this.iDPAGEFDataGridViewTextBoxColumn.DataPropertyName = "ID_PAGE_F";
            this.iDPAGEFDataGridViewTextBoxColumn.HeaderText = "ID_PAGE_F";
            this.iDPAGEFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPAGEFDataGridViewTextBoxColumn.Name = "iDPAGEFDataGridViewTextBoxColumn";
            this.iDPAGEFDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPAGEFDataGridViewTextBoxColumn.Visible = false;
            this.iDPAGEFDataGridViewTextBoxColumn.Width = 125;
            // 
            // lEGALMANDataGridViewTextBoxColumn
            // 
            this.lEGALMANDataGridViewTextBoxColumn.DataPropertyName = "LEGAL_MAN";
            this.lEGALMANDataGridViewTextBoxColumn.HeaderText = "LEGAL_MAN";
            this.lEGALMANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lEGALMANDataGridViewTextBoxColumn.Name = "lEGALMANDataGridViewTextBoxColumn";
            this.lEGALMANDataGridViewTextBoxColumn.ReadOnly = true;
            this.lEGALMANDataGridViewTextBoxColumn.Visible = false;
            this.lEGALMANDataGridViewTextBoxColumn.Width = 125;
            // 
            // fAHERNAMEDataGridViewTextBoxColumn
            // 
            this.fAHERNAMEDataGridViewTextBoxColumn.DataPropertyName = "FAHER_NAME";
            this.fAHERNAMEDataGridViewTextBoxColumn.HeaderText = "FAHER_NAME";
            this.fAHERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fAHERNAMEDataGridViewTextBoxColumn.Name = "fAHERNAMEDataGridViewTextBoxColumn";
            this.fAHERNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fAHERNAMEDataGridViewTextBoxColumn.Visible = false;
            this.fAHERNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCTIVEPERSONDataGridViewCheckBoxColumn
            // 
            this.aCTIVEPERSONDataGridViewCheckBoxColumn.DataPropertyName = "ACTIVE_PERSON";
            this.aCTIVEPERSONDataGridViewCheckBoxColumn.HeaderText = "ACTIVE_PERSON";
            this.aCTIVEPERSONDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.aCTIVEPERSONDataGridViewCheckBoxColumn.Name = "aCTIVEPERSONDataGridViewCheckBoxColumn";
            this.aCTIVEPERSONDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aCTIVEPERSONDataGridViewCheckBoxColumn.Visible = false;
            this.aCTIVEPERSONDataGridViewCheckBoxColumn.Width = 125;
            // 
            // sEXNAMEDataGridViewTextBoxColumn
            // 
            this.sEXNAMEDataGridViewTextBoxColumn.DataPropertyName = "SEX_NAME";
            this.sEXNAMEDataGridViewTextBoxColumn.HeaderText = "الجنس";
            this.sEXNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sEXNAMEDataGridViewTextBoxColumn.Name = "sEXNAMEDataGridViewTextBoxColumn";
            this.sEXNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEXNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // gET_PERSON_NAME_CODEBindingSource
            // 
            this.gET_PERSON_NAME_CODEBindingSource.DataMember = "GET_PERSON_NAME_CODE";
            this.gET_PERSON_NAME_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 495);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(736, 89);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.22405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.77595F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_EXIT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_DETAILS, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 70);
            this.tableLayoutPanel1.TabIndex = 136;
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.BackColor = System.Drawing.Color.Red;
            this.BTN_EXIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXIT.Font = new System.Drawing.Font("STV", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EXIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EXIT.Image")));
            this.BTN_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EXIT.Location = new System.Drawing.Point(3, 3);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(243, 64);
            this.BTN_EXIT.TabIndex = 135;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // BTN_DETAILS
            // 
            this.BTN_DETAILS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.BTN_DETAILS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_DETAILS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DETAILS.Font = new System.Drawing.Font("STV", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_DETAILS.ForeColor = System.Drawing.Color.White;
            this.BTN_DETAILS.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DETAILS.Image")));
            this.BTN_DETAILS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DETAILS.Location = new System.Drawing.Point(252, 3);
            this.BTN_DETAILS.Name = "BTN_DETAILS";
            this.BTN_DETAILS.Size = new System.Drawing.Size(475, 64);
            this.BTN_DETAILS.TabIndex = 134;
            this.BTN_DETAILS.Text = "تفاصيل";
            this.BTN_DETAILS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_DETAILS.UseVisualStyleBackColor = false;
            this.BTN_DETAILS.Click += new System.EventHandler(this.BTN_DETAILS_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // gET_PERSON_NAME_CODETableAdapter
            // 
            this.gET_PERSON_NAME_CODETableAdapter.ClearBeforeFill = true;
            // 
            // FRM_SEARCH_PERSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "FRM_SEARCH_PERSON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_SEARCH_SANAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PERSON_NAME_CODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BTN_DETAILS;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource gET_PERSON_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_PERSON_NAME_CODETableAdapter gET_PERSON_NAME_CODETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCOTORCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSPERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pICTUREPERSONDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEPERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSHISTORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNOPERSONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRECORDPERSONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPAGEPERSONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNOFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRECORDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPAGEFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEGALMANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAHERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aCTIVEPERSONDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXNAMEDataGridViewTextBoxColumn;
    }
}