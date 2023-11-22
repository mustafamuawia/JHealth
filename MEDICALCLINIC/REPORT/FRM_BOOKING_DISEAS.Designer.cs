namespace MEDICALCLINIC.REPORT
{
    partial class FRM_BOOKING_DISEAS
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BOOKING_DISEAS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dISEASE_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.v_GET_A_DISEASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.E_DATE = new System.Windows.Forms.DateTimePicker();
            this.dOCTOR_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.v_A_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.F_DATE = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.v_A_PERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_BOX_ALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LBL_FIANL_NUMB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_NO_PAID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_PAID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_T_CREDIT = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.p_BOX_ALLTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.p_GET_BOOKING_BY_DOC_RPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_BOOKING_BY_DOC_RPTTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DOC_RPTTableAdapter();
            this.p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter();
            this.v_A_DOCTORTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter();
            this.v_GET_A_DISEASTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_A_DISEASTableAdapter();
            this.p_GET_BOOKING_BY_DISEASEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_BOOKING_BY_DISEASETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DISEASETableAdapter();
            this.p_GET_BOOKING_BY_DISEASE_TOW_DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_BOOKING_BY_DISEASE_TOW_DTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DISEASE_TOW_DTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.رقمالحجزDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.أسمالمريضDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الجنسDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.العمرDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نوعالحجزDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نوعالمرضDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.أسمالعلاجDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الوصفDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الحالةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الملاحظاتDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.التأريخDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الوقتDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الكشفيةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.حالةDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.v_A_PERSONTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_PERSONTableAdapter();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_GET_A_DISEASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_PERSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DOC_RPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DISEASEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DISEASE_TOW_DBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.AutoSize = true;
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.ForeColor = System.Drawing.Color.Black;
            CLIENT_CODELabel.Location = new System.Drawing.Point(489, 82);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(83, 18);
            CLIENT_CODELabel.TabIndex = 57;
            CLIENT_CODELabel.Text = "أسم الدكتور:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(489, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 18);
            label2.TabIndex = 57;
            label2.Text = "من تأريخ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(297, 46);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 18);
            label3.TabIndex = 57;
            label3.Text = "الى تأريخ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(489, 114);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 18);
            label5.TabIndex = 65;
            label5.Text = "أسم المرض:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(12, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 143);
            this.button4.TabIndex = 61;
            this.button4.Text = "خروج";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(label5);
            this.groupBox4.Controls.Add(this.dISEASE_NAMEComboBox);
            this.groupBox4.Controls.Add(this.E_DATE);
            this.groupBox4.Controls.Add(this.dOCTOR_NAMEComboBox);
            this.groupBox4.Controls.Add(label3);
            this.groupBox4.Controls.Add(this.F_DATE);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(label2);
            this.groupBox4.Controls.Add(CLIENT_CODELabel);
            this.groupBox4.Font = new System.Drawing.Font("STV", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(664, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(585, 143);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "حسب اسم المرض";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(91, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 53);
            this.button3.TabIndex = 59;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button7.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(11, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 53);
            this.button7.TabIndex = 62;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // dISEASE_NAMEComboBox
            // 
            this.dISEASE_NAMEComboBox.DataSource = this.v_GET_A_DISEASBindingSource;
            this.dISEASE_NAMEComboBox.DisplayMember = "DISEASE_NAME";
            this.dISEASE_NAMEComboBox.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dISEASE_NAMEComboBox.FormattingEnabled = true;
            this.dISEASE_NAMEComboBox.Location = new System.Drawing.Point(171, 106);
            this.dISEASE_NAMEComboBox.Name = "dISEASE_NAMEComboBox";
            this.dISEASE_NAMEComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dISEASE_NAMEComboBox.Size = new System.Drawing.Size(314, 26);
            this.dISEASE_NAMEComboBox.TabIndex = 64;
            this.dISEASE_NAMEComboBox.ValueMember = "DISEASE_CODE";
            // 
            // v_GET_A_DISEASBindingSource
            // 
            this.v_GET_A_DISEASBindingSource.DataMember = "V_GET_A_DISEAS";
            this.v_GET_A_DISEASBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // E_DATE
            // 
            this.E_DATE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.E_DATE.Location = new System.Drawing.Point(171, 41);
            this.E_DATE.Name = "E_DATE";
            this.E_DATE.Size = new System.Drawing.Size(123, 27);
            this.E_DATE.TabIndex = 60;
            // 
            // dOCTOR_NAMEComboBox
            // 
            this.dOCTOR_NAMEComboBox.DataSource = this.v_A_DOCTORBindingSource;
            this.dOCTOR_NAMEComboBox.DisplayMember = "DOCTOR_NAME";
            this.dOCTOR_NAMEComboBox.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dOCTOR_NAMEComboBox.FormattingEnabled = true;
            this.dOCTOR_NAMEComboBox.Location = new System.Drawing.Point(171, 74);
            this.dOCTOR_NAMEComboBox.Name = "dOCTOR_NAMEComboBox";
            this.dOCTOR_NAMEComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dOCTOR_NAMEComboBox.Size = new System.Drawing.Size(314, 26);
            this.dOCTOR_NAMEComboBox.TabIndex = 63;
            this.dOCTOR_NAMEComboBox.ValueMember = "USER_CODE";
            this.dOCTOR_NAMEComboBox.SelectedIndexChanged += new System.EventHandler(this.dOCTOR_NAMEComboBox_SelectedIndexChanged);
            // 
            // v_A_DOCTORBindingSource
            // 
            this.v_A_DOCTORBindingSource.DataMember = "V_A_DOCTOR";
            this.v_A_DOCTORBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // F_DATE
            // 
            this.F_DATE.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.F_DATE.Location = new System.Drawing.Point(362, 41);
            this.F_DATE.Name = "F_DATE";
            this.F_DATE.Size = new System.Drawing.Size(123, 27);
            this.F_DATE.TabIndex = 60;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(11, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 53);
            this.button5.TabIndex = 62;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(91, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 53);
            this.button1.TabIndex = 59;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // v_A_PERSONBindingSource
            // 
            this.v_A_PERSONBindingSource.DataMember = "V_A_PERSON";
            this.v_A_PERSONBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_BOX_ALLBindingSource
            // 
            this.p_BOX_ALLBindingSource.DataMember = "P_BOX_ALL";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DimGray;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.LBL_FIANL_NUMB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.LBL_NO_PAID);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.LBL_PAID);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.LBL_T_CREDIT);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 697);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1268, 52);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(224, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 33);
            this.label7.TabIndex = 66;
            this.label7.Text = ":العدد الكلي";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_FIANL_NUMB
            // 
            this.LBL_FIANL_NUMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_FIANL_NUMB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_FIANL_NUMB.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_FIANL_NUMB.ForeColor = System.Drawing.Color.White;
            this.LBL_FIANL_NUMB.Location = new System.Drawing.Point(122, 11);
            this.LBL_FIANL_NUMB.Name = "LBL_FIANL_NUMB";
            this.LBL_FIANL_NUMB.Size = new System.Drawing.Size(96, 33);
            this.LBL_FIANL_NUMB.TabIndex = 67;
            this.LBL_FIANL_NUMB.Text = "0";
            this.LBL_FIANL_NUMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(467, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 33);
            this.label6.TabIndex = 64;
            this.label6.Text = ":غير مدفوع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_NO_PAID
            // 
            this.LBL_NO_PAID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_NO_PAID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_NO_PAID.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NO_PAID.ForeColor = System.Drawing.Color.White;
            this.LBL_NO_PAID.Location = new System.Drawing.Point(365, 11);
            this.LBL_NO_PAID.Name = "LBL_NO_PAID";
            this.LBL_NO_PAID.Size = new System.Drawing.Size(96, 33);
            this.LBL_NO_PAID.TabIndex = 65;
            this.LBL_NO_PAID.Text = "0";
            this.LBL_NO_PAID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(721, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 62;
            this.label1.Text = ":المدفوع ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_PAID
            // 
            this.LBL_PAID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_PAID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_PAID.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PAID.ForeColor = System.Drawing.Color.White;
            this.LBL_PAID.Location = new System.Drawing.Point(619, 11);
            this.LBL_PAID.Name = "LBL_PAID";
            this.LBL_PAID.Size = new System.Drawing.Size(96, 33);
            this.LBL_PAID.TabIndex = 63;
            this.LBL_PAID.Text = "0";
            this.LBL_PAID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("STV", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(1075, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 33);
            this.label4.TabIndex = 61;
            this.label4.Text = ":مجموع الكشفية";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_T_CREDIT
            // 
            this.LBL_T_CREDIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_T_CREDIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_T_CREDIT.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_T_CREDIT.ForeColor = System.Drawing.Color.White;
            this.LBL_T_CREDIT.Location = new System.Drawing.Point(862, 11);
            this.LBL_T_CREDIT.Name = "LBL_T_CREDIT";
            this.LBL_T_CREDIT.Size = new System.Drawing.Size(207, 33);
            this.LBL_T_CREDIT.TabIndex = 61;
            this.LBL_T_CREDIT.Text = "0.00";
            this.LBL_T_CREDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // p_BOX_ALLTableAdapter
            // 
            this.p_BOX_ALLTableAdapter.ClearBeforeFill = true;
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
            // p_GET_BOOKING_BY_DOC_RPTBindingSource
            // 
            this.p_GET_BOOKING_BY_DOC_RPTBindingSource.DataMember = "P_GET_BOOKING_BY_DOC_RPT";
            this.p_GET_BOOKING_BY_DOC_RPTBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_BOOKING_BY_DOC_RPTTableAdapter
            // 
            this.p_GET_BOOKING_BY_DOC_RPTTableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource
            // 
            this.p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource.DataMember = "P_GET_BOOKING_BY_DOC_TOW_D_RPT";
            this.p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter
            // 
            this.p_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter.ClearBeforeFill = true;
            // 
            // v_A_DOCTORTableAdapter
            // 
            this.v_A_DOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // v_GET_A_DISEASTableAdapter
            // 
            this.v_GET_A_DISEASTableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_BOOKING_BY_DISEASEBindingSource
            // 
            this.p_GET_BOOKING_BY_DISEASEBindingSource.DataMember = "P_GET_BOOKING_BY_DISEASE";
            this.p_GET_BOOKING_BY_DISEASEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_BOOKING_BY_DISEASETableAdapter
            // 
            this.p_GET_BOOKING_BY_DISEASETableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_BOOKING_BY_DISEASE_TOW_DBindingSource
            // 
            this.p_GET_BOOKING_BY_DISEASE_TOW_DBindingSource.DataMember = "P_GET_BOOKING_BY_DISEASE_TOW_D";
            this.p_GET_BOOKING_BY_DISEASE_TOW_DBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_BOOKING_BY_DISEASE_TOW_DTableAdapter
            // 
            this.p_GET_BOOKING_BY_DISEASE_TOW_DTableAdapter.ClearBeforeFill = true;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.رقمالحجزDataGridViewTextBoxColumn,
            this.أسمالمريضDataGridViewTextBoxColumn,
            this.الجنسDataGridViewTextBoxColumn,
            this.العمرDataGridViewTextBoxColumn,
            this.نوعالحجزDataGridViewTextBoxColumn,
            this.نوعالمرضDataGridViewTextBoxColumn,
            this.أسمالعلاجDataGridViewTextBoxColumn,
            this.الوصفDataGridViewTextBoxColumn,
            this.الحالةDataGridViewTextBoxColumn,
            this.الملاحظاتDataGridViewTextBoxColumn,
            this.التأريخDataGridViewTextBoxColumn,
            this.الوقتDataGridViewTextBoxColumn,
            this.الكشفيةDataGridViewTextBoxColumn,
            this.حالةDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.p_GET_BOOKING_BY_DISEASEBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 24);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1262, 505);
            this.dataGridView2.TabIndex = 2;
            // 
            // رقمالحجزDataGridViewTextBoxColumn
            // 
            this.رقمالحجزDataGridViewTextBoxColumn.DataPropertyName = "رقم الحجز";
            this.رقمالحجزDataGridViewTextBoxColumn.HeaderText = "رقم الحجز";
            this.رقمالحجزDataGridViewTextBoxColumn.Name = "رقمالحجزDataGridViewTextBoxColumn";
            this.رقمالحجزDataGridViewTextBoxColumn.ReadOnly = true;
            this.رقمالحجزDataGridViewTextBoxColumn.Width = 120;
            // 
            // أسمالمريضDataGridViewTextBoxColumn
            // 
            this.أسمالمريضDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.أسمالمريضDataGridViewTextBoxColumn.DataPropertyName = "أسم المريض";
            this.أسمالمريضDataGridViewTextBoxColumn.HeaderText = "أسم المريض";
            this.أسمالمريضDataGridViewTextBoxColumn.Name = "أسمالمريضDataGridViewTextBoxColumn";
            // 
            // الجنسDataGridViewTextBoxColumn
            // 
            this.الجنسDataGridViewTextBoxColumn.DataPropertyName = "الجنس";
            this.الجنسDataGridViewTextBoxColumn.HeaderText = "الجنس";
            this.الجنسDataGridViewTextBoxColumn.Name = "الجنسDataGridViewTextBoxColumn";
            // 
            // العمرDataGridViewTextBoxColumn
            // 
            this.العمرDataGridViewTextBoxColumn.DataPropertyName = "العمر";
            this.العمرDataGridViewTextBoxColumn.HeaderText = "العمر";
            this.العمرDataGridViewTextBoxColumn.Name = "العمرDataGridViewTextBoxColumn";
            // 
            // نوعالحجزDataGridViewTextBoxColumn
            // 
            this.نوعالحجزDataGridViewTextBoxColumn.DataPropertyName = "نوع الحجز";
            this.نوعالحجزDataGridViewTextBoxColumn.HeaderText = "نوع الحجز";
            this.نوعالحجزDataGridViewTextBoxColumn.Name = "نوعالحجزDataGridViewTextBoxColumn";
            this.نوعالحجزDataGridViewTextBoxColumn.Width = 250;
            // 
            // نوعالمرضDataGridViewTextBoxColumn
            // 
            this.نوعالمرضDataGridViewTextBoxColumn.DataPropertyName = "نوع المرض";
            this.نوعالمرضDataGridViewTextBoxColumn.HeaderText = "نوع المرض";
            this.نوعالمرضDataGridViewTextBoxColumn.Name = "نوعالمرضDataGridViewTextBoxColumn";
            this.نوعالمرضDataGridViewTextBoxColumn.Width = 250;
            // 
            // أسمالعلاجDataGridViewTextBoxColumn
            // 
            this.أسمالعلاجDataGridViewTextBoxColumn.DataPropertyName = "أسم العلاج";
            this.أسمالعلاجDataGridViewTextBoxColumn.HeaderText = "أسم العلاج";
            this.أسمالعلاجDataGridViewTextBoxColumn.Name = "أسمالعلاجDataGridViewTextBoxColumn";
            this.أسمالعلاجDataGridViewTextBoxColumn.Visible = false;
            // 
            // الوصفDataGridViewTextBoxColumn
            // 
            this.الوصفDataGridViewTextBoxColumn.DataPropertyName = "الوصف";
            this.الوصفDataGridViewTextBoxColumn.HeaderText = "الوصف";
            this.الوصفDataGridViewTextBoxColumn.Name = "الوصفDataGridViewTextBoxColumn";
            this.الوصفDataGridViewTextBoxColumn.Visible = false;
            // 
            // الحالةDataGridViewTextBoxColumn
            // 
            this.الحالةDataGridViewTextBoxColumn.DataPropertyName = "الحالة";
            this.الحالةDataGridViewTextBoxColumn.HeaderText = "الحالة";
            this.الحالةDataGridViewTextBoxColumn.Name = "الحالةDataGridViewTextBoxColumn";
            this.الحالةDataGridViewTextBoxColumn.Visible = false;
            // 
            // الملاحظاتDataGridViewTextBoxColumn
            // 
            this.الملاحظاتDataGridViewTextBoxColumn.DataPropertyName = "الملاحظات";
            this.الملاحظاتDataGridViewTextBoxColumn.HeaderText = "الملاحظات";
            this.الملاحظاتDataGridViewTextBoxColumn.Name = "الملاحظاتDataGridViewTextBoxColumn";
            this.الملاحظاتDataGridViewTextBoxColumn.Visible = false;
            // 
            // التأريخDataGridViewTextBoxColumn
            // 
            this.التأريخDataGridViewTextBoxColumn.DataPropertyName = "التأريخ";
            this.التأريخDataGridViewTextBoxColumn.HeaderText = "التأريخ";
            this.التأريخDataGridViewTextBoxColumn.Name = "التأريخDataGridViewTextBoxColumn";
            this.التأريخDataGridViewTextBoxColumn.Width = 160;
            // 
            // الوقتDataGridViewTextBoxColumn
            // 
            this.الوقتDataGridViewTextBoxColumn.DataPropertyName = "الوقت";
            this.الوقتDataGridViewTextBoxColumn.HeaderText = "الوقت";
            this.الوقتDataGridViewTextBoxColumn.Name = "الوقتDataGridViewTextBoxColumn";
            this.الوقتDataGridViewTextBoxColumn.Visible = false;
            // 
            // الكشفيةDataGridViewTextBoxColumn
            // 
            this.الكشفيةDataGridViewTextBoxColumn.DataPropertyName = "الكشفية";
            this.الكشفيةDataGridViewTextBoxColumn.HeaderText = "الكشفية";
            this.الكشفيةDataGridViewTextBoxColumn.Name = "الكشفيةDataGridViewTextBoxColumn";
            this.الكشفيةDataGridViewTextBoxColumn.Visible = false;
            // 
            // حالةDataGridViewCheckBoxColumn
            // 
            this.حالةDataGridViewCheckBoxColumn.DataPropertyName = "حالة";
            this.حالةDataGridViewCheckBoxColumn.HeaderText = "حالة";
            this.حالةDataGridViewCheckBoxColumn.Name = "حالةDataGridViewCheckBoxColumn";
            this.حالةDataGridViewCheckBoxColumn.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(0, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1268, 532);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // v_A_PERSONTableAdapter
            // 
            this.v_A_PERSONTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_BOOKING_DISEAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1268, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FRM_BOOKING_DISEAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير الامراض";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_SEARCH_SANAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_GET_A_DISEASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_PERSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DOC_RPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DISEASEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DISEASE_TOW_DBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource p_BOX_ALLBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter p_BOX_ALLTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker E_DATE;
        private System.Windows.Forms.DateTimePicker F_DATE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_T_CREDIT;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource p_GET_BOOKING_BY_DOC_RPTBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DOC_RPTTableAdapter p_GET_BOOKING_BY_DOC_RPTTableAdapter;
        private System.Windows.Forms.BindingSource p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter p_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter;
        private System.Windows.Forms.BindingSource v_A_DOCTORBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter v_A_DOCTORTableAdapter;
        private System.Windows.Forms.ComboBox dOCTOR_NAMEComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_NO_PAID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_PAID;
        private System.Windows.Forms.BindingSource v_GET_A_DISEASBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_A_DISEASTableAdapter v_GET_A_DISEASTableAdapter;
        private System.Windows.Forms.ComboBox dISEASE_NAMEComboBox;
        private System.Windows.Forms.BindingSource p_GET_BOOKING_BY_DISEASEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DISEASETableAdapter p_GET_BOOKING_BY_DISEASETableAdapter;
        private System.Windows.Forms.BindingSource p_GET_BOOKING_BY_DISEASE_TOW_DBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DISEASE_TOW_DTableAdapter p_GET_BOOKING_BY_DISEASE_TOW_DTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource v_A_PERSONBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_PERSONTableAdapter v_A_PERSONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn رقمالحجزDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn أسمالمريضDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الجنسDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn العمرDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn نوعالحجزDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn نوعالمرضDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn أسمالعلاجDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الوصفDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الحالةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الملاحظاتDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn التأريخDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الوقتDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الكشفيةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn حالةDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBL_FIANL_NUMB;
    }
}