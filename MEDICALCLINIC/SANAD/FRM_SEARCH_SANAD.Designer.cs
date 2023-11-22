namespace MEDICALCLINIC.SANAD
{
    partial class FRM_SEARCH_SANAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SEARCH_SANAD));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_DETAILS = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.p_BOX_ALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_BOX_ALLTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter();
            this.tIDBOXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILLDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILLDESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOXACTIVEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bRACHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCOSTCENTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.حذف = new System.Windows.Forms.DataGridViewImageColumn();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.AutoSize = true;
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.Location = new System.Drawing.Point(1184, 31);
            CLIENT_CODELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(73, 28);
            CLIENT_CODELabel.TabIndex = 57;
            CLIENT_CODELabel.Text = "البحث ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.TXT_SEARCH);
            this.groupBox1.Controls.Add(CLIENT_CODELabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1284, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("STV", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(16, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 34);
            this.button2.TabIndex = 62;
            this.button2.Text = "بحث بتأريخ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("STV", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(567, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 61;
            this.button1.Text = "بحث عام";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(143, 26);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(177, 32);
            this.dateTimePicker2.TabIndex = 60;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 26);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 32);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(684, 23);
            this.TXT_SEARCH.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(491, 33);
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
            this.groupBox2.Size = new System.Drawing.Size(1284, 534);
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
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDBOXDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.bILLDATEDataGridViewTextBoxColumn,
            this.bILLDESCDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.bOXACTIVEDataGridViewCheckBoxColumn,
            this.bRACHIDDataGridViewTextBoxColumn,
            this.iDCOSTCENTERDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.detailsDataGridViewTextBoxColumn,
            this.حذف});
            this.dataGridView2.DataSource = this.p_BOX_ALLBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(4, 26);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1276, 504);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.groupBox3.Location = new System.Drawing.Point(0, 613);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1284, 106);
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
            this.BTN_DETAILS.Location = new System.Drawing.Point(663, 19);
            this.BTN_DETAILS.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_DETAILS.Name = "BTN_DETAILS";
            this.BTN_DETAILS.Size = new System.Drawing.Size(308, 79);
            this.BTN_DETAILS.TabIndex = 138;
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
            this.BTN_EXIT.Location = new System.Drawing.Point(329, 19);
            this.BTN_EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(243, 79);
            this.BTN_EXIT.TabIndex = 139;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
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
            this.tableAdapterManager.T_BOOKING_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_BOX_DETAILS_T_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOX_DETAILS_TTableAdapter = null;
            this.tableAdapterManager.T_BOX_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOX_T_HISTORYTableAdapter = null;
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
            this.tableAdapterManager.T_L_JOIN_CATEG_TESTTableAdapter = null;
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
            this.tableAdapterManager.T_QNTY_DRAGETableAdapter = null;
            this.tableAdapterManager.T_RAY_NAMETableAdapter = null;
            this.tableAdapterManager.T_RAYROOM_NAMETableAdapter = null;
            this.tableAdapterManager.T_REGION_TYPETableAdapter = null;
            this.tableAdapterManager.T_REGIONS_BODYTableAdapter = null;
            this.tableAdapterManager.T_RPT_IMG_LABTableAdapter = null;
            this.tableAdapterManager.T_RPT_IMGTableAdapter = null;
            this.tableAdapterManager.T_SEX_STATETableAdapter = null;
            this.tableAdapterManager.T_STATETableAdapter = null;
            this.tableAdapterManager.T_TIME_DRAGETableAdapter = null;
            this.tableAdapterManager.T_TOOTH_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_TRATMENT_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_TYPE_MOVETableAdapter = null;
            this.tableAdapterManager.T_TYPE_PAYTableAdapter = null;
            this.tableAdapterManager.T_USE_DRAGETableAdapter = null;
            this.tableAdapterManager.T_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // tIDBOXDataGridViewTextBoxColumn
            // 
            this.tIDBOXDataGridViewTextBoxColumn.DataPropertyName = "T_ID_BOX";
            this.tIDBOXDataGridViewTextBoxColumn.HeaderText = "T_ID_BOX";
            this.tIDBOXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIDBOXDataGridViewTextBoxColumn.Name = "tIDBOXDataGridViewTextBoxColumn";
            this.tIDBOXDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIDBOXDataGridViewTextBoxColumn.Visible = false;
            this.tIDBOXDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BILL_NUMBER";
            this.dataGridViewTextBoxColumn1.HeaderText = " الفاتورة";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // bILLDATEDataGridViewTextBoxColumn
            // 
            this.bILLDATEDataGridViewTextBoxColumn.DataPropertyName = "BILL_DATE";
            this.bILLDATEDataGridViewTextBoxColumn.HeaderText = "التأريخ";
            this.bILLDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bILLDATEDataGridViewTextBoxColumn.Name = "bILLDATEDataGridViewTextBoxColumn";
            this.bILLDATEDataGridViewTextBoxColumn.Width = 150;
            // 
            // bILLDESCDataGridViewTextBoxColumn
            // 
            this.bILLDESCDataGridViewTextBoxColumn.DataPropertyName = "BILL_DESC";
            this.bILLDESCDataGridViewTextBoxColumn.HeaderText = "الوصف";
            this.bILLDESCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bILLDESCDataGridViewTextBoxColumn.Name = "bILLDESCDataGridViewTextBoxColumn";
            this.bILLDESCDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "B_CODE";
            this.dataGridViewTextBoxColumn2.HeaderText = "B_CODE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MOVE_CODE";
            this.dataGridViewTextBoxColumn3.HeaderText = "MOVE_CODE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "USER_CODE";
            this.dataGridViewTextBoxColumn4.HeaderText = "USER_CODE";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // bOXACTIVEDataGridViewCheckBoxColumn
            // 
            this.bOXACTIVEDataGridViewCheckBoxColumn.DataPropertyName = "BOX_ACTIVE";
            this.bOXACTIVEDataGridViewCheckBoxColumn.HeaderText = "BOX_ACTIVE";
            this.bOXACTIVEDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.bOXACTIVEDataGridViewCheckBoxColumn.Name = "bOXACTIVEDataGridViewCheckBoxColumn";
            this.bOXACTIVEDataGridViewCheckBoxColumn.Visible = false;
            this.bOXACTIVEDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bRACHIDDataGridViewTextBoxColumn
            // 
            this.bRACHIDDataGridViewTextBoxColumn.DataPropertyName = "BRACH_ID";
            this.bRACHIDDataGridViewTextBoxColumn.HeaderText = "BRACH_ID";
            this.bRACHIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bRACHIDDataGridViewTextBoxColumn.Name = "bRACHIDDataGridViewTextBoxColumn";
            this.bRACHIDDataGridViewTextBoxColumn.Visible = false;
            this.bRACHIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCOSTCENTERDataGridViewTextBoxColumn
            // 
            this.iDCOSTCENTERDataGridViewTextBoxColumn.DataPropertyName = "ID_COST_CENTER";
            this.iDCOSTCENTERDataGridViewTextBoxColumn.HeaderText = "ID_COST_CENTER";
            this.iDCOSTCENTERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCOSTCENTERDataGridViewTextBoxColumn.Name = "iDCOSTCENTERDataGridViewTextBoxColumn";
            this.iDCOSTCENTERDataGridViewTextBoxColumn.Visible = false;
            this.iDCOSTCENTERDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "B_CODE1";
            this.dataGridViewTextBoxColumn6.HeaderText = "B_CODE1";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "B_NAME";
            this.dataGridViewTextBoxColumn7.HeaderText = "نوع الحركة ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "B_NAME1";
            this.dataGridViewTextBoxColumn8.HeaderText = "B_NAME1";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "تفاصيل القيد";
            this.detailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // حذف
            // 
            this.حذف.HeaderText = "حذف";
            this.حذف.Image = ((System.Drawing.Image)(resources.GetObject("حذف.Image")));
            this.حذف.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.حذف.MinimumWidth = 6;
            this.حذف.Name = "حذف";
            this.حذف.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.حذف.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.حذف.ToolTipText = "حذف";
            this.حذف.Width = 40;
            // 
            // FRM_SEARCH_SANAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 719);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FRM_SEARCH_SANAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_SEARCH_SANAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button BTN_DETAILS;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTFULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTPARENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMODEBITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOCREDITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMODEBITIQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOCREDITIQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCODETODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMETODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTCODETODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNAMETODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTFULLNAMETODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMODEBITTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOCREDITTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMODEBITIQTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOCREDITIQTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCODE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAME1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource p_BOX_ALLBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter p_BOX_ALLTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDBOXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLDESCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bOXACTIVEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRACHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCOSTCENTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn حذف;
    }
}