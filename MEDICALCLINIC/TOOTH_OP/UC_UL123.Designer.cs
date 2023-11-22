namespace MEDICALCLINIC.TOOTH_OP
{
    partial class UC_UL123
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.B_MB_U = new System.Windows.Forms.Button();
            this.TXT_UPPER = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TXT_UPPER, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(275, 225);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.B_MB_U, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(267, 181);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // B_MB_U
            // 
            this.B_MB_U.BackColor = System.Drawing.Color.SteelBlue;
            this.B_MB_U.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_MB_U.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_MB_U.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_MB_U.ForeColor = System.Drawing.Color.White;
            this.B_MB_U.Location = new System.Drawing.Point(6, 6);
            this.B_MB_U.Name = "B_MB_U";
            this.B_MB_U.Size = new System.Drawing.Size(255, 169);
            this.B_MB_U.TabIndex = 1;
            this.B_MB_U.Text = "Canal";
            this.B_MB_U.UseVisualStyleBackColor = false;
            this.B_MB_U.Click += new System.EventHandler(this.B_MB_U_Click);
            // 
            // TXT_UPPER
            // 
            this.TXT_UPPER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_UPPER.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_UPPER.Location = new System.Drawing.Point(4, 192);
            this.TXT_UPPER.Name = "TXT_UPPER";
            this.TXT_UPPER.Size = new System.Drawing.Size(267, 29);
            this.TXT_UPPER.TabIndex = 2;
            this.TXT_UPPER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_UPPER.TextChanged += new System.EventHandler(this.TXT_UPPER_TextChanged);
            // 
            // UC_UL123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_UL123";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(275, 225);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TXT_UPPER;
        private System.Windows.Forms.Button B_MB_U;
    }
}
