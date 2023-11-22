
namespace MEDICALCLINIC.HOSPITAL
{
    partial class FRM_DOCTOR_SCHEDULE
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DOCTOR_SCHEDULE));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DATE_TO = new System.Windows.Forms.DateTimePicker();
            this.dOCTOR_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.v_A_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.COMB_DAY = new System.Windows.Forms.ComboBox();
            this.nAME_B_DEPComboBox = new System.Windows.Forms.ComboBox();
            this.v_H_SUBDEPARTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DATE_FROM = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView = new System.Windows.Forms.DataGridView();
            this.iDSCHDUELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEBDEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAYNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fROMTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPATMENTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gET_SCHDUEL_DOCTOR_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_A_DOCTORTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.v_H_SUBDEPARTMENTTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_H_SUBDEPARTMENTTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gET_SCHDUEL_DOCTOR_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_SCHDUEL_DOCTOR_NAME_CODETableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            dOCTOR_NAMELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_H_SUBDEPARTMENTBindingSource)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_SCHDUEL_DOCTOR_NAME_CODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // dOCTOR_NAMELabel
            // 
            dOCTOR_NAMELabel.AutoSize = true;
            dOCTOR_NAMELabel.Location = new System.Drawing.Point(198, 30);
            dOCTOR_NAMELabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dOCTOR_NAMELabel.Name = "dOCTOR_NAMELabel";
            dOCTOR_NAMELabel.Size = new System.Drawing.Size(73, 15);
            dOCTOR_NAMELabel.TabIndex = 0;
            dOCTOR_NAMELabel.Text = "أسم الدكتور:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(198, 83);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 7;
            label1.Text = "القسم:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(198, 126);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "اليوم:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(198, 176);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 9;
            label3.Text = "من الساعة:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(198, 215);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 15);
            label4.TabIndex = 10;
            label4.Text = "الى الساعة:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.18348F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.81652F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 39);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 364);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("STV", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(502, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(288, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 17);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.92375F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.07625F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(284, 341);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.DATE_TO);
            this.panel1.Controls.Add(this.dOCTOR_NAMEComboBox);
            this.panel1.Controls.Add(dOCTOR_NAMELabel);
            this.panel1.Controls.Add(this.COMB_DAY);
            this.panel1.Controls.Add(this.nAME_B_DEPComboBox);
            this.panel1.Controls.Add(this.DATE_FROM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 288);
            this.panel1.TabIndex = 0;
            // 
            // DATE_TO
            // 
            this.DATE_TO.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DATE_TO.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DATE_TO.Location = new System.Drawing.Point(16, 209);
            this.DATE_TO.Margin = new System.Windows.Forms.Padding(2);
            this.DATE_TO.Name = "DATE_TO";
            this.DATE_TO.Size = new System.Drawing.Size(169, 30);
            this.DATE_TO.TabIndex = 4;
            // 
            // dOCTOR_NAMEComboBox
            // 
            this.dOCTOR_NAMEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_A_DOCTORBindingSource, "DOCTOR_NAME", true));
            this.dOCTOR_NAMEComboBox.DataSource = this.v_A_DOCTORBindingSource;
            this.dOCTOR_NAMEComboBox.DisplayMember = "DOCTOR_NAME";
            this.dOCTOR_NAMEComboBox.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dOCTOR_NAMEComboBox.FormattingEnabled = true;
            this.dOCTOR_NAMEComboBox.Location = new System.Drawing.Point(16, 26);
            this.dOCTOR_NAMEComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.dOCTOR_NAMEComboBox.Name = "dOCTOR_NAMEComboBox";
            this.dOCTOR_NAMEComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dOCTOR_NAMEComboBox.Size = new System.Drawing.Size(169, 26);
            this.dOCTOR_NAMEComboBox.TabIndex = 1;
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
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // COMB_DAY
            // 
            this.COMB_DAY.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.COMB_DAY.FormattingEnabled = true;
            this.COMB_DAY.Items.AddRange(new object[] {
            "السبت ",
            "الاحد ",
            "الاثنين",
            "الثلاثاء",
            "الاربعاء",
            "الخميس ",
            "الجمعة"});
            this.COMB_DAY.Location = new System.Drawing.Point(16, 120);
            this.COMB_DAY.Margin = new System.Windows.Forms.Padding(2);
            this.COMB_DAY.Name = "COMB_DAY";
            this.COMB_DAY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.COMB_DAY.Size = new System.Drawing.Size(169, 26);
            this.COMB_DAY.TabIndex = 6;
            // 
            // nAME_B_DEPComboBox
            // 
            this.nAME_B_DEPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_H_SUBDEPARTMENTBindingSource, "NAME_B_DEP", true));
            this.nAME_B_DEPComboBox.DataSource = this.v_H_SUBDEPARTMENTBindingSource;
            this.nAME_B_DEPComboBox.DisplayMember = "NAME_B_DEP";
            this.nAME_B_DEPComboBox.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nAME_B_DEPComboBox.FormattingEnabled = true;
            this.nAME_B_DEPComboBox.Location = new System.Drawing.Point(16, 77);
            this.nAME_B_DEPComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.nAME_B_DEPComboBox.Name = "nAME_B_DEPComboBox";
            this.nAME_B_DEPComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nAME_B_DEPComboBox.Size = new System.Drawing.Size(169, 26);
            this.nAME_B_DEPComboBox.TabIndex = 3;
            this.nAME_B_DEPComboBox.ValueMember = "ID_B_DEP";
            // 
            // v_H_SUBDEPARTMENTBindingSource
            // 
            this.v_H_SUBDEPARTMENTBindingSource.DataMember = "V_H_SUBDEPARTMENT";
            this.v_H_SUBDEPARTMENTBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // DATE_FROM
            // 
            this.DATE_FROM.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DATE_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DATE_FROM.Location = new System.Drawing.Point(16, 169);
            this.DATE_FROM.Margin = new System.Windows.Forms.Padding(2);
            this.DATE_FROM.Name = "DATE_FROM";
            this.DATE_FROM.Size = new System.Drawing.Size(169, 30);
            this.DATE_FROM.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.BTN_DELETE, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.BTN_EDIT, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.BTN_SAVE, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 294);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(280, 45);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_DELETE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_DELETE.FlatAppearance.BorderSize = 0;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE.Location = new System.Drawing.Point(2, 2);
            this.BTN_DELETE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(90, 41);
            this.BTN_DELETE.TabIndex = 2;
            this.BTN_DELETE.Text = "حذف";
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_EDIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EDIT.FlatAppearance.BorderSize = 0;
            this.BTN_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EDIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EDIT.Location = new System.Drawing.Point(96, 2);
            this.BTN_EDIT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(89, 41);
            this.BTN_EDIT.TabIndex = 1;
            this.BTN_EDIT.Text = "تعديل";
            this.BTN_EDIT.UseVisualStyleBackColor = false;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_SAVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_SAVE.FlatAppearance.BorderSize = 0;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.ForeColor = System.Drawing.Color.White;
            this.BTN_SAVE.Location = new System.Drawing.Point(189, 2);
            this.BTN_SAVE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(89, 41);
            this.BTN_SAVE.TabIndex = 0;
            this.BTN_SAVE.Text = "حفظ";
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("STV", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(496, 360);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "كل الاطباء";
            // 
            // gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView
            // 
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.AllowUserToAddRows = false;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.AutoGenerateColumns = false;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STV", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.ColumnHeadersHeight = 30;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSCHDUELDataGridViewTextBoxColumn,
            this.dOCTORNAMEDataGridViewTextBoxColumn,
            this.nAMEBDEPDataGridViewTextBoxColumn,
            this.dAYNAMEDataGridViewTextBoxColumn,
            this.fROMTIMEDataGridViewTextBoxColumn,
            this.tOTIMEDataGridViewTextBoxColumn,
            this.dOCTORCODEDataGridViewTextBoxColumn,
            this.dEPATMENTCODEDataGridViewTextBoxColumn});
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.DataSource = this.gET_SCHDUEL_DOCTOR_NAME_CODEBindingSource;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.EnableHeadersVisualStyles = false;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.GridColor = System.Drawing.Color.Black;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.Location = new System.Drawing.Point(2, 17);
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.MultiSelect = false;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.Name = "gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView";
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.RowHeadersVisible = false;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.RowHeadersWidth = 51;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.RowTemplate.Height = 24;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.Size = new System.Drawing.Size(492, 341);
            this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView.TabIndex = 0;
            // 
            // iDSCHDUELDataGridViewTextBoxColumn
            // 
            this.iDSCHDUELDataGridViewTextBoxColumn.DataPropertyName = "ID_SCHDUEL";
            this.iDSCHDUELDataGridViewTextBoxColumn.HeaderText = "ID_SCHDUEL";
            this.iDSCHDUELDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSCHDUELDataGridViewTextBoxColumn.Name = "iDSCHDUELDataGridViewTextBoxColumn";
            this.iDSCHDUELDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSCHDUELDataGridViewTextBoxColumn.Visible = false;
            this.iDSCHDUELDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOCTORNAMEDataGridViewTextBoxColumn
            // 
            this.dOCTORNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dOCTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NAME";
            this.dOCTORNAMEDataGridViewTextBoxColumn.HeaderText = "أسم الدكتور";
            this.dOCTORNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCTORNAMEDataGridViewTextBoxColumn.Name = "dOCTORNAMEDataGridViewTextBoxColumn";
            // 
            // nAMEBDEPDataGridViewTextBoxColumn
            // 
            this.nAMEBDEPDataGridViewTextBoxColumn.DataPropertyName = "NAME_B_DEP";
            this.nAMEBDEPDataGridViewTextBoxColumn.HeaderText = "القسم";
            this.nAMEBDEPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEBDEPDataGridViewTextBoxColumn.Name = "nAMEBDEPDataGridViewTextBoxColumn";
            this.nAMEBDEPDataGridViewTextBoxColumn.Width = 125;
            // 
            // dAYNAMEDataGridViewTextBoxColumn
            // 
            this.dAYNAMEDataGridViewTextBoxColumn.DataPropertyName = "DAY_NAME";
            this.dAYNAMEDataGridViewTextBoxColumn.HeaderText = "اليوم";
            this.dAYNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dAYNAMEDataGridViewTextBoxColumn.Name = "dAYNAMEDataGridViewTextBoxColumn";
            this.dAYNAMEDataGridViewTextBoxColumn.Width = 80;
            // 
            // fROMTIMEDataGridViewTextBoxColumn
            // 
            this.fROMTIMEDataGridViewTextBoxColumn.DataPropertyName = "FROM_TIME";
            this.fROMTIMEDataGridViewTextBoxColumn.HeaderText = "من الساعة";
            this.fROMTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fROMTIMEDataGridViewTextBoxColumn.Name = "fROMTIMEDataGridViewTextBoxColumn";
            // 
            // tOTIMEDataGridViewTextBoxColumn
            // 
            this.tOTIMEDataGridViewTextBoxColumn.DataPropertyName = "TO_TIME";
            this.tOTIMEDataGridViewTextBoxColumn.HeaderText = "الى الساعة";
            this.tOTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tOTIMEDataGridViewTextBoxColumn.Name = "tOTIMEDataGridViewTextBoxColumn";
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
            // dEPATMENTCODEDataGridViewTextBoxColumn
            // 
            this.dEPATMENTCODEDataGridViewTextBoxColumn.DataPropertyName = "DEPATMENT_CODE";
            this.dEPATMENTCODEDataGridViewTextBoxColumn.HeaderText = "DEPATMENT_CODE";
            this.dEPATMENTCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dEPATMENTCODEDataGridViewTextBoxColumn.Name = "dEPATMENTCODEDataGridViewTextBoxColumn";
            this.dEPATMENTCODEDataGridViewTextBoxColumn.Visible = false;
            this.dEPATMENTCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // gET_SCHDUEL_DOCTOR_NAME_CODEBindingSource
            // 
            this.gET_SCHDUEL_DOCTOR_NAME_CODEBindingSource.DataMember = "GET_SCHDUEL_DOCTOR_NAME_CODE";
            this.gET_SCHDUEL_DOCTOR_NAME_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
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
            // v_H_SUBDEPARTMENTTableAdapter
            // 
            this.v_H_SUBDEPARTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gET_SCHDUEL_DOCTOR_NAME_CODETableAdapter
            // 
            this.gET_SCHDUEL_DOCTOR_NAME_CODETableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 426);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 2);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(794, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 426);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(2, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(794, 2);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 428);
            this.panel6.TabIndex = 6;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel8, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.816711F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.21495F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.205607F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(796, 428);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(2, 35);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(792, 1);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(2, 407);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(792, 1);
            this.panel8.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.AutoScroll = true;
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.pic_exit);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(2, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(792, 29);
            this.panel9.TabIndex = 5;
            // 
            // pic_exit
            // 
            this.pic_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_exit.Image")));
            this.pic_exit.Location = new System.Drawing.Point(754, 0);
            this.pic_exit.Margin = new System.Windows.Forms.Padding(2);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(38, 29);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_exit.TabIndex = 2;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Doctors schedule";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FRM_DOCTOR_SCHEDULE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 428);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tableLayoutPanel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_DOCTOR_SCHEDULE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جدول الخفارات";
            this.Load += new System.EventHandler(this.FRM_DOCTOR_SCHEDULE_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_H_SUBDEPARTMENTBindingSource)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_SCHDUEL_DOCTOR_NAME_CODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource v_A_DOCTORBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter v_A_DOCTORTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox dOCTOR_NAMEComboBox;
        private System.Windows.Forms.BindingSource v_H_SUBDEPARTMENTBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_H_SUBDEPARTMENTTableAdapter v_H_SUBDEPARTMENTTableAdapter;
        private System.Windows.Forms.ComboBox nAME_B_DEPComboBox;
        private System.Windows.Forms.ComboBox COMB_DAY;
        private System.Windows.Forms.DateTimePicker DATE_FROM;
        private System.Windows.Forms.DateTimePicker DATE_TO;
        private System.Windows.Forms.DataGridView gET_SCHDUEL_DOCTOR_NAME_CODEDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource gET_SCHDUEL_DOCTOR_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_SCHDUEL_DOCTOR_NAME_CODETableAdapter gET_SCHDUEL_DOCTOR_NAME_CODETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSCHDUELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEBDEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAYNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fROMTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPATMENTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pic_exit;
        private System.Windows.Forms.Label label5;
    }
}