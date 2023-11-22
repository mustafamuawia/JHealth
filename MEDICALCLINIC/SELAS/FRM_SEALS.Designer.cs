namespace MEDICALCLINIC.SELAS
{
    partial class FRM_SEALS
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SEALS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TXT_TOTAL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_REMAIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_PAID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GROUPBOX = new System.Windows.Forms.GroupBox();
            this.dOCTOR_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.v_A_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.TXT_ID_BOOKING = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_NUM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LBL_NAMEPERSON = new System.Windows.Forms.ComboBox();
            this.v_A_PERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DATE_ORDER = new System.Windows.Forms.DateTimePicker();
            this.TXT_BARCODE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_ID_ORDER = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.BARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gET_PERSON_BY_DOCT_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.v_A_DOCTORTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter();
            this.gET_PERSON_BY_DOCT_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_PERSON_BY_DOCT_CODETableAdapter();
            this.p_GET_ITEM_TO_SALEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_ITEM_TO_SALETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_ITEM_TO_SALETableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.p_BOOK_CODE_BY_PERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_BOOK_CODE_BY_PERTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOOK_CODE_BY_PERTableAdapter();
            this.v_A_PERSONTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_PERSONTableAdapter();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.GROUPBOX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_PERSONBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PERSON_BY_DOCT_CODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_ITEM_TO_SALEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOOK_CODE_BY_PERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.ForeColor = System.Drawing.Color.Yellow;
            CLIENT_CODELabel.Location = new System.Drawing.Point(368, 96);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(119, 21);
            CLIENT_CODELabel.TabIndex = 57;
            CLIENT_CODELabel.Text = ":باركود المادة";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.ForeColor = System.Drawing.Color.Yellow;
            label2.Location = new System.Drawing.Point(699, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 21);
            label2.TabIndex = 57;
            label2.Text = ":رقم الفاتورة";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label1.ForeColor = System.Drawing.Color.Yellow;
            label1.Location = new System.Drawing.Point(699, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 21);
            label1.TabIndex = 58;
            label1.Text = ":تأريخ الفاتور";
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label6.ForeColor = System.Drawing.Color.Yellow;
            label6.Location = new System.Drawing.Point(368, 21);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(101, 21);
            label6.TabIndex = 63;
            label6.Text = ":أسم الدكتور";
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label7.ForeColor = System.Drawing.Color.Yellow;
            label7.Location = new System.Drawing.Point(368, 60);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 21);
            label7.TabIndex = 62;
            label7.Text = ":اسم المريض";
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label8.ForeColor = System.Drawing.Color.Yellow;
            label8.Location = new System.Drawing.Point(699, 60);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(102, 21);
            label8.TabIndex = 70;
            label8.Text = ":رقم الحجز";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.GROUPBOX);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 595);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.BTN_SEARCH);
            this.flowLayoutPanel1.Controls.Add(this.BTN_NEW);
            this.flowLayoutPanel1.Controls.Add(this.BTN_SAVE);
            this.flowLayoutPanel1.Controls.Add(this.BTN_EDIT);
            this.flowLayoutPanel1.Controls.Add(this.BTN_DELETE);
            this.flowLayoutPanel1.Controls.Add(this.BTN_EXIT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 542);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(816, 50);
            this.flowLayoutPanel1.TabIndex = 111;
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.Color.Black;
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SEARCH.Image")));
            this.BTN_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SEARCH.Location = new System.Drawing.Point(686, 3);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(127, 42);
            this.BTN_SEARCH.TabIndex = 98;
            this.BTN_SEARCH.Text = "بحث";
            this.BTN_SEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_NEW.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW.Image = ((System.Drawing.Image)(resources.GetObject("BTN_NEW.Image")));
            this.BTN_NEW.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_NEW.Location = new System.Drawing.Point(553, 3);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(127, 42);
            this.BTN_NEW.TabIndex = 99;
            this.BTN_NEW.Text = "جديد";
            this.BTN_NEW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NEW.UseVisualStyleBackColor = false;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_SAVE.ForeColor = System.Drawing.Color.White;
            this.BTN_SAVE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SAVE.Image")));
            this.BTN_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SAVE.Location = new System.Drawing.Point(420, 3);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(127, 42);
            this.BTN_SAVE.TabIndex = 100;
            this.BTN_SAVE.Text = "حفظ";
            this.BTN_SAVE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EDIT.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EDIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EDIT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EDIT.Image")));
            this.BTN_EDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EDIT.Location = new System.Drawing.Point(287, 3);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(127, 42);
            this.BTN_EDIT.TabIndex = 101;
            this.BTN_EDIT.Text = "تعديل";
            this.BTN_EDIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EDIT.UseVisualStyleBackColor = false;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_DELETE.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DELETE.Image")));
            this.BTN_DELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_DELETE.Location = new System.Drawing.Point(154, 3);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(127, 42);
            this.BTN_DELETE.TabIndex = 102;
            this.BTN_DELETE.Text = "حذف";
            this.BTN_DELETE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.BackColor = System.Drawing.Color.Red;
            this.BTN_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXIT.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EXIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EXIT.Image")));
            this.BTN_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EXIT.Location = new System.Drawing.Point(5, 3);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(143, 42);
            this.BTN_EXIT.TabIndex = 103;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TXT_TOTAL);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.TXT_REMAIN);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.TXT_PAID);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(3, 483);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(819, 49);
            this.groupBox6.TabIndex = 60;
            this.groupBox6.TabStop = false;
            // 
            // TXT_TOTAL
            // 
            this.TXT_TOTAL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TOTAL.ForeColor = System.Drawing.Color.Red;
            this.TXT_TOTAL.Location = new System.Drawing.Point(510, 17);
            this.TXT_TOTAL.Name = "TXT_TOTAL";
            this.TXT_TOTAL.ReadOnly = true;
            this.TXT_TOTAL.Size = new System.Drawing.Size(171, 30);
            this.TXT_TOTAL.TabIndex = 63;
            this.TXT_TOTAL.Text = "0.00";
            this.TXT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(199, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "الباقي";
            // 
            // TXT_REMAIN
            // 
            this.TXT_REMAIN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_REMAIN.ForeColor = System.Drawing.Color.Red;
            this.TXT_REMAIN.Location = new System.Drawing.Point(4, 17);
            this.TXT_REMAIN.Name = "TXT_REMAIN";
            this.TXT_REMAIN.ReadOnly = true;
            this.TXT_REMAIN.Size = new System.Drawing.Size(191, 30);
            this.TXT_REMAIN.TabIndex = 63;
            this.TXT_REMAIN.Text = "0.00";
            this.TXT_REMAIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(434, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 64;
            this.label4.Text = "الواصل";
            // 
            // TXT_PAID
            // 
            this.TXT_PAID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PAID.ForeColor = System.Drawing.Color.Blue;
            this.TXT_PAID.Location = new System.Drawing.Point(279, 17);
            this.TXT_PAID.Name = "TXT_PAID";
            this.TXT_PAID.Size = new System.Drawing.Size(153, 30);
            this.TXT_PAID.TabIndex = 63;
            this.TXT_PAID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PAID.TextChanged += new System.EventHandler(this.TXT_PAID_TextChanged);
            this.TXT_PAID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PAID_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(683, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 64;
            this.label3.Text = "المجموع الكلي";
            // 
            // GROUPBOX
            // 
            this.GROUPBOX.BackColor = System.Drawing.Color.SteelBlue;
            this.GROUPBOX.Controls.Add(this.dOCTOR_NAMEComboBox);
            this.GROUPBOX.Controls.Add(this.TXT_ID_BOOKING);
            this.GROUPBOX.Controls.Add(label8);
            this.GROUPBOX.Controls.Add(this.TXT_NUM);
            this.GROUPBOX.Controls.Add(this.LBL_NAMEPERSON);
            this.GROUPBOX.Controls.Add(label6);
            this.GROUPBOX.Controls.Add(label7);
            this.GROUPBOX.Controls.Add(this.DATE_ORDER);
            this.GROUPBOX.Controls.Add(this.TXT_BARCODE);
            this.GROUPBOX.Controls.Add(label1);
            this.GROUPBOX.Controls.Add(this.TXT_ID_ORDER);
            this.GROUPBOX.Controls.Add(label2);
            this.GROUPBOX.Controls.Add(CLIENT_CODELabel);
            this.GROUPBOX.Dock = System.Windows.Forms.DockStyle.Top;
            this.GROUPBOX.ForeColor = System.Drawing.Color.Yellow;
            this.GROUPBOX.Location = new System.Drawing.Point(3, 16);
            this.GROUPBOX.Name = "GROUPBOX";
            this.GROUPBOX.Size = new System.Drawing.Size(816, 142);
            this.GROUPBOX.TabIndex = 60;
            this.GROUPBOX.TabStop = false;
            // 
            // dOCTOR_NAMEComboBox
            // 
            this.dOCTOR_NAMEComboBox.DataSource = this.v_A_DOCTORBindingSource;
            this.dOCTOR_NAMEComboBox.DisplayMember = "DOCTOR_NAME";
            this.dOCTOR_NAMEComboBox.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold);
            this.dOCTOR_NAMEComboBox.FormattingEnabled = true;
            this.dOCTOR_NAMEComboBox.Location = new System.Drawing.Point(16, 15);
            this.dOCTOR_NAMEComboBox.Name = "dOCTOR_NAMEComboBox";
            this.dOCTOR_NAMEComboBox.Size = new System.Drawing.Size(343, 29);
            this.dOCTOR_NAMEComboBox.TabIndex = 71;
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
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TXT_ID_BOOKING
            // 
            this.TXT_ID_BOOKING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_ID_BOOKING.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // 
            // 
            this.TXT_ID_BOOKING.Border.Class = "TextBoxBorder";
            this.TXT_ID_BOOKING.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_ID_BOOKING.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_ID_BOOKING.ForeColor = System.Drawing.Color.Lime;
            this.TXT_ID_BOOKING.Location = new System.Drawing.Point(494, 53);
            this.TXT_ID_BOOKING.Name = "TXT_ID_BOOKING";
            this.TXT_ID_BOOKING.Size = new System.Drawing.Size(199, 35);
            this.TXT_ID_BOOKING.TabIndex = 69;
            this.TXT_ID_BOOKING.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_ID_BOOKING.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_ID_BOOKING.WatermarkColor = System.Drawing.Color.DimGray;
            // 
            // TXT_NUM
            // 
            this.TXT_NUM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NUM.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // 
            // 
            this.TXT_NUM.Border.Class = "TextBoxBorder";
            this.TXT_NUM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_NUM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_NUM.ForeColor = System.Drawing.Color.White;
            this.TXT_NUM.Location = new System.Drawing.Point(16, 91);
            this.TXT_NUM.Name = "TXT_NUM";
            this.TXT_NUM.Size = new System.Drawing.Size(59, 31);
            this.TXT_NUM.TabIndex = 68;
            this.TXT_NUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_NUM.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_NUM.WatermarkColor = System.Drawing.Color.Silver;
            this.TXT_NUM.WatermarkFont = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_NUM.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TXT_NUM.WatermarkText = "العدد";
            // 
            // LBL_NAMEPERSON
            // 
            this.LBL_NAMEPERSON.DataSource = this.v_A_PERSONBindingSource;
            this.LBL_NAMEPERSON.DisplayMember = "PERSON_NAME";
            this.LBL_NAMEPERSON.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBL_NAMEPERSON.FormattingEnabled = true;
            this.LBL_NAMEPERSON.Location = new System.Drawing.Point(16, 56);
            this.LBL_NAMEPERSON.Name = "LBL_NAMEPERSON";
            this.LBL_NAMEPERSON.Size = new System.Drawing.Size(343, 29);
            this.LBL_NAMEPERSON.TabIndex = 61;
            this.LBL_NAMEPERSON.ValueMember = "PERSON_CODE";
            // 
            // v_A_PERSONBindingSource
            // 
            this.v_A_PERSONBindingSource.DataMember = "V_A_PERSON";
            this.v_A_PERSONBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // DATE_ORDER
            // 
            this.DATE_ORDER.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_ORDER.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_ORDER.Location = new System.Drawing.Point(494, 91);
            this.DATE_ORDER.Name = "DATE_ORDER";
            this.DATE_ORDER.Size = new System.Drawing.Size(199, 30);
            this.DATE_ORDER.TabIndex = 59;
            // 
            // TXT_BARCODE
            // 
            this.TXT_BARCODE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_BARCODE.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // 
            // 
            this.TXT_BARCODE.Border.Class = "TextBoxBorder";
            this.TXT_BARCODE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_BARCODE.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_BARCODE.ForeColor = System.Drawing.Color.White;
            this.TXT_BARCODE.Location = new System.Drawing.Point(81, 91);
            this.TXT_BARCODE.Name = "TXT_BARCODE";
            this.TXT_BARCODE.Size = new System.Drawing.Size(278, 31);
            this.TXT_BARCODE.TabIndex = 53;
            this.TXT_BARCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_BARCODE.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_BARCODE.WatermarkColor = System.Drawing.Color.DarkGray;
            this.TXT_BARCODE.WatermarkFont = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_BARCODE.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TXT_BARCODE.WatermarkText = "أدخل الباركود";
            this.TXT_BARCODE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_BARCODE_KeyDown);
            this.TXT_BARCODE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_BARCODE_KeyPress);
            // 
            // TXT_ID_ORDER
            // 
            this.TXT_ID_ORDER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_ID_ORDER.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // 
            // 
            this.TXT_ID_ORDER.Border.Class = "TextBoxBorder";
            this.TXT_ID_ORDER.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_ID_ORDER.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_ID_ORDER.ForeColor = System.Drawing.Color.Lime;
            this.TXT_ID_ORDER.Location = new System.Drawing.Point(494, 15);
            this.TXT_ID_ORDER.Name = "TXT_ID_ORDER";
            this.TXT_ID_ORDER.Size = new System.Drawing.Size(199, 35);
            this.TXT_ID_ORDER.TabIndex = 0;
            this.TXT_ID_ORDER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_ID_ORDER.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_ID_ORDER.WatermarkColor = System.Drawing.Color.DimGray;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_order);
            this.groupBox4.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox4.Location = new System.Drawing.Point(3, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(816, 342);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            // 
            // dgv_order
            // 
            this.dgv_order.AllowUserToAddRows = false;
            this.dgv_order.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgv_order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_order.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BARCODE,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10,
            this.dgvcQuantity,
            this.Column3,
            this.dataGridViewButtonColumn4,
            this.Column4,
            this.Column1});
            this.dgv_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_order.EnableHeadersVisualStyles = false;
            this.dgv_order.Location = new System.Drawing.Point(3, 24);
            this.dgv_order.MultiSelect = false;
            this.dgv_order.Name = "dgv_order";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_order.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_order.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_order.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_order.RowTemplate.Height = 35;
            this.dgv_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_order.Size = new System.Drawing.Size(810, 315);
            this.dgv_order.TabIndex = 3;
            this.dgv_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellContentClick);
            this.dgv_order.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellValueChanged);
            // 
            // BARCODE
            // 
            this.BARCODE.HeaderText = "باركود";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BARCODE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BARCODE.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "أسم المادة";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "السعر";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcQuantity
            // 
            this.dgvcQuantity.HeaderText = "العدد";
            this.dgvcQuantity.Name = "dgvcQuantity";
            this.dgvcQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcQuantity.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "المجموع";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.HeaderText = "حذف";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.Text = "حذف";
            this.dataGridViewButtonColumn4.ToolTipText = "حذف";
            this.dataGridViewButtonColumn4.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn4.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID_PRUCHES";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID_STORE";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // gET_PERSON_BY_DOCT_CODEBindingSource
            // 
            this.gET_PERSON_BY_DOCT_CODEBindingSource.DataMember = "GET_PERSON_BY_DOCT_CODE";
            this.gET_PERSON_BY_DOCT_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
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
            // v_A_DOCTORTableAdapter
            // 
            this.v_A_DOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // gET_PERSON_BY_DOCT_CODETableAdapter
            // 
            this.gET_PERSON_BY_DOCT_CODETableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_ITEM_TO_SALEBindingSource
            // 
            this.p_GET_ITEM_TO_SALEBindingSource.DataMember = "P_GET_ITEM_TO_SALE";
            this.p_GET_ITEM_TO_SALEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_ITEM_TO_SALETableAdapter
            // 
            this.p_GET_ITEM_TO_SALETableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // p_BOOK_CODE_BY_PERBindingSource
            // 
            this.p_BOOK_CODE_BY_PERBindingSource.DataMember = "P_BOOK_CODE_BY_PER";
            this.p_BOOK_CODE_BY_PERBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_BOOK_CODE_BY_PERTableAdapter
            // 
            this.p_BOOK_CODE_BY_PERTableAdapter.ClearBeforeFill = true;
            // 
            // v_A_PERSONTableAdapter
            // 
            this.v_A_PERSONTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_SEALS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 595);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "FRM_SEALS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.FRM_PURCHERS_Load);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.GROUPBOX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_PERSONBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PERSON_BY_DOCT_CODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_ITEM_TO_SALEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOOK_CODE_BY_PERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        internal DevComponents.DotNetBar.Controls.TextBoxX TXT_BARCODE;
        private System.Windows.Forms.GroupBox GROUPBOX;
        private System.Windows.Forms.GroupBox groupBox4;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox LBL_NAMEPERSON;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource v_A_DOCTORBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter v_A_DOCTORTableAdapter;
        private System.Windows.Forms.BindingSource gET_PERSON_BY_DOCT_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_PERSON_BY_DOCT_CODETableAdapter gET_PERSON_BY_DOCT_CODETableAdapter;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.BindingSource p_GET_ITEM_TO_SALEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_ITEM_TO_SALETableAdapter p_GET_ITEM_TO_SALETableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal DevComponents.DotNetBar.Controls.TextBoxX TXT_NUM;
        private System.Windows.Forms.BindingSource p_BOOK_CODE_BY_PERBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOOK_CODE_BY_PERTableAdapter p_BOOK_CODE_BY_PERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.BindingSource v_A_PERSONBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_PERSONTableAdapter v_A_PERSONTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_EXIT;
        public System.Windows.Forms.DateTimePicker DATE_ORDER;
        public DevComponents.DotNetBar.Controls.TextBoxX TXT_ID_ORDER;
        public System.Windows.Forms.TextBox TXT_REMAIN;
        public System.Windows.Forms.TextBox TXT_TOTAL;
        public System.Windows.Forms.TextBox TXT_PAID;
        public System.Windows.Forms.DataGridView dgv_order;
        public DevComponents.DotNetBar.Controls.TextBoxX TXT_ID_BOOKING;
        public System.Windows.Forms.ComboBox dOCTOR_NAMEComboBox;
    }
}