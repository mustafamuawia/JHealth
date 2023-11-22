namespace MEDICALCLINIC.USERCONTROL
{
    partial class UC_Extraction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SurgicalExtraction = new System.Windows.Forms.Button();
            this.btn_NormalExtraction = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_SurgicalExtraction);
            this.groupBox1.Controls.Add(this.btn_NormalExtraction);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 290);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extraction";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Extraction Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Impact", 9.75F);
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "--------------------------------------------------";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_SurgicalExtraction
            // 
            this.btn_SurgicalExtraction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SurgicalExtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.btn_SurgicalExtraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SurgicalExtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SurgicalExtraction.Font = new System.Drawing.Font("Impact", 9.75F);
            this.btn_SurgicalExtraction.ForeColor = System.Drawing.Color.White;
            this.btn_SurgicalExtraction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SurgicalExtraction.Location = new System.Drawing.Point(27, 157);
            this.btn_SurgicalExtraction.Name = "btn_SurgicalExtraction";
            this.btn_SurgicalExtraction.Size = new System.Drawing.Size(193, 33);
            this.btn_SurgicalExtraction.TabIndex = 111;
            this.btn_SurgicalExtraction.Text = "Surgical Extraction";
            this.btn_SurgicalExtraction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SurgicalExtraction.UseVisualStyleBackColor = false;
            this.btn_SurgicalExtraction.Click += new System.EventHandler(this.btn_NormalExtraction_Click);
            // 
            // btn_NormalExtraction
            // 
            this.btn_NormalExtraction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NormalExtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.btn_NormalExtraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_NormalExtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NormalExtraction.Font = new System.Drawing.Font("Impact", 9.75F);
            this.btn_NormalExtraction.ForeColor = System.Drawing.Color.White;
            this.btn_NormalExtraction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_NormalExtraction.Location = new System.Drawing.Point(27, 109);
            this.btn_NormalExtraction.Name = "btn_NormalExtraction";
            this.btn_NormalExtraction.Size = new System.Drawing.Size(193, 33);
            this.btn_NormalExtraction.TabIndex = 110;
            this.btn_NormalExtraction.Text = "Normal Extraction";
            this.btn_NormalExtraction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NormalExtraction.UseVisualStyleBackColor = false;
            this.btn_NormalExtraction.Click += new System.EventHandler(this.btn_NormalExtraction_Click);
            // 
            // UC_Extraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Extraction";
            this.Size = new System.Drawing.Size(250, 290);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SurgicalExtraction;
        private System.Windows.Forms.Button btn_NormalExtraction;
    }
}
