
namespace MEDICALCLINIC.USERSE
{
    partial class FRM_ALLUSERS_DEBIT_FOR_DR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ALLUSERS_DEBIT_FOR_DR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.DR_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.gET_DOCTOR_WITH_COST_CENTER_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textsearch = new Green.GreenTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvalldata = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.drcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drcreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gET_ALL_PERSON_DEBIT_FOR_DRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iD_COST_CENTERLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_PRINT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_TOTAL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_PAID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_REMAIN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_PAY_NOW = new System.Windows.Forms.TextBox();
            this.LBL_REMAIN_AFT = new System.Windows.Forms.Label();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.gET_DOCTOR_WITH_COST_CENTER_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_DOCTOR_WITH_COST_CENTER_CODETableAdapter();
            this.gET_ALL_PERSON_DEBIT_FOR_DRTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_PERSON_DEBIT_FOR_DRTableAdapter();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_DOCTOR_WITH_COST_CENTER_CODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalldata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_PERSON_DEBIT_FOR_DRBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 8;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.64748F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.20144F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.1223F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.834532F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.67325F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.642729F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel5.Controls.Add(this.button1, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.DR_NAMEComboBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.BTN_SEARCH, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker1, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker2, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.textsearch, 7, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(893, 27);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(533, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 21);
            this.button1.TabIndex = 100;
            this.button1.Text = "بدون تأريخ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DR_NAMEComboBox
            // 
            this.DR_NAMEComboBox.DataSource = this.gET_DOCTOR_WITH_COST_CENTER_CODEBindingSource;
            this.DR_NAMEComboBox.DisplayMember = "DOCTOR_NAME";
            this.DR_NAMEComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DR_NAMEComboBox.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DR_NAMEComboBox.FormattingEnabled = true;
            this.DR_NAMEComboBox.Location = new System.Drawing.Point(86, 3);
            this.DR_NAMEComboBox.Name = "DR_NAMEComboBox";
            this.DR_NAMEComboBox.Size = new System.Drawing.Size(117, 29);
            this.DR_NAMEComboBox.TabIndex = 3;
            this.DR_NAMEComboBox.ValueMember = "USER_CODE";
            // 
            // gET_DOCTOR_WITH_COST_CENTER_CODEBindingSource
            // 
            this.gET_DOCTOR_WITH_COST_CENTER_CODEBindingSource.DataMember = "GET_DOCTOR_WITH_COST_CENTER_CODE";
            this.gET_DOCTOR_WITH_COST_CENTER_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.Color.Black;
            this.BTN_SEARCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SEARCH.Image")));
            this.BTN_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SEARCH.Location = new System.Drawing.Point(3, 3);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(77, 21);
            this.BTN_SEARCH.TabIndex = 99;
            this.BTN_SEARCH.Text = "بحث";
            this.BTN_SEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(498, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 27);
            this.label4.TabIndex = 100;
            this.label4.Text = "من";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(326, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 27);
            this.label8.TabIndex = 101;
            this.label8.Text = "الى";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 33);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(209, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 33);
            this.dateTimePicker2.TabIndex = 103;
            // 
            // textsearch
            // 
            this.textsearch.BackgroundColor = System.Drawing.Color.Empty;
            this.textsearch.BackgroundColorIsActive = System.Drawing.Color.Empty;
            this.textsearch.BorderColor = System.Drawing.Color.Gainsboro;
            this.textsearch.BorderIsActive = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(172)))), ((int)(((byte)(89)))));
            this.textsearch.BorderWidth = 2;
            this.textsearch.CharSet = "f007";
            this.textsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textsearch.Font = new System.Drawing.Font("STV", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textsearch.IconAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.textsearch.IconColor = System.Drawing.Color.Gainsboro;
            this.textsearch.IconColorIsActive = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.textsearch.IconIsShow = true;
            this.textsearch.IconSize = 12F;
            this.textsearch.IconStyle = Green.BaseIcon.MyEnum.Solid;
            this.textsearch.isDigital = false;
            this.textsearch.LineColor = System.Drawing.Color.Empty;
            this.textsearch.LineColorIsActive = System.Drawing.Color.Empty;
            this.textsearch.Lines = new string[0];
            this.textsearch.Location = new System.Drawing.Point(693, 3);
            this.textsearch.Multiline = false;
            this.textsearch.Name = "textsearch";
            this.textsearch.PaddingIcon = new System.Windows.Forms.Padding(10, 2, 13, 0);
            this.textsearch.PaddingText = new System.Windows.Forms.Padding(15, 10, 20, 10);
            this.textsearch.Radius = 10;
            this.textsearch.ReadOnly = false;
            this.textsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textsearch.Shape = BaseControls.GreenShape.RoundedRectangl;
            this.textsearch.Side = 8;
            this.textsearch.Size = new System.Drawing.Size(197, 39);
            this.textsearch.TabIndex = 104;
            this.textsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textsearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.textsearch.TextStyle = TextStyle.Normal;
            this.textsearch.UseSystemPasswordChar = false;
            this.textsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.textsearch.WaterMarkText = "ادخل النص هنا";
            this.textsearch.TextChanged += new System.EventHandler(this.textsearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 2);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 476);
            this.panel4.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 2);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(903, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 478);
            this.panel1.TabIndex = 11;
            // 
            // dgvalldata
            // 
            this.dgvalldata.AllowUserToAddRows = false;
            this.dgvalldata.AutoGenerateColumns = false;
            this.dgvalldata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvalldata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvalldata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.drcodeDataGridViewTextBoxColumn,
            this.patientcodeDataGridViewTextBoxColumn,
            this.aCCOUNTNAMEDataGridViewTextBoxColumn,
            this.drcreditDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.remainDataGridViewTextBoxColumn});
            this.dgvalldata.DataSource = this.gET_ALL_PERSON_DEBIT_FOR_DRBindingSource;
            this.dgvalldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvalldata.EnableHeadersVisualStyles = false;
            this.dgvalldata.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvalldata.Location = new System.Drawing.Point(3, 36);
            this.dgvalldata.Name = "dgvalldata";
            this.dgvalldata.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvalldata.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvalldata.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvalldata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvalldata.Size = new System.Drawing.Size(893, 347);
            this.dgvalldata.TabIndex = 0;
            this.dgvalldata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalldata_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "تفاصيل";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "تفاصيل";
            this.Column1.ToolTipText = "تفاصيل";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // drcodeDataGridViewTextBoxColumn
            // 
            this.drcodeDataGridViewTextBoxColumn.DataPropertyName = "dr_code";
            this.drcodeDataGridViewTextBoxColumn.HeaderText = "dr_code";
            this.drcodeDataGridViewTextBoxColumn.Name = "drcodeDataGridViewTextBoxColumn";
            this.drcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientcodeDataGridViewTextBoxColumn
            // 
            this.patientcodeDataGridViewTextBoxColumn.DataPropertyName = "patient_code";
            this.patientcodeDataGridViewTextBoxColumn.HeaderText = "كود المريض";
            this.patientcodeDataGridViewTextBoxColumn.Name = "patientcodeDataGridViewTextBoxColumn";
            // 
            // aCCOUNTNAMEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.DataPropertyName = "accountname";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.HeaderText = "أسم المريض";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.Name = "aCCOUNTNAMEDataGridViewTextBoxColumn";
            // 
            // drcreditDataGridViewTextBoxColumn
            // 
            this.drcreditDataGridViewTextBoxColumn.DataPropertyName = "dr_credit";
            this.drcreditDataGridViewTextBoxColumn.HeaderText = "ديون الطبيب";
            this.drcreditDataGridViewTextBoxColumn.Name = "drcreditDataGridViewTextBoxColumn";
            this.drcreditDataGridViewTextBoxColumn.ReadOnly = true;
            this.drcreditDataGridViewTextBoxColumn.Width = 150;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "الواصل";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidDataGridViewTextBoxColumn.Width = 150;
            // 
            // remainDataGridViewTextBoxColumn
            // 
            this.remainDataGridViewTextBoxColumn.DataPropertyName = "remain";
            this.remainDataGridViewTextBoxColumn.HeaderText = "المتبقي";
            this.remainDataGridViewTextBoxColumn.Name = "remainDataGridViewTextBoxColumn";
            this.remainDataGridViewTextBoxColumn.ReadOnly = true;
            this.remainDataGridViewTextBoxColumn.Width = 150;
            // 
            // gET_ALL_PERSON_DEBIT_FOR_DRBindingSource
            // 
            this.gET_ALL_PERSON_DEBIT_FOR_DRBindingSource.DataMember = "GET_ALL_PERSON_DEBIT_FOR_DR";
            this.gET_ALL_PERSON_DEBIT_FOR_DRBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.646447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.001098F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.42678F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.001098F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.29707F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 478);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.pic_exit);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.iD_COST_CENTERLabel1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(2, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(901, 18);
            this.panel7.TabIndex = 5;
            // 
            // pic_exit
            // 
            this.pic_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_exit.Image")));
            this.pic_exit.Location = new System.Drawing.Point(863, 0);
            this.pic_exit.Margin = new System.Windows.Forms.Padding(2);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(38, 18);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_exit.TabIndex = 2;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "كل الديون";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iD_COST_CENTERLabel1
            // 
            this.iD_COST_CENTERLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gET_DOCTOR_WITH_COST_CENTER_CODEBindingSource, "ID_COST_CENTER", true));
            this.iD_COST_CENTERLabel1.Location = new System.Drawing.Point(123, -3);
            this.iD_COST_CENTERLabel1.Name = "iD_COST_CENTERLabel1";
            this.iD_COST_CENTERLabel1.Size = new System.Drawing.Size(77, 21);
            this.iD_COST_CENTERLabel1.TabIndex = 3;
            this.iD_COST_CENTERLabel1.Text = "label9";
            this.iD_COST_CENTERLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.89362F));
            this.tableLayoutPanel3.Controls.Add(this.BTN_PRINT, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.LBL_TOTAL, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.LBL_PAID, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.LBL_REMAIN, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.TXT_PAY_NOW, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.LBL_REMAIN_AFT, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.BTN_SAVE, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 425);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(899, 50);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // BTN_PRINT
            // 
            this.BTN_PRINT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.BTN_PRINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_PRINT.FlatAppearance.BorderSize = 0;
            this.BTN_PRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRINT.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_PRINT.ForeColor = System.Drawing.Color.White;
            this.BTN_PRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_PRINT.Location = new System.Drawing.Point(3, 3);
            this.BTN_PRINT.Name = "BTN_PRINT";
            this.BTN_PRINT.Size = new System.Drawing.Size(106, 20);
            this.BTN_PRINT.TabIndex = 110;
            this.BTN_PRINT.Text = "السندات";
            this.BTN_PRINT.UseVisualStyleBackColor = false;
            this.BTN_PRINT.Click += new System.EventHandler(this.BTN_PRINT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(743, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "مجموع الديون";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // LBL_TOTAL
            // 
            this.LBL_TOTAL.AutoSize = true;
            this.LBL_TOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_TOTAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_TOTAL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TOTAL.ForeColor = System.Drawing.Color.Blue;
            this.LBL_TOTAL.Location = new System.Drawing.Point(743, 26);
            this.LBL_TOTAL.Name = "LBL_TOTAL";
            this.LBL_TOTAL.Size = new System.Drawing.Size(153, 24);
            this.LBL_TOTAL.TabIndex = 5;
            this.LBL_TOTAL.Text = "0.00";
            this.LBL_TOTAL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_TOTAL.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(586, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "الواصل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // LBL_PAID
            // 
            this.LBL_PAID.AutoSize = true;
            this.LBL_PAID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_PAID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_PAID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_PAID.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PAID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LBL_PAID.Location = new System.Drawing.Point(586, 26);
            this.LBL_PAID.Name = "LBL_PAID";
            this.LBL_PAID.Size = new System.Drawing.Size(151, 24);
            this.LBL_PAID.TabIndex = 2;
            this.LBL_PAID.Text = "0.00";
            this.LBL_PAID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_PAID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(429, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "المتبقي";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // LBL_REMAIN
            // 
            this.LBL_REMAIN.AutoSize = true;
            this.LBL_REMAIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_REMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_REMAIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_REMAIN.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_REMAIN.ForeColor = System.Drawing.Color.Red;
            this.LBL_REMAIN.Location = new System.Drawing.Point(429, 26);
            this.LBL_REMAIN.Name = "LBL_REMAIN";
            this.LBL_REMAIN.Size = new System.Drawing.Size(151, 24);
            this.LBL_REMAIN.TabIndex = 4;
            this.LBL_REMAIN.Text = "0.00";
            this.LBL_REMAIN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_REMAIN.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(115, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "المتبقي بعد الدفع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("STV", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(272, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "الواصل الان";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // TXT_PAY_NOW
            // 
            this.TXT_PAY_NOW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_PAY_NOW.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PAY_NOW.Location = new System.Drawing.Point(272, 29);
            this.TXT_PAY_NOW.Name = "TXT_PAY_NOW";
            this.TXT_PAY_NOW.Size = new System.Drawing.Size(151, 30);
            this.TXT_PAY_NOW.TabIndex = 10;
            this.TXT_PAY_NOW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PAY_NOW.Visible = false;
            // 
            // LBL_REMAIN_AFT
            // 
            this.LBL_REMAIN_AFT.AutoSize = true;
            this.LBL_REMAIN_AFT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_REMAIN_AFT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_REMAIN_AFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_REMAIN_AFT.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_REMAIN_AFT.ForeColor = System.Drawing.Color.Red;
            this.LBL_REMAIN_AFT.Location = new System.Drawing.Point(115, 26);
            this.LBL_REMAIN_AFT.Name = "LBL_REMAIN_AFT";
            this.LBL_REMAIN_AFT.Size = new System.Drawing.Size(151, 24);
            this.LBL_REMAIN_AFT.TabIndex = 11;
            this.LBL_REMAIN_AFT.Text = "0.00";
            this.LBL_REMAIN_AFT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_REMAIN_AFT.Visible = false;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.BTN_SAVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_SAVE.FlatAppearance.BorderSize = 0;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_SAVE.ForeColor = System.Drawing.Color.White;
            this.BTN_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SAVE.Location = new System.Drawing.Point(3, 29);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(106, 18);
            this.BTN_SAVE.TabIndex = 109;
            this.BTN_SAVE.Text = "...";
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 24);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(901, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(2, 420);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(901, 1);
            this.panel6.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvalldata, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.80829F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.19171F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(899, 386);
            this.tableLayoutPanel2.TabIndex = 6;
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
            // gET_DOCTOR_WITH_COST_CENTER_CODETableAdapter
            // 
            this.gET_DOCTOR_WITH_COST_CENTER_CODETableAdapter.ClearBeforeFill = true;
            // 
            // gET_ALL_PERSON_DEBIT_FOR_DRTableAdapter
            // 
            this.gET_ALL_PERSON_DEBIT_FOR_DRTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_ALLUSERS_DEBIT_FOR_DR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_ALLUSERS_DEBIT_FOR_DR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كل ديون المرضى";
            this.Load += new System.EventHandler(this.FRM_ALLUSERS_DEBIT_FOR_DR_Load);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_DOCTOR_WITH_COST_CENTER_CODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalldata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_PERSON_DEBIT_FOR_DRBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox DR_NAMEComboBox;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvalldata;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BTN_PRINT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_TOTAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_PAID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_REMAIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_PAY_NOW;
        private System.Windows.Forms.Label LBL_REMAIN_AFT;
        private System.Windows.Forms.Button BTN_SAVE;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.PictureBox pic_exit;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label iD_COST_CENTERLabel1;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_DOCTOR_WITH_COST_CENTER_CODETableAdapter gET_DOCTOR_WITH_COST_CENTER_CODETableAdapter;
        private System.Windows.Forms.BindingSource gET_DOCTOR_WITH_COST_CENTER_CODEBindingSource;
        private System.Windows.Forms.BindingSource gET_ALL_PERSON_DEBIT_FOR_DRBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_PERSON_DEBIT_FOR_DRTableAdapter gET_ALL_PERSON_DEBIT_FOR_DRTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNAME1DataGridViewTextBoxColumn;
        private Green.GreenTextBox textsearch;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn drcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drcreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainDataGridViewTextBoxColumn;
    }
}