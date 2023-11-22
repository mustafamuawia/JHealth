
namespace MEDICALCLINIC.CHAT
{
    partial class FRM_NOTIF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NOTIF));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_OPEN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_OPEN
            // 
            this.BTN_OPEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.BTN_OPEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_OPEN.FlatAppearance.BorderSize = 0;
            this.BTN_OPEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OPEN.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OPEN.ForeColor = System.Drawing.Color.White;
            this.BTN_OPEN.Image = ((System.Drawing.Image)(resources.GetObject("BTN_OPEN.Image")));
            this.BTN_OPEN.Location = new System.Drawing.Point(0, 0);
            this.BTN_OPEN.Name = "BTN_OPEN";
            this.BTN_OPEN.Size = new System.Drawing.Size(81, 72);
            this.BTN_OPEN.TabIndex = 1;
            this.BTN_OPEN.UseVisualStyleBackColor = false;
            this.BTN_OPEN.Click += new System.EventHandler(this.BTN_OPEN_Click);
            // 
            // FRM_NOTIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 72);
            this.Controls.Add(this.BTN_OPEN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_NOTIF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FRM_NOTIF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_NOTIF_FormClosing);
            this.Load += new System.EventHandler(this.FRM_NOTIF_Load);
            this.Shown += new System.EventHandler(this.FRM_NOTIF_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_OPEN;
    }
}