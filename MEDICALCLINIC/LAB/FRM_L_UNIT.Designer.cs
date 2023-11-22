using System.Windows.Forms;

namespace MEDICALCLINIC.LAB
{
    partial class FRM_L_UNIT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_L_UNIT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gET_L_UNIT_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TXTCODE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTNAME_CATEG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.v_GET_A_L_UNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_GET_A_L_CATEGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_L_CATEG_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PIC_CLOSE = new System.Windows.Forms.PictureBox();
            this.gET_L_CATEG_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_L_CATEG_NAME_CODETableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.gET_L_UNIT_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_L_UNIT_NAME_CODETableAdapter();
            this.v_GET_A_L_CATEGTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_A_L_CATEGTableAdapter();
            this.v_GET_A_L_UNITTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_A_L_UNITTableAdapter();
            this.btndet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVEUNITDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_L_UNIT_NAME_CODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_GET_A_L_UNITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GET_A_L_CATEGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_L_CATEG_NAME_CODEBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_CLOSE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(580, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.74648F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.253521F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(568, 207);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(281, 203);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.22124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.77876F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(277, 186);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("STV", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btndet,
            this.iDUNITDataGridViewTextBoxColumn,
            this.nAMEUNITDataGridViewTextBoxColumn,
            this.aCTIVEUNITDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.gET_L_UNIT_NAME_CODEBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("STV", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(273, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gET_L_UNIT_NAME_CODEBindingSource
            // 
            this.gET_L_UNIT_NAME_CODEBindingSource.DataMember = "GET_L_UNIT_NAME_CODE";
            this.gET_L_UNIT_NAME_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TXTSEARCH);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("STV", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox5.Location = new System.Drawing.Point(2, 2);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(273, 42);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ابحث عن الاسم او الكود هنا";
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTSEARCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTSEARCH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTSEARCH.Location = new System.Drawing.Point(2, 14);
            this.TXTSEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(269, 23);
            this.TXTSEARCH.TabIndex = 1;
            this.TXTSEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.TXTSEARCH_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TXTCODE);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.TXTNAME_CATEG);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(293, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(273, 203);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // TXTCODE
            // 
            this.TXTCODE.BackColor = System.Drawing.Color.White;
            this.TXTCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTCODE.Font = new System.Drawing.Font("STV", 14F, System.Drawing.FontStyle.Bold);
            this.TXTCODE.Location = new System.Drawing.Point(125, 57);
            this.TXTCODE.Margin = new System.Windows.Forms.Padding(2);
            this.TXTCODE.Name = "TXTCODE";
            this.TXTCODE.ReadOnly = true;
            this.TXTCODE.Size = new System.Drawing.Size(117, 28);
            this.TXTCODE.TabIndex = 4;
            this.TXTCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("STV", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(173, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = ":كود الوحدة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXTNAME_CATEG
            // 
            this.TXTNAME_CATEG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTNAME_CATEG.Font = new System.Drawing.Font("STV", 14F, System.Drawing.FontStyle.Bold);
            this.TXTNAME_CATEG.Location = new System.Drawing.Point(12, 136);
            this.TXTNAME_CATEG.Margin = new System.Windows.Forms.Padding(2);
            this.TXTNAME_CATEG.Name = "TXTNAME_CATEG";
            this.TXTNAME_CATEG.Size = new System.Drawing.Size(230, 28);
            this.TXTNAME_CATEG.TabIndex = 0;
            this.TXTNAME_CATEG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("STV", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(168, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = ":أسـم الوحدة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(287, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 203);
            this.panel9.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.ForeColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(6, 226);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(568, 4);
            this.panel7.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.BTN_CLOSE);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.BTN_NEW);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 230);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(568, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLOSE.Font = new System.Drawing.Font("STV", 14F, System.Drawing.FontStyle.Bold);
            this.BTN_CLOSE.ForeColor = System.Drawing.Color.White;
            this.BTN_CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CLOSE.Image")));
            this.BTN_CLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CLOSE.Location = new System.Drawing.Point(2, 2);
            this.BTN_CLOSE.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(101, 36);
            this.BTN_CLOSE.TabIndex = 0;
            this.BTN_CLOSE.Text = "خروج";
            this.BTN_CLOSE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CLOSE.UseVisualStyleBackColor = false;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("STV", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(107, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "حذف";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("STV", 14F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(221, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "تعديل";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("STV", 14F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(332, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "حفظ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.BackColor = System.Drawing.Color.Black;
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.Font = new System.Drawing.Font("STV", 14F, System.Drawing.FontStyle.Bold);
            this.BTN_NEW.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW.Image = ((System.Drawing.Image)(resources.GetObject("BTN_NEW.Image")));
            this.BTN_NEW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NEW.Location = new System.Drawing.Point(450, 2);
            this.BTN_NEW.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(113, 36);
            this.BTN_NEW.TabIndex = 4;
            this.BTN_NEW.Text = "جديد";
            this.BTN_NEW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_NEW.UseVisualStyleBackColor = false;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.ForeColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(6, 271);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(568, 4);
            this.panel4.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(6, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 4);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 2);
            this.panel3.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.ForeColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(2, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 260);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.ForeColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(574, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 260);
            this.panel6.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.ForeColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(574, 15);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(4, 275);
            this.panel8.TabIndex = 18;
            // 
            // v_GET_A_L_UNITBindingSource
            // 
            this.v_GET_A_L_UNITBindingSource.DataMember = "V_GET_A_L_UNIT";
            this.v_GET_A_L_UNITBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // v_GET_A_L_CATEGBindingSource
            // 
            this.v_GET_A_L_CATEGBindingSource.DataMember = "V_GET_A_L_CATEG";
            this.v_GET_A_L_CATEGBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // gET_L_CATEG_NAME_CODEBindingSource
            // 
            this.gET_L_CATEG_NAME_CODEBindingSource.DataMember = "GET_L_CATEG_NAME_CODE";
            this.gET_L_CATEG_NAME_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.PIC_CLOSE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 32);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // PIC_CLOSE
            // 
            this.PIC_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PIC_CLOSE.Dock = System.Windows.Forms.DockStyle.Right;
            this.PIC_CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("PIC_CLOSE.Image")));
            this.PIC_CLOSE.Location = new System.Drawing.Point(544, 0);
            this.PIC_CLOSE.Margin = new System.Windows.Forms.Padding(2);
            this.PIC_CLOSE.Name = "PIC_CLOSE";
            this.PIC_CLOSE.Size = new System.Drawing.Size(36, 32);
            this.PIC_CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_CLOSE.TabIndex = 0;
            this.PIC_CLOSE.TabStop = false;
            this.PIC_CLOSE.Click += new System.EventHandler(this.PIC_CLOSE_Click);
            // 
            // gET_L_CATEG_NAME_CODETableAdapter
            // 
            this.gET_L_CATEG_NAME_CODETableAdapter.ClearBeforeFill = true;
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
            // gET_L_UNIT_NAME_CODETableAdapter
            // 
            this.gET_L_UNIT_NAME_CODETableAdapter.ClearBeforeFill = true;
            // 
            // v_GET_A_L_CATEGTableAdapter
            // 
            this.v_GET_A_L_CATEGTableAdapter.ClearBeforeFill = true;
            // 
            // v_GET_A_L_UNITTableAdapter
            // 
            this.v_GET_A_L_UNITTableAdapter.ClearBeforeFill = true;
            // 
            // btndet
            // 
            this.btndet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndet.HeaderText = "تفاصيل";
            this.btndet.MinimumWidth = 6;
            this.btndet.Name = "btndet";
            this.btndet.Text = "تفاصيل";
            this.btndet.ToolTipText = "تفاصيل";
            this.btndet.UseColumnTextForButtonValue = true;
            this.btndet.Width = 60;
            // 
            // iDUNITDataGridViewTextBoxColumn
            // 
            this.iDUNITDataGridViewTextBoxColumn.DataPropertyName = "ID_UNIT";
            this.iDUNITDataGridViewTextBoxColumn.HeaderText = "كود الوحدة";
            this.iDUNITDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDUNITDataGridViewTextBoxColumn.Name = "iDUNITDataGridViewTextBoxColumn";
            this.iDUNITDataGridViewTextBoxColumn.Width = 125;
            // 
            // nAMEUNITDataGridViewTextBoxColumn
            // 
            this.nAMEUNITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAMEUNITDataGridViewTextBoxColumn.DataPropertyName = "NAME_UNIT";
            this.nAMEUNITDataGridViewTextBoxColumn.HeaderText = " الوحدة";
            this.nAMEUNITDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEUNITDataGridViewTextBoxColumn.Name = "nAMEUNITDataGridViewTextBoxColumn";
            // 
            // aCTIVEUNITDataGridViewCheckBoxColumn
            // 
            this.aCTIVEUNITDataGridViewCheckBoxColumn.DataPropertyName = "ACTIVE_UNIT";
            this.aCTIVEUNITDataGridViewCheckBoxColumn.HeaderText = "ACTIVE_UNIT";
            this.aCTIVEUNITDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.aCTIVEUNITDataGridViewCheckBoxColumn.Name = "aCTIVEUNITDataGridViewCheckBoxColumn";
            this.aCTIVEUNITDataGridViewCheckBoxColumn.Visible = false;
            this.aCTIVEUNITDataGridViewCheckBoxColumn.Width = 125;
            // 
            // FRM_L_UNIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 309);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_L_UNIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال معلومات الوحدات المختبرية";
            this.Load += new System.EventHandler(this.FRM_L_CATEG_Load);
            this.Shown += new System.EventHandler(this.FRM_L_CATEG_Shown);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_L_UNIT_NAME_CODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.v_GET_A_L_UNITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GET_A_L_CATEGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_L_CATEG_NAME_CODEBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_CLOSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTNAME_CATEG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTCODE;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_CLOSE;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PIC_CLOSE;
        private PictureBox pictureBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox5;
        private TextBox TXTSEARCH;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel7;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel9;
        private Panel panel8;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private BindingSource gET_L_CATEG_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_L_CATEG_NAME_CODETableAdapter gET_L_CATEG_NAME_CODETableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingSource gET_L_UNIT_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_L_UNIT_NAME_CODETableAdapter gET_L_UNIT_NAME_CODETableAdapter;
        private BindingSource v_GET_A_L_CATEGBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_A_L_CATEGTableAdapter v_GET_A_L_CATEGTableAdapter;
        private BindingSource v_GET_A_L_UNITBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_A_L_UNITTableAdapter v_GET_A_L_UNITTableAdapter;
        private DataGridViewButtonColumn btndet;
        private DataGridViewTextBoxColumn iDUNITDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nAMEUNITDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn aCTIVEUNITDataGridViewCheckBoxColumn;
    }
}