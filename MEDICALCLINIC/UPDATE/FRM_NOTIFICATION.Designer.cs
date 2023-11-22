
namespace MEDICALCLINIC.UPDATE
{
    partial class FRM_NOTIFICATION
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
            this.btnlater = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblversio = new System.Windows.Forms.Label();
            this.lbltypeupdate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlater
            // 
            this.btnlater.Location = new System.Drawing.Point(30, 120);
            this.btnlater.Name = "btnlater";
            this.btnlater.Size = new System.Drawing.Size(75, 23);
            this.btnlater.TabIndex = 0;
            this.btnlater.Text = "Later";
            this.btnlater.UseVisualStyleBackColor = true;
            this.btnlater.Click += new System.EventHandler(this.btnlater_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblversio
            // 
            this.lblversio.AutoSize = true;
            this.lblversio.Location = new System.Drawing.Point(111, 41);
            this.lblversio.Name = "lblversio";
            this.lblversio.Size = new System.Drawing.Size(31, 13);
            this.lblversio.TabIndex = 2;
            this.lblversio.Text = "none";
            // 
            // lbltypeupdate
            // 
            this.lbltypeupdate.AutoSize = true;
            this.lbltypeupdate.Location = new System.Drawing.Point(266, 46);
            this.lbltypeupdate.Name = "lbltypeupdate";
            this.lbltypeupdate.Size = new System.Drawing.Size(31, 13);
            this.lbltypeupdate.TabIndex = 4;
            this.lbltypeupdate.Text = "none";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(165, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type Update:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(111, 86);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(31, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "none";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(185, 120);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update Now";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "There is new update";
            // 
            // FRM_NOTIFICATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 152);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltypeupdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblversio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlater);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_NOTIFICATION";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FRM_NOTIFICATION";
            this.Shown += new System.EventHandler(this.FRM_NOTIFICATION_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblversio;
        private System.Windows.Forms.Label lbltypeupdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label5;
    }
}