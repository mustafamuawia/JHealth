namespace MEDICALCLINIC.DIAGNOSES
{
    partial class FRM_TOOTH_NOTE_BOOKING
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TOOTH_NOTE_BOOKING));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TXT_NOTICE = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TXT_NOTICE);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BTN_EXIT);
            this.splitContainer1.Size = new System.Drawing.Size(366, 286);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 0;
            // 
            // TXT_NOTICE
            // 
            this.TXT_NOTICE.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXT_NOTICE.Border.Class = "TextBoxBorder";
            this.TXT_NOTICE.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_NOTICE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_NOTICE.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_NOTICE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TXT_NOTICE.Location = new System.Drawing.Point(0, 0);
            this.TXT_NOTICE.Multiline = true;
            this.TXT_NOTICE.Name = "TXT_NOTICE";
            this.TXT_NOTICE.ReadOnly = true;
            this.TXT_NOTICE.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_NOTICE.Size = new System.Drawing.Size(366, 227);
            this.TXT_NOTICE.TabIndex = 54;
            this.TXT_NOTICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_NOTICE.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_NOTICE.WatermarkColor = System.Drawing.Color.DimGray;
            this.TXT_NOTICE.WatermarkFont = new System.Drawing.Font("STV", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_NOTICE.WatermarkImage = ((System.Drawing.Image)(resources.GetObject("TXT_NOTICE.WatermarkImage")));
            this.TXT_NOTICE.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.BackColor = System.Drawing.Color.Red;
            this.BTN_EXIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXIT.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EXIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EXIT.Location = new System.Drawing.Point(0, 0);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(366, 55);
            this.BTN_EXIT.TabIndex = 104;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // FRM_TOOTH_NOTE_BOOKING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 286);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "FRM_TOOTH_NOTE_BOOKING";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ملاحظات الحجز";
            this.Load += new System.EventHandler(this.FRM_TOOTH_NOTE_BOOKING_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BTN_EXIT;
        internal DevComponents.DotNetBar.Controls.TextBoxX TXT_NOTICE;
    }
}