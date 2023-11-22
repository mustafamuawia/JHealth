namespace MEDICALCLINIC.SALES
{
    partial class FRM_SALES
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SALES  ));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_PAID = new System.Windows.Forms.TextBox();
            this.TXT_REMAIN = new System.Windows.Forms.TextBox();
            this.TXT_TOTAL = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cLIENT_NAME_ARComboBox = new System.Windows.Forms.ComboBox();
            this.p_GET_A_SUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.DATE_PURCHER = new System.Windows.Forms.DateTimePicker();
            this.TXT_BARCODE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_ID_PURCHES = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXT_PAY = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX8 = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.p_GET_A_ITEMS_BARCODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_A_ITEMS_BARCODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_ITEMS_BARCODETableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.p_GET_A_SUPPLIERSTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_SUPPLIERSTableAdapter();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CLIENT_NAME_ARLabel = new System.Windows.Forms.Label();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_SUPPLIERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_ITEMS_BARCODEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_NAME_ARLabel
            // 
            CLIENT_NAME_ARLabel.AutoSize = true;
            CLIENT_NAME_ARLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_NAME_ARLabel.ForeColor = System.Drawing.Color.Green;
            CLIENT_NAME_ARLabel.Location = new System.Drawing.Point(402, 18);
            CLIENT_NAME_ARLabel.Name = "CLIENT_NAME_ARLabel";
            CLIENT_NAME_ARLabel.Size = new System.Drawing.Size(71, 20);
            CLIENT_NAME_ARLabel.TabIndex = 58;
            CLIENT_NAME_ARLabel.Text = "اسم العميل";
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.AutoSize = true;
            CLIENT_CODELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.ForeColor = System.Drawing.Color.Green;
            CLIENT_CODELabel.Location = new System.Drawing.Point(402, 62);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(86, 20);
            CLIENT_CODELabel.TabIndex = 57;
            CLIENT_CODELabel.Text = "باركود المادة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(703, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 20);
            label2.TabIndex = 57;
            label2.Text = "رقم الفاتورة";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label1.ForeColor = System.Drawing.Color.Red;
            label1.Location = new System.Drawing.Point(702, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 20);
            label1.TabIndex = 58;
            label1.Text = "تأريخ الفاتور";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 28);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXT_PAID);
            this.groupBox2.Controls.Add(this.TXT_REMAIN);
            this.groupBox2.Controls.Add(this.TXT_TOTAL);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 560);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(210, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 64;
            this.label5.Text = "الباقي";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(436, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 64;
            this.label4.Text = "الواصل";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(679, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 64;
            this.label3.Text = "المجموع الكلي";
            // 
            // TXT_PAID
            // 
            this.TXT_PAID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PAID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TXT_PAID.Location = new System.Drawing.Point(277, 437);
            this.TXT_PAID.Name = "TXT_PAID";
            this.TXT_PAID.Size = new System.Drawing.Size(153, 30);
            this.TXT_PAID.TabIndex = 63;
            this.TXT_PAID.Text = "0.00";
            this.TXT_PAID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PAID.TextChanged += new System.EventHandler(this.TXT_PAID_TextChanged);
            this.TXT_PAID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PAID_KeyPress);
            // 
            // TXT_REMAIN
            // 
            this.TXT_REMAIN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_REMAIN.ForeColor = System.Drawing.Color.Red;
            this.TXT_REMAIN.Location = new System.Drawing.Point(13, 437);
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
            this.TXT_TOTAL.Location = new System.Drawing.Point(508, 439);
            this.TXT_TOTAL.Name = "TXT_TOTAL";
            this.TXT_TOTAL.ReadOnly = true;
            this.TXT_TOTAL.Size = new System.Drawing.Size(171, 30);
            this.TXT_TOTAL.TabIndex = 63;
            this.TXT_TOTAL.Text = "0.00";
            this.TXT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cLIENT_NAME_ARComboBox);
            this.groupBox5.Controls.Add(this.DATE_PURCHER);
            this.groupBox5.Controls.Add(this.TXT_BARCODE);
            this.groupBox5.Controls.Add(label1);
            this.groupBox5.Controls.Add(this.TXT_ID_PURCHES);
            this.groupBox5.Controls.Add(CLIENT_NAME_ARLabel);
            this.groupBox5.Controls.Add(label2);
            this.groupBox5.Controls.Add(CLIENT_CODELabel);
            this.groupBox5.Location = new System.Drawing.Point(10, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(802, 98);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // cLIENT_NAME_ARComboBox
            // 
            this.cLIENT_NAME_ARComboBox.DataSource = this.p_GET_A_SUPPLIERSBindingSource;
            this.cLIENT_NAME_ARComboBox.DisplayMember = "CLIENT_NAME_AR";
            this.cLIENT_NAME_ARComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cLIENT_NAME_ARComboBox.FormattingEnabled = true;
            this.cLIENT_NAME_ARComboBox.Location = new System.Drawing.Point(17, 13);
            this.cLIENT_NAME_ARComboBox.Name = "cLIENT_NAME_ARComboBox";
            this.cLIENT_NAME_ARComboBox.Size = new System.Drawing.Size(375, 33);
            this.cLIENT_NAME_ARComboBox.TabIndex = 60;
            this.cLIENT_NAME_ARComboBox.ValueMember = "CLIENT_CODE";
            // 
            // p_GET_A_SUPPLIERSBindingSource
            // 
            this.p_GET_A_SUPPLIERSBindingSource.DataMember = "P_GET_A_SUPPLIERS";
            this.p_GET_A_SUPPLIERSBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DATE_PURCHER
            // 
            this.DATE_PURCHER.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_PURCHER.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATE_PURCHER.Location = new System.Drawing.Point(544, 59);
            this.DATE_PURCHER.Name = "DATE_PURCHER";
            this.DATE_PURCHER.Size = new System.Drawing.Size(151, 30);
            this.DATE_PURCHER.TabIndex = 59;
            // 
            // TXT_BARCODE
            // 
            this.TXT_BARCODE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_BARCODE.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXT_BARCODE.Border.Class = "TextBoxBorder";
            this.TXT_BARCODE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_BARCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_BARCODE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TXT_BARCODE.Location = new System.Drawing.Point(17, 51);
            this.TXT_BARCODE.Name = "TXT_BARCODE";
            this.TXT_BARCODE.Size = new System.Drawing.Size(375, 34);
            this.TXT_BARCODE.TabIndex = 53;
            this.TXT_BARCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_BARCODE.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_BARCODE.WatermarkColor = System.Drawing.Color.DimGray;
            this.TXT_BARCODE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CLIENT_CODETextBoxX_KeyDown);
            this.TXT_BARCODE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_BARCODE_KeyPress);
            // 
            // TXT_ID_PURCHES
            // 
            this.TXT_ID_PURCHES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_ID_PURCHES.BackColor = System.Drawing.Color.Lavender;
            // 
            // 
            // 
            this.TXT_ID_PURCHES.Border.Class = "TextBoxBorder";
            this.TXT_ID_PURCHES.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_ID_PURCHES.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_ID_PURCHES.ForeColor = System.Drawing.Color.Red;
            this.TXT_ID_PURCHES.Location = new System.Drawing.Point(544, 13);
            this.TXT_ID_PURCHES.Name = "TXT_ID_PURCHES";
            this.TXT_ID_PURCHES.Size = new System.Drawing.Size(151, 44);
            this.TXT_ID_PURCHES.TabIndex = 0;
            this.TXT_ID_PURCHES.Text = "0";
            this.TXT_ID_PURCHES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_ID_PURCHES.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_ID_PURCHES.WatermarkColor = System.Drawing.Color.DimGray;
            this.TXT_ID_PURCHES.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CLIENT_NAME_ARTextBoxX_KeyDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.TXT_PAY);
            this.groupBox4.Location = new System.Drawing.Point(10, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(800, 331);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(794, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.buttonX5);
            this.groupBox3.Controls.Add(this.buttonX3);
            this.groupBox3.Controls.Add(this.buttonX4);
            this.groupBox3.Controls.Add(this.buttonX1);
            this.groupBox3.Controls.Add(this.buttonX8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 507);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(822, 81);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX5.Image = ((System.Drawing.Image)(resources.GetObject("buttonX5.Image")));
            this.buttonX5.Location = new System.Drawing.Point(662, 16);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(25, 0, 2, 25);
            this.buttonX5.Size = new System.Drawing.Size(144, 55);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 0;
            this.buttonX5.Text = "Search";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX3.Image = ((System.Drawing.Image)(resources.GetObject("buttonX3.Image")));
            this.buttonX3.Location = new System.Drawing.Point(502, 16);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(25, 0, 2, 25);
            this.buttonX3.Size = new System.Drawing.Size(144, 55);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 1;
            this.buttonX3.Text = "New";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX4.Image = ((System.Drawing.Image)(resources.GetObject("buttonX4.Image")));
            this.buttonX4.Location = new System.Drawing.Point(17, 18);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(25, 0, 2, 25);
            this.buttonX4.Size = new System.Drawing.Size(144, 55);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 5;
            this.buttonX4.Text = "Exit";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.Location = new System.Drawing.Point(178, 16);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(25, 0, 2, 25);
            this.buttonX1.Size = new System.Drawing.Size(144, 55);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "PRINT";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX8
            // 
            this.buttonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX8.Image = ((System.Drawing.Image)(resources.GetObject("buttonX8.Image")));
            this.buttonX8.Location = new System.Drawing.Point(339, 16);
            this.buttonX8.Name = "buttonX8";
            this.buttonX8.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(25, 0, 2, 25);
            this.buttonX8.Size = new System.Drawing.Size(144, 55);
            this.buttonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX8.TabIndex = 2;
            this.buttonX8.Text = "Save";
            this.buttonX8.Click += new System.EventHandler(this.buttonX8_Click);
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
            // p_GET_A_SUPPLIERSTableAdapter
            // 
            this.p_GET_A_SUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "حذف";
            this.Column6.Name = "Column6";
            this.Column6.Text = "حذف";
            this.Column6.ToolTipText = "حذف";
            this.Column6.UseColumnTextForButtonValue = true;
            this.Column6.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "سعر البيع";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "المجموع ";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "سعر الشراء";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "العدد";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "أسم المادة";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "باركود";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 175;
            // 
            // FRM_PURCHERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 588);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FRM_PURCHERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_PURCHERS_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_SUPPLIERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_A_ITEMS_BARCODEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX8;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        internal DevComponents.DotNetBar.Controls.TextBoxX TXT_BARCODE;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker DATE_PURCHER;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource p_GET_A_ITEMS_BARCODEBindingSource;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_ITEMS_BARCODETableAdapter p_GET_A_ITEMS_BARCODETableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        internal DevComponents.DotNetBar.Controls.TextBoxX TXT_ID_PURCHES;
        private System.Windows.Forms.BindingSource p_GET_A_SUPPLIERSBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_A_SUPPLIERSTableAdapter p_GET_A_SUPPLIERSTableAdapter;
        private System.Windows.Forms.ComboBox cLIENT_NAME_ARComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_REMAIN;
        private System.Windows.Forms.TextBox TXT_PAY;
        private System.Windows.Forms.TextBox TXT_TOTAL;
        private System.Windows.Forms.TextBox TXT_PAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        
    }
}