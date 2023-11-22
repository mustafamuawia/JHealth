namespace MEDICALCLINIC.DB_CONFIG
{
    partial class FRM_DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DB));
            this.btntestcon = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbSql = new System.Windows.Forms.RadioButton();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BTN_copyinstance = new System.Windows.Forms.Button();
            this.CmbServerName = new System.Windows.Forms.ComboBox();
            this.comb_db = new System.Windows.Forms.ComboBox();
            this.btn_getdb = new System.Windows.Forms.Button();
            this.btn_copydb = new System.Windows.Forms.Button();
            this.btn_get_instance = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Button();
            this.btn_SQLDB = new System.Windows.Forms.Button();
            this.btnActiveprd = new System.Windows.Forms.Button();
            this.bt_chagetype = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntestcon
            // 
            this.btntestcon.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btntestcon.Image = ((System.Drawing.Image)(resources.GetObject("btntestcon.Image")));
            this.btntestcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntestcon.Location = new System.Drawing.Point(16, 485);
            this.btntestcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntestcon.Name = "btntestcon";
            this.btntestcon.Size = new System.Drawing.Size(179, 43);
            this.btntestcon.TabIndex = 6;
            this.btntestcon.Text = "فحص الاتصال";
            this.btntestcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntestcon.UseVisualStyleBackColor = true;
            this.btntestcon.Click += new System.EventHandler(this.btntestcon_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(400, 485);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 43);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "أغــــلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(212, 485);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 43);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "حفظ ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbSql
            // 
            this.rbSql.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbSql.AutoSize = true;
            this.rbSql.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbSql.Location = new System.Drawing.Point(175, 318);
            this.rbSql.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSql.Name = "rbSql";
            this.rbSql.Size = new System.Drawing.Size(279, 25);
            this.rbSql.TabIndex = 3;
            this.rbSql.Text = "SQL SERVER AUTHENTICATION";
            this.rbSql.UseVisualStyleBackColor = true;
            this.rbSql.CheckedChanged += new System.EventHandler(this.rbSql_CheckedChanged);
            // 
            // rbWindows
            // 
            this.rbWindows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbWindows.AutoSize = true;
            this.rbWindows.Checked = true;
            this.rbWindows.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbWindows.Location = new System.Drawing.Point(175, 272);
            this.rbWindows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(256, 25);
            this.rbWindows.TabIndex = 2;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "WINDOWS AUTHENTCATION";
            this.rbWindows.UseVisualStyleBackColor = true;
            this.rbWindows.CheckedChanged += new System.EventHandler(this.rbWindows_CheckedChanged);
            // 
            // txtPWD
            // 
            this.txtPWD.Enabled = false;
            this.txtPWD.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPWD.Location = new System.Drawing.Point(175, 427);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPWD.Size = new System.Drawing.Size(364, 29);
            this.txtPWD.TabIndex = 5;
            this.txtPWD.UseSystemPasswordChar = true;
            // 
            // txtDB
            // 
            this.txtDB.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDB.Location = new System.Drawing.Point(179, 201);
            this.txtDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDB.Name = "txtDB";
            this.txtDB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDB.Size = new System.Drawing.Size(364, 29);
            this.txtDB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(41, 433);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "كلمة المرور :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(169, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "طريقة الدخول الى السيرفر:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtID.Location = new System.Drawing.Point(175, 356);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtID.Size = new System.Drawing.Size(364, 29);
            this.txtID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(21, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "قاعدة البيانات:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(5, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "أسم المستخدم :";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtServer.Location = new System.Drawing.Point(179, 161);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServer.Name = "txtServer";
            this.txtServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServer.Size = new System.Drawing.Size(364, 29);
            this.txtServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(40, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "أسم السيرفر:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(179, 393);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(78, 29);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "عرض";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // BTN_copyinstance
            // 
            this.BTN_copyinstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_copyinstance.Location = new System.Drawing.Point(509, 80);
            this.BTN_copyinstance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_copyinstance.Name = "BTN_copyinstance";
            this.BTN_copyinstance.Size = new System.Drawing.Size(33, 31);
            this.BTN_copyinstance.TabIndex = 26;
            this.BTN_copyinstance.Text = "C";
            this.BTN_copyinstance.UseVisualStyleBackColor = true;
            this.BTN_copyinstance.Click += new System.EventHandler(this.BTN_GETSQLSERVERNAME_Click);
            // 
            // CmbServerName
            // 
            this.CmbServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbServerName.FormattingEnabled = true;
            this.CmbServerName.Location = new System.Drawing.Point(179, 81);
            this.CmbServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbServerName.Name = "CmbServerName";
            this.CmbServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CmbServerName.Size = new System.Drawing.Size(277, 28);
            this.CmbServerName.TabIndex = 27;
            // 
            // comb_db
            // 
            this.comb_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_db.FormattingEnabled = true;
            this.comb_db.Location = new System.Drawing.Point(179, 114);
            this.comb_db.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comb_db.Name = "comb_db";
            this.comb_db.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comb_db.Size = new System.Drawing.Size(277, 28);
            this.comb_db.TabIndex = 28;
            // 
            // btn_getdb
            // 
            this.btn_getdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getdb.Location = new System.Drawing.Point(469, 113);
            this.btn_getdb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_getdb.Name = "btn_getdb";
            this.btn_getdb.Size = new System.Drawing.Size(33, 31);
            this.btn_getdb.TabIndex = 29;
            this.btn_getdb.Text = "Get";
            this.btn_getdb.UseVisualStyleBackColor = true;
            this.btn_getdb.Click += new System.EventHandler(this.btn_getdb_Click);
            // 
            // btn_copydb
            // 
            this.btn_copydb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copydb.Location = new System.Drawing.Point(509, 113);
            this.btn_copydb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_copydb.Name = "btn_copydb";
            this.btn_copydb.Size = new System.Drawing.Size(33, 31);
            this.btn_copydb.TabIndex = 30;
            this.btn_copydb.Text = "C";
            this.btn_copydb.UseVisualStyleBackColor = true;
            this.btn_copydb.Click += new System.EventHandler(this.btn_copydb_Click);
            // 
            // btn_get_instance
            // 
            this.btn_get_instance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get_instance.Location = new System.Drawing.Point(469, 80);
            this.btn_get_instance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_get_instance.Name = "btn_get_instance";
            this.btn_get_instance.Size = new System.Drawing.Size(33, 31);
            this.btn_get_instance.TabIndex = 31;
            this.btn_get_instance.Text = "Get";
            this.btn_get_instance.UseVisualStyleBackColor = true;
            this.btn_get_instance.Click += new System.EventHandler(this.btn_get_instance_Click);
            // 
            // d
            // 
            this.d.BackColor = System.Drawing.Color.DimGray;
            this.d.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.d.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.d.ForeColor = System.Drawing.Color.White;
            this.d.Location = new System.Drawing.Point(16, 22);
            this.d.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(164, 43);
            this.d.TabIndex = 129;
            this.d.Text = "Local DB";
            this.d.UseVisualStyleBackColor = false;
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // btn_SQLDB
            // 
            this.btn_SQLDB.BackColor = System.Drawing.Color.DimGray;
            this.btn_SQLDB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SQLDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SQLDB.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_SQLDB.ForeColor = System.Drawing.Color.White;
            this.btn_SQLDB.Location = new System.Drawing.Point(212, 22);
            this.btn_SQLDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SQLDB.Name = "btn_SQLDB";
            this.btn_SQLDB.Size = new System.Drawing.Size(164, 43);
            this.btn_SQLDB.TabIndex = 130;
            this.btn_SQLDB.Text = "Sql Server";
            this.btn_SQLDB.UseVisualStyleBackColor = false;
            this.btn_SQLDB.Click += new System.EventHandler(this.btn_SQLDB_Click);
            // 
            // btnActiveprd
            // 
            this.btnActiveprd.BackColor = System.Drawing.Color.DimGray;
            this.btnActiveprd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActiveprd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveprd.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnActiveprd.ForeColor = System.Drawing.Color.White;
            this.btnActiveprd.Location = new System.Drawing.Point(415, 22);
            this.btnActiveprd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActiveprd.Name = "btnActiveprd";
            this.btnActiveprd.Size = new System.Drawing.Size(164, 43);
            this.btnActiveprd.TabIndex = 131;
            this.btnActiveprd.Text = "Active Product";
            this.btnActiveprd.UseVisualStyleBackColor = false;
            this.btnActiveprd.Click += new System.EventHandler(this.btnActiveprd_Click);
            // 
            // bt_chagetype
            // 
            this.bt_chagetype.BackColor = System.Drawing.Color.DimGray;
            this.bt_chagetype.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_chagetype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chagetype.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bt_chagetype.ForeColor = System.Drawing.Color.White;
            this.bt_chagetype.Location = new System.Drawing.Point(439, 238);
            this.bt_chagetype.Margin = new System.Windows.Forms.Padding(4);
            this.bt_chagetype.Name = "bt_chagetype";
            this.bt_chagetype.Size = new System.Drawing.Size(139, 43);
            this.bt_chagetype.TabIndex = 132;
            this.bt_chagetype.Text = "Chage Type";
            this.bt_chagetype.UseVisualStyleBackColor = false;
            this.bt_chagetype.Click += new System.EventHandler(this.bt_chagetype_Click);
            // 
            // FRM_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 538);
            this.Controls.Add(this.bt_chagetype);
            this.Controls.Add(this.btnActiveprd);
            this.Controls.Add(this.btn_SQLDB);
            this.Controls.Add(this.d);
            this.Controls.Add(this.btn_get_instance);
            this.Controls.Add(this.btn_copydb);
            this.Controls.Add(this.btn_getdb);
            this.Controls.Add(this.comb_db);
            this.Controls.Add(this.CmbServerName);
            this.Controls.Add(this.BTN_copyinstance);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btntestcon);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbSql);
            this.Controls.Add(this.rbWindows);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_DB";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أعدادت السيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntestcon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbSql;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BTN_copyinstance;
        private System.Windows.Forms.ComboBox CmbServerName;
        private System.Windows.Forms.ComboBox comb_db;
        private System.Windows.Forms.Button btn_getdb;
        private System.Windows.Forms.Button btn_copydb;
        private System.Windows.Forms.Button btn_get_instance;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.Button btn_SQLDB;
        private System.Windows.Forms.Button btnActiveprd;
        private System.Windows.Forms.Button bt_chagetype;
    }
}