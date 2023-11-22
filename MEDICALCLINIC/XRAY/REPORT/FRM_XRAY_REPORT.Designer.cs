
namespace MEDICALCLINIC.XRAY.REPORT
{
    partial class FRM_XRAY_REPORT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_XRAY_REPORT));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvalldata = new System.Windows.Forms.DataGridView();
            this.Column1 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.pERSONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALCOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPLEFLAGEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dELEVERFLAGDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dOCTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_GET_L_ALL_XRAY_REPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.iD_COST_CENTERLabel1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.p_GET_L_ALL_XRAY_REPORTTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_L_ALL_XRAY_REPORTTableAdapter();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalldata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_L_ALL_XRAY_REPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvalldata, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.783019F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.21698F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(962, 358);
            this.tableLayoutPanel2.TabIndex = 6;
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
            this.pERSONNAMEDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.sEXNAMEDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.tOTALCOSTDataGridViewTextBoxColumn,
            this.pATIENTCODEDataGridViewTextBoxColumn,
            this.cOMPLEFLAGEDataGridViewCheckBoxColumn,
            this.dELEVERFLAGDataGridViewCheckBoxColumn,
            this.dOCTORNAMEDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.iDRAYDataGridViewTextBoxColumn});
            this.dgvalldata.DataSource = this.p_GET_L_ALL_XRAY_REPORTBindingSource;
            this.dgvalldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvalldata.EnableHeadersVisualStyles = false;
            this.dgvalldata.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvalldata.Location = new System.Drawing.Point(3, 30);
            this.dgvalldata.MultiSelect = false;
            this.dgvalldata.Name = "dgvalldata";
            this.dgvalldata.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvalldata.RowHeadersVisible = false;
            this.dgvalldata.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvalldata.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvalldata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvalldata.Size = new System.Drawing.Size(956, 325);
            this.dgvalldata.TabIndex = 0;
            this.dgvalldata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalldata_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "التفاصيل";
            this.Column1.Name = "Column1";
            this.Column1.Text = "التفاصيل";
            this.Column1.ToolTipText = "التفاصيل";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 70;
            // 
            // pERSONNAMEDataGridViewTextBoxColumn
            // 
            this.pERSONNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pERSONNAMEDataGridViewTextBoxColumn.DataPropertyName = "PERSON_NAME";
            this.pERSONNAMEDataGridViewTextBoxColumn.HeaderText = "اسم المريض";
            this.pERSONNAMEDataGridViewTextBoxColumn.Name = "pERSONNAMEDataGridViewTextBoxColumn";
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "العمر";
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            // 
            // sEXNAMEDataGridViewTextBoxColumn
            // 
            this.sEXNAMEDataGridViewTextBoxColumn.DataPropertyName = "SEX_NAME";
            this.sEXNAMEDataGridViewTextBoxColumn.HeaderText = "الجنس";
            this.sEXNAMEDataGridViewTextBoxColumn.Name = "sEXNAMEDataGridViewTextBoxColumn";
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "الهاتف";
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            // 
            // tOTALCOSTDataGridViewTextBoxColumn
            // 
            this.tOTALCOSTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_COST";
            this.tOTALCOSTDataGridViewTextBoxColumn.HeaderText = "السعر الكلي";
            this.tOTALCOSTDataGridViewTextBoxColumn.Name = "tOTALCOSTDataGridViewTextBoxColumn";
            // 
            // pATIENTCODEDataGridViewTextBoxColumn
            // 
            this.pATIENTCODEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_CODE";
            this.pATIENTCODEDataGridViewTextBoxColumn.HeaderText = "PATIENT_CODE";
            this.pATIENTCODEDataGridViewTextBoxColumn.Name = "pATIENTCODEDataGridViewTextBoxColumn";
            this.pATIENTCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cOMPLEFLAGEDataGridViewCheckBoxColumn
            // 
            this.cOMPLEFLAGEDataGridViewCheckBoxColumn.DataPropertyName = "COMPLE_FLAGE";
            this.cOMPLEFLAGEDataGridViewCheckBoxColumn.HeaderText = "مكتملة؟";
            this.cOMPLEFLAGEDataGridViewCheckBoxColumn.Name = "cOMPLEFLAGEDataGridViewCheckBoxColumn";
            // 
            // dELEVERFLAGDataGridViewCheckBoxColumn
            // 
            this.dELEVERFLAGDataGridViewCheckBoxColumn.DataPropertyName = "DELEVER_FLAG";
            this.dELEVERFLAGDataGridViewCheckBoxColumn.HeaderText = "DELEVER_FLAG";
            this.dELEVERFLAGDataGridViewCheckBoxColumn.Name = "dELEVERFLAGDataGridViewCheckBoxColumn";
            this.dELEVERFLAGDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dOCTORNAMEDataGridViewTextBoxColumn
            // 
            this.dOCTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NAME";
            this.dOCTORNAMEDataGridViewTextBoxColumn.HeaderText = "الطبيب";
            this.dOCTORNAMEDataGridViewTextBoxColumn.Name = "dOCTORNAMEDataGridViewTextBoxColumn";
            this.dOCTORNAMEDataGridViewTextBoxColumn.Width = 120;
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USER_NAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "الموظف";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // iDRAYDataGridViewTextBoxColumn
            // 
            this.iDRAYDataGridViewTextBoxColumn.DataPropertyName = "ID_RAY";
            this.iDRAYDataGridViewTextBoxColumn.HeaderText = "ID_RAY";
            this.iDRAYDataGridViewTextBoxColumn.Name = "iDRAYDataGridViewTextBoxColumn";
            this.iDRAYDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRAYDataGridViewTextBoxColumn.Visible = false;
            // 
            // p_GET_L_ALL_XRAY_REPORTBindingSource
            // 
            this.p_GET_L_ALL_XRAY_REPORTBindingSource.DataMember = "P_GET_L_ALL_XRAY_REPORT";
            this.p_GET_L_ALL_XRAY_REPORTBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.73227F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.64073F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.41512F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.024096F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.67963F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker1, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker2, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.BTN_SEARCH, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(956, 21);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("STV", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(905, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 100;
            this.label4.Text = "من";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("STV", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(660, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 101;
            this.label8.Text = "الى";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(717, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 27);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(494, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 27);
            this.dateTimePicker2.TabIndex = 103;
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
            this.BTN_SEARCH.Location = new System.Drawing.Point(393, 3);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(95, 15);
            this.BTN_SEARCH.TabIndex = 99;
            this.BTN_SEARCH.Text = "بحث";
            this.BTN_SEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
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
            this.label1.Text = "تقرير الاشعة اليومي";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 394);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(962, 41);
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
            this.BTN_PRINT.Size = new System.Drawing.Size(114, 15);
            this.BTN_PRINT.TabIndex = 110;
            this.BTN_PRINT.Text = "السندات";
            this.BTN_PRINT.UseVisualStyleBackColor = false;
            this.BTN_PRINT.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(795, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "المجموع الكلي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_TOTAL
            // 
            this.LBL_TOTAL.AutoSize = true;
            this.LBL_TOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_TOTAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_TOTAL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TOTAL.ForeColor = System.Drawing.Color.Blue;
            this.LBL_TOTAL.Location = new System.Drawing.Point(795, 21);
            this.LBL_TOTAL.Name = "LBL_TOTAL";
            this.LBL_TOTAL.Size = new System.Drawing.Size(164, 20);
            this.LBL_TOTAL.TabIndex = 5;
            this.LBL_TOTAL.Text = "0.00";
            this.LBL_TOTAL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(627, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
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
            this.LBL_PAID.Location = new System.Drawing.Point(627, 21);
            this.LBL_PAID.Name = "LBL_PAID";
            this.LBL_PAID.Size = new System.Drawing.Size(162, 20);
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
            this.label3.Location = new System.Drawing.Point(459, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 21);
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
            this.LBL_REMAIN.Location = new System.Drawing.Point(459, 21);
            this.LBL_REMAIN.Name = "LBL_REMAIN";
            this.LBL_REMAIN.Size = new System.Drawing.Size(162, 20);
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
            this.label6.Location = new System.Drawing.Point(123, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 21);
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
            this.label7.Location = new System.Drawing.Point(291, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "الواصل الان";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // TXT_PAY_NOW
            // 
            this.TXT_PAY_NOW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_PAY_NOW.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PAY_NOW.Location = new System.Drawing.Point(291, 24);
            this.TXT_PAY_NOW.Name = "TXT_PAY_NOW";
            this.TXT_PAY_NOW.Size = new System.Drawing.Size(162, 30);
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
            this.LBL_REMAIN_AFT.Location = new System.Drawing.Point(123, 21);
            this.LBL_REMAIN_AFT.Name = "LBL_REMAIN_AFT";
            this.LBL_REMAIN_AFT.Size = new System.Drawing.Size(162, 20);
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
            this.BTN_SAVE.Location = new System.Drawing.Point(3, 24);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(114, 14);
            this.BTN_SAVE.TabIndex = 109;
            this.BTN_SAVE.Text = "...";
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Visible = false;
            // 
            // iD_COST_CENTERLabel1
            // 
            this.iD_COST_CENTERLabel1.Location = new System.Drawing.Point(123, -3);
            this.iD_COST_CENTERLabel1.Name = "iD_COST_CENTERLabel1";
            this.iD_COST_CENTERLabel1.Size = new System.Drawing.Size(77, 21);
            this.iD_COST_CENTERLabel1.TabIndex = 3;
            this.iD_COST_CENTERLabel1.Text = "label9";
            this.iD_COST_CENTERLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 2);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 436);
            this.panel4.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 436);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 2);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(966, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 438);
            this.panel1.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 21);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(964, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(2, 389);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(964, 1);
            this.panel6.TabIndex = 4;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.435484F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.076701F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.076701F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15603F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 438);
            this.tableLayoutPanel1.TabIndex = 20;
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
            this.panel7.Size = new System.Drawing.Size(964, 15);
            this.panel7.TabIndex = 5;
            // 
            // pic_exit
            // 
            this.pic_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_exit.Image")));
            this.pic_exit.Location = new System.Drawing.Point(909, 0);
            this.pic_exit.Margin = new System.Windows.Forms.Padding(2);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(38, 18);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_exit.TabIndex = 2;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
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
            // p_GET_L_ALL_XRAY_REPORTTableAdapter
            // 
            this.p_GET_L_ALL_XRAY_REPORTTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_XRAY_REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 438);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_XRAY_REPORT";
            this.Text = "تقربر الاشعة اليومي";
            this.Load += new System.EventHandler(this.FRM_XRAY_REPORT_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvalldata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_L_ALL_XRAY_REPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvalldata;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BTN_SEARCH;
        public System.Windows.Forms.PictureBox pic_exit;
        public System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label iD_COST_CENTERLabel1;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel6;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.BindingSource p_GET_L_ALL_XRAY_REPORTBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_L_ALL_XRAY_REPORTTableAdapter p_GET_L_ALL_XRAY_REPORTTableAdapter;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALCOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cOMPLEFLAGEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dELEVERFLAGDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRAYDataGridViewTextBoxColumn;
    }
}