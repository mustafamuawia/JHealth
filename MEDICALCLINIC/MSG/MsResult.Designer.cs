
using System.Windows.Forms;

namespace Management_Seles.BaseForms
{
    partial class MsResult
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
            this.lab1 = new System.Windows.Forms.Label();
            this.GreenButton2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.greenPanel1 = new Green.GreenPanel();
            this.greenPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.BackColor = System.Drawing.Color.Transparent;
            this.lab1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(191)))), ((int)(((byte)(115)))));
            this.lab1.Location = new System.Drawing.Point(0, 0);
            this.lab1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(434, 164);
            this.lab1.TabIndex = 7;
            this.lab1.Text = " ";
            this.lab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GreenButton2
            // 
            this.GreenButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GreenButton2.BackColor = System.Drawing.Color.Red;
            this.GreenButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GreenButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenButton2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenButton2.ForeColor = System.Drawing.Color.White;
            this.GreenButton2.Location = new System.Drawing.Point(11, 168);
            this.GreenButton2.Name = "GreenButton2";
            this.GreenButton2.Size = new System.Drawing.Size(159, 49);
            this.GreenButton2.TabIndex = 9;
            this.GreenButton2.Text = "لا";
            this.GreenButton2.UseVisualStyleBackColor = false;
            this.GreenButton2.Click += new System.EventHandler(this.buttonNew1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(250, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 49);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "نعم";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // greenPanel1
            // 
            this.greenPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.greenPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.greenPanel1.BorderWidth = 4;
            this.greenPanel1.Controls.Add(this.btnSave);
            this.greenPanel1.Controls.Add(this.GreenButton2);
            this.greenPanel1.Controls.Add(this.lab1);
            this.greenPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greenPanel1.Location = new System.Drawing.Point(0, 0);
            this.greenPanel1.Name = "greenPanel1";
            this.greenPanel1.PaddingText = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.greenPanel1.Radius = 10;
            this.greenPanel1.RightToLeftLayout = false;
            this.greenPanel1.Shape = BaseContaner.GreenShape.RoundedRectangl;
            this.greenPanel1.Side = 8;
            this.greenPanel1.Size = new System.Drawing.Size(434, 229);
            this.greenPanel1.TabIndex = 10;
            this.greenPanel1.TabStop = false;
            this.greenPanel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MsResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(434, 229);
            this.Controls.Add(this.greenPanel1);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MsResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsResult";
            this.Load += new System.EventHandler(this.MsResult_Load);
            this.greenPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lab1;
        private Button GreenButton2;
        private Button btnSave;
        private Green.GreenPanel greenPanel1;
    }
}