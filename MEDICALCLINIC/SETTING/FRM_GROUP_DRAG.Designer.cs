namespace MEDICALCLINIC.SETTING
{
    partial class FRM_GROUP_DRAG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_GROUP_DRAG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.TXT_GRP_GRP_NAME = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_GRP_DRAG_CODE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            CLIENT_NAME_ARLabel = new System.Windows.Forms.Label();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_NAME_ARLabel
            // 
            CLIENT_NAME_ARLabel.AutoSize = true;
            CLIENT_NAME_ARLabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_NAME_ARLabel.Location = new System.Drawing.Point(571, 74);
            CLIENT_NAME_ARLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            CLIENT_NAME_ARLabel.Name = "CLIENT_NAME_ARLabel";
            CLIENT_NAME_ARLabel.Size = new System.Drawing.Size(132, 22);
            CLIENT_NAME_ARLabel.TabIndex = 58;
            CLIENT_NAME_ARLabel.Text = ":اسم المجموعة";
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.AutoSize = true;
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.Location = new System.Drawing.Point(571, 29);
            CLIENT_CODELabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(130, 22);
            CLIENT_CODELabel.TabIndex = 57;
            CLIENT_CODELabel.Text = ":كود المجموعة";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(717, 20);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(CLIENT_NAME_ARLabel);
            this.groupBox2.Controls.Add(CLIENT_CODELabel);
            this.groupBox2.Controls.Add(this.TXT_GRP_GRP_NAME);
            this.groupBox2.Controls.Add(this.TXT_GRP_DRAG_CODE);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(717, 180);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 122);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(713, 55);
            this.flowLayoutPanel1.TabIndex = 104;
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.Color.Black;
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SEARCH.Image")));
            this.BTN_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SEARCH.Location = new System.Drawing.Point(597, 3);
            this.BTN_SEARCH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(114, 49);
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
            this.BTN_NEW.Location = new System.Drawing.Point(479, 3);
            this.BTN_NEW.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(114, 49);
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
            this.BTN_SAVE.Location = new System.Drawing.Point(361, 3);
            this.BTN_SAVE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(114, 49);
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
            this.BTN_EDIT.Location = new System.Drawing.Point(243, 3);
            this.BTN_EDIT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(114, 49);
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
            this.BTN_DELETE.Location = new System.Drawing.Point(125, 3);
            this.BTN_DELETE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(114, 49);
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
            this.BTN_EXIT.Location = new System.Drawing.Point(7, 3);
            this.BTN_EXIT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(114, 49);
            this.BTN_EXIT.TabIndex = 103;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // TXT_GRP_GRP_NAME
            // 
            this.TXT_GRP_GRP_NAME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_GRP_GRP_NAME.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.TXT_GRP_GRP_NAME.Border.Class = "TextBoxBorder";
            this.TXT_GRP_GRP_NAME.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_GRP_GRP_NAME.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_GRP_GRP_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TXT_GRP_GRP_NAME.Location = new System.Drawing.Point(50, 62);
            this.TXT_GRP_GRP_NAME.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TXT_GRP_GRP_NAME.Name = "TXT_GRP_GRP_NAME";
            this.TXT_GRP_GRP_NAME.Size = new System.Drawing.Size(502, 39);
            this.TXT_GRP_GRP_NAME.TabIndex = 0;
            this.TXT_GRP_GRP_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_GRP_GRP_NAME.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_GRP_GRP_NAME.WatermarkColor = System.Drawing.Color.DimGray;
            // 
            // TXT_GRP_DRAG_CODE
            // 
            this.TXT_GRP_DRAG_CODE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_GRP_DRAG_CODE.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.TXT_GRP_DRAG_CODE.Border.Class = "TextBoxBorder";
            this.TXT_GRP_DRAG_CODE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_GRP_DRAG_CODE.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_GRP_DRAG_CODE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TXT_GRP_DRAG_CODE.Location = new System.Drawing.Point(333, 17);
            this.TXT_GRP_DRAG_CODE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TXT_GRP_DRAG_CODE.Name = "TXT_GRP_DRAG_CODE";
            this.TXT_GRP_DRAG_CODE.ReadOnly = true;
            this.TXT_GRP_DRAG_CODE.Size = new System.Drawing.Size(218, 39);
            this.TXT_GRP_DRAG_CODE.TabIndex = 53;
            this.TXT_GRP_DRAG_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TXT_GRP_DRAG_CODE.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_GRP_DRAG_CODE.WatermarkColor = System.Drawing.Color.DimGray;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRM_GROUP_DRAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 200);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FRM_GROUP_DRAG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال مجموعة الدواء";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_EXIT;
        public DevComponents.DotNetBar.Controls.TextBoxX TXT_GRP_GRP_NAME;
        public DevComponents.DotNetBar.Controls.TextBoxX TXT_GRP_DRAG_CODE;
    }
}