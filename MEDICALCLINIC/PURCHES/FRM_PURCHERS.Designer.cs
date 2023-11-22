namespace MEDICALCLINIC.PURCHES
{
    partial class FRM_PURCHERS
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
            System.Windows.Forms.Label CLIENT_NAME_ARLabel;
            System.Windows.Forms.Label CLIENT_CODELabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PURCHERS));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TXT_PAY = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_PAID = new System.Windows.Forms.TextBox();
            this.TXT_REMAIN = new System.Windows.Forms.TextBox();
            this.TXT_TOTAL = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPrices = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPricep = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Qnty = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dOCTOR_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.v_A_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.cLIENT_NAME_ARComboBox = new System.Windows.Forms.ComboBox();
            this.p_GET_A_SUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DATE_PURCHER = new System.Windows.Forms.DateTimePicker();
            this.TXT_BARCODE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_ID_PURCHES = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.p_GET_A_ITEMS_BARCODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_A_ITEMS_BARCODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_ITEMS_BARCODETableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.p_GET_A_SUPPLIERSTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_SUPPLIERSTableAdapter();
            this.v_A_DOCTORTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            CLIENT_NAME_ARLabel = new System.Windows.Forms.Label();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_SUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_ITEMS_BARCODEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_NAME_ARLabel
            // 
            CLIENT_NAME_ARLabel.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_NAME_ARLabel.ForeColor = System.Drawing.Color.White;
            CLIENT_NAME_ARLabel.Location = new System.Drawing.Point(400, 44);
            CLIENT_NAME_ARLabel.Name = "CLIENT_NAME_ARLabel";
            CLIENT_NAME_ARLabel.Size = new System.Drawing.Size(93, 28);
            CLIENT_NAME_ARLabel.TabIndex = 58;
            CLIENT_NAME_ARLabel.Text = "اسم العميل";
            CLIENT_NAME_ARLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.ForeColor = System.Drawing.Color.White;
            CLIENT_CODELabel.Location = new System.Drawing.Point(400, 107);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(107, 32);
            CLIENT_CODELabel.TabIndex = 57;
            CLIENT_CODELabel.Text = "باركود المادة";
            CLIENT_CODELabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(706, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 18);
            label2.TabIndex = 57;
            label2.Text = "رقم الفاتورة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(706, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 18);
            label1.TabIndex = 58;
            label1.Text = "تأريخ الفاتور";
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(400, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 28);
            label6.TabIndex = 62;
            label6.Text = "اسم الدكتور";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXT_PAID);
            this.groupBox2.Controls.Add(this.TXT_REMAIN);
            this.groupBox2.Controls.Add(this.TXT_TOTAL);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 583);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.TXT_PAY);
            this.groupBox4.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox4.Location = new System.Drawing.Point(0, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(829, 319);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(823, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "باركود";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 175;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "أسم المادة";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "العدد";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "سعر الشراء";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "المجموع ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "سعر البيع";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "حذف";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Text = "حذف";
            this.Column6.ToolTipText = "حذف";
            this.Column6.UseColumnTextForButtonValue = true;
            this.Column6.Width = 80;
            // 
            // TXT_PAY
            // 
            this.TXT_PAY.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PAY.Location = new System.Drawing.Point(200, 180);
            this.TXT_PAY.Name = "TXT_PAY";
            this.TXT_PAY.Size = new System.Drawing.Size(125, 30);
            this.TXT_PAY.TabIndex = 63;
            this.TXT_PAY.TextChanged += new System.EventHandler(this.TXT_PAY_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.BTN_SEARCH);
            this.flowLayoutPanel1.Controls.Add(this.BTN_NEW);
            this.flowLayoutPanel1.Controls.Add(this.BTN_SAVE);
            this.flowLayoutPanel1.Controls.Add(this.BTN_EDIT);
            this.flowLayoutPanel1.Controls.Add(this.BTN_EXIT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 529);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(826, 51);
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
            this.BTN_SEARCH.Location = new System.Drawing.Point(655, 3);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(168, 45);
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
            this.BTN_NEW.Location = new System.Drawing.Point(503, 3);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(146, 45);
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
            this.BTN_SAVE.Location = new System.Drawing.Point(325, 3);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(172, 45);
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
            this.BTN_EDIT.Location = new System.Drawing.Point(161, 3);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(158, 45);
            this.BTN_EDIT.TabIndex = 101;
            this.BTN_EDIT.Text = "تعديل";
            this.BTN_EDIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EDIT.UseVisualStyleBackColor = false;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
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
            this.BTN_EXIT.Size = new System.Drawing.Size(150, 45);
            this.BTN_EXIT.TabIndex = 103;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(205, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 30);
            this.label5.TabIndex = 64;
            this.label5.Text = "الباقي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(439, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 64;
            this.label4.Text = "الواصل";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(685, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 64;
            this.label3.Text = "المجموع الكلي";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXT_PAID
            // 
            this.TXT_PAID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PAID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TXT_PAID.Location = new System.Drawing.Point(282, 493);
            this.TXT_PAID.Name = "TXT_PAID";
            this.TXT_PAID.Size = new System.Drawing.Size(153, 30);
            this.TXT_PAID.TabIndex = 63;
            this.TXT_PAID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PAID.TextChanged += new System.EventHandler(this.TXT_PAID_TextChanged);
            this.TXT_PAID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PAID_KeyPress);
            // 
            // TXT_REMAIN
            // 
            this.TXT_REMAIN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_REMAIN.ForeColor = System.Drawing.Color.Red;
            this.TXT_REMAIN.Location = new System.Drawing.Point(8, 493);
            this.TXT_REMAIN.Name = "TXT_REMAIN";
            this.TXT_REMAIN.ReadOnly = true;
            this.TXT_REMAIN.Size = new System.Drawing.Size(191, 30);
            this.TXT_REMAIN.TabIndex = 63;
            this.TXT_REMAIN.Text = "0.00";
            this.TXT_REMAIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_TOTAL
            // 
            this.TXT_TOTAL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TOTAL.ForeColor = System.Drawing.Color.Red;
            this.TXT_TOTAL.Location = new System.Drawing.Point(510, 493);
            this.TXT_TOTAL.Name = "TXT_TOTAL";
            this.TXT_TOTAL.ReadOnly = true;
            this.TXT_TOTAL.Size = new System.Drawing.Size(171, 30);
            this.TXT_TOTAL.TabIndex = 63;
            this.TXT_TOTAL.Text = "0.00";
            this.TXT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox5.Controls.Add(this.txtPrices);
            this.groupBox5.Controls.Add(this.txtPricep);
            this.groupBox5.Controls.Add(this.txt_Qnty);
            this.groupBox5.Controls.Add(label6);
            this.groupBox5.Controls.Add(this.dOCTOR_NAMEComboBox);
            this.groupBox5.Controls.Add(this.cLIENT_NAME_ARComboBox);
            this.groupBox5.Controls.Add(this.DATE_PURCHER);
            this.groupBox5.Controls.Add(this.TXT_BARCODE);
            this.groupBox5.Controls.Add(label1);
            this.groupBox5.Controls.Add(this.TXT_ID_PURCHES);
            this.groupBox5.Controls.Add(CLIENT_NAME_ARLabel);
            this.groupBox5.Controls.Add(label2);
            this.groupBox5.Controls.Add(CLIENT_CODELabel);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(826, 152);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // txtPrices
            // 
            this.txtPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrices.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // 
            // 
            this.txtPrices.Border.Class = "TextBoxBorder";
            this.txtPrices.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrices.ForeColor = System.Drawing.Color.White;
            this.txtPrices.Location = new System.Drawing.Point(74, 71);
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.Size = new System.Drawing.Size(143, 32);
            this.txtPrices.TabIndex = 65;
            this.txtPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrices.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtPrices.WatermarkColor = System.Drawing.Color.Gainsboro;
            this.txtPrices.WatermarkFont = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrices.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPrices.WatermarkText = "سعر البيع";
            // 
            // txtPricep
            // 
            this.txtPricep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPricep.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // 
            // 
            this.txtPricep.Border.Class = "TextBoxBorder";
            this.txtPricep.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPricep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPricep.ForeColor = System.Drawing.Color.White;
            this.txtPricep.Location = new System.Drawing.Point(223, 71);
            this.txtPricep.Name = "txtPricep";
            this.txtPricep.Size = new System.Drawing.Size(167, 32);
            this.txtPricep.TabIndex = 64;
            this.txtPricep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPricep.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtPricep.WatermarkColor = System.Drawing.Color.Gainsboro;
            this.txtPricep.WatermarkFont = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPricep.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPricep.WatermarkText = "سعر الشراء";
            // 
            // txt_Qnty
            // 
            this.txt_Qnty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Qnty.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // 
            // 
            this.txt_Qnty.Border.Class = "TextBoxBorder";
            this.txt_Qnty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txt_Qnty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Qnty.ForeColor = System.Drawing.Color.White;
            this.txt_Qnty.Location = new System.Drawing.Point(15, 71);
            this.txt_Qnty.Name = "txt_Qnty";
            this.txt_Qnty.Size = new System.Drawing.Size(53, 32);
            this.txt_Qnty.TabIndex = 63;
            this.txt_Qnty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Qnty.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txt_Qnty.WatermarkColor = System.Drawing.Color.Gainsboro;
            this.txt_Qnty.WatermarkFont = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Qnty.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Qnty.WatermarkText = "العدد";
            // 
            // dOCTOR_NAMEComboBox
            // 
            this.dOCTOR_NAMEComboBox.DataSource = this.v_A_DOCTORBindingSource;
            this.dOCTOR_NAMEComboBox.DisplayMember = "DOCTOR_NAME";
            this.dOCTOR_NAMEComboBox.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dOCTOR_NAMEComboBox.FormattingEnabled = true;
            this.dOCTOR_NAMEComboBox.Location = new System.Drawing.Point(15, 16);
            this.dOCTOR_NAMEComboBox.Name = "dOCTOR_NAMEComboBox";
            this.dOCTOR_NAMEComboBox.Size = new System.Drawing.Size(375, 26);
            this.dOCTOR_NAMEComboBox.TabIndex = 61;
            this.dOCTOR_NAMEComboBox.ValueMember = "USER_CODE";
            this.dOCTOR_NAMEComboBox.SelectedIndexChanged += new System.EventHandler(this.dOCTOR_NAMEComboBox_SelectedIndexChanged);
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
            // cLIENT_NAME_ARComboBox
            // 
            this.cLIENT_NAME_ARComboBox.DataSource = this.p_GET_A_SUPPLIERSBindingSource;
            this.cLIENT_NAME_ARComboBox.DisplayMember = "CLIENT_NAME_AR";
            this.cLIENT_NAME_ARComboBox.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cLIENT_NAME_ARComboBox.FormattingEnabled = true;
            this.cLIENT_NAME_ARComboBox.Location = new System.Drawing.Point(15, 44);
            this.cLIENT_NAME_ARComboBox.Name = "cLIENT_NAME_ARComboBox";
            this.cLIENT_NAME_ARComboBox.Size = new System.Drawing.Size(375, 26);
            this.cLIENT_NAME_ARComboBox.TabIndex = 60;
            this.cLIENT_NAME_ARComboBox.ValueMember = "CLIENT_CODE";
            // 
            // p_GET_A_SUPPLIERSBindingSource
            // 
            this.p_GET_A_SUPPLIERSBindingSource.DataMember = "P_GET_A_SUPPLIERS";
            this.p_GET_A_SUPPLIERSBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // DATE_PURCHER
            // 
            this.DATE_PURCHER.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_PURCHER.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_PURCHER.Location = new System.Drawing.Point(534, 73);
            this.DATE_PURCHER.Name = "DATE_PURCHER";
            this.DATE_PURCHER.Size = new System.Drawing.Size(165, 30);
            this.DATE_PURCHER.TabIndex = 1;
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
            this.TXT_BARCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_BARCODE.ForeColor = System.Drawing.Color.White;
            this.TXT_BARCODE.Location = new System.Drawing.Point(15, 107);
            this.TXT_BARCODE.Name = "TXT_BARCODE";
            this.TXT_BARCODE.Size = new System.Drawing.Size(375, 32);
            this.TXT_BARCODE.TabIndex = 2;
            this.TXT_BARCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_BARCODE.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_BARCODE.WatermarkColor = System.Drawing.Color.Gainsboro;
            this.TXT_BARCODE.WatermarkFont = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_BARCODE.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TXT_BARCODE.WatermarkText = "الباركود";
            this.TXT_BARCODE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CLIENT_CODETextBoxX_KeyDown);
            this.TXT_BARCODE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_BARCODE_KeyPress);
            // 
            // TXT_ID_PURCHES
            // 
            this.TXT_ID_PURCHES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_ID_PURCHES.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // 
            // 
            this.TXT_ID_PURCHES.Border.Class = "TextBoxBorder";
            this.TXT_ID_PURCHES.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_ID_PURCHES.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_ID_PURCHES.ForeColor = System.Drawing.Color.White;
            this.TXT_ID_PURCHES.Location = new System.Drawing.Point(534, 16);
            this.TXT_ID_PURCHES.Name = "TXT_ID_PURCHES";
            this.TXT_ID_PURCHES.Size = new System.Drawing.Size(165, 35);
            this.TXT_ID_PURCHES.TabIndex = 0;
            this.TXT_ID_PURCHES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_ID_PURCHES.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_ID_PURCHES.WatermarkColor = System.Drawing.Color.DimGray;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // p_GET_A_ITEMS_BARCODEBindingSource
            // 
            this.p_GET_A_ITEMS_BARCODEBindingSource.DataMember = "P_GET_A_ITEMS_BARCODE";
            this.p_GET_A_ITEMS_BARCODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_A_ITEMS_BARCODETableAdapter
            // 
            this.p_GET_A_ITEMS_BARCODETableAdapter.ClearBeforeFill = true;
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
            // p_GET_A_SUPPLIERSTableAdapter
            // 
            this.p_GET_A_SUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // v_A_DOCTORTableAdapter
            // 
            this.v_A_DOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FRM_PURCHERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 583);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "FRM_PURCHERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المشتريات";
            this.Load += new System.EventHandler(this.FRM_PURCHERS_Load);
            this.Shown += new System.EventHandler(this.FRM_PURCHERS_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_SUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_ITEMS_BARCODEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        internal DevComponents.DotNetBar.Controls.TextBoxX TXT_BARCODE;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource p_GET_A_ITEMS_BARCODEBindingSource;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_ITEMS_BARCODETableAdapter p_GET_A_ITEMS_BARCODETableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource p_GET_A_SUPPLIERSBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_SUPPLIERSTableAdapter p_GET_A_SUPPLIERSTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_PAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.BindingSource v_A_DOCTORBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter v_A_DOCTORTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.DateTimePicker DATE_PURCHER;
        public System.Windows.Forms.DataGridView dataGridView1;
        public DevComponents.DotNetBar.Controls.TextBoxX TXT_ID_PURCHES;
        public System.Windows.Forms.ComboBox cLIENT_NAME_ARComboBox;
        public System.Windows.Forms.TextBox TXT_REMAIN;
        public System.Windows.Forms.TextBox TXT_TOTAL;
        public System.Windows.Forms.TextBox TXT_PAID;
        public System.Windows.Forms.ComboBox dOCTOR_NAMEComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_EXIT;
        internal DevComponents.DotNetBar.Controls.TextBoxX txt_Qnty;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPricep;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPrices;
    }
}