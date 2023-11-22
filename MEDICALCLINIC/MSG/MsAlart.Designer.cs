
partial class MsAlart
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
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        this.panleDesgin1 = new Green.GreenPanel();
        this.iconAwsome1 = new Green.GreenIconAwesome();
        this.label1 = new System.Windows.Forms.Label();
        this.panleDesgin1.SuspendLayout();
        this.SuspendLayout();
        // 
        // timer1
        // 
        this.timer1.Enabled = true;
        this.timer1.Interval = 1500;
        this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        // 
        // panleDesgin1
        // 
        this.panleDesgin1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.panleDesgin1.BackgroundColor = System.Drawing.Color.Gray;
        this.panleDesgin1.BorderColor = System.Drawing.Color.Transparent;
        this.panleDesgin1.BorderWidth = 0;
        this.panleDesgin1.Controls.Add(this.iconAwsome1);
        this.panleDesgin1.Controls.Add(this.label1);
        this.panleDesgin1.Location = new System.Drawing.Point(6, 6);
        this.panleDesgin1.Name = "panleDesgin1";
        this.panleDesgin1.PaddingText = new System.Windows.Forms.Padding(0, 8, 0, 0);
        this.panleDesgin1.Radius = 10;
        this.panleDesgin1.RightToLeftLayout = false;
        this.panleDesgin1.Shape = BaseContaner.GreenShape.RoundedRectangl;
        this.panleDesgin1.Side = 8;
        this.panleDesgin1.Size = new System.Drawing.Size(420, 58);
        this.panleDesgin1.TabIndex = 1;
        this.panleDesgin1.TabStop = false;
        this.panleDesgin1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
        // 
        // iconAwsome1
        // 
        this.iconAwsome1.Anchor = System.Windows.Forms.AnchorStyles.Left;
        this.iconAwsome1.BackgroundColor = System.Drawing.Color.White;
        this.iconAwsome1.BorderColor = System.Drawing.Color.Transparent;
        this.iconAwsome1.BorderWidth = 2;
        this.iconAwsome1.CharSet = "f007";
        this.iconAwsome1.ForeColor = System.Drawing.SystemColors.WindowFrame;
        this.iconAwsome1.IconAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.iconAwsome1.IconColor = System.Drawing.SystemColors.ControlText;
        this.iconAwsome1.IconSize = 20F;
        this.iconAwsome1.IconStyle = Green.BaseIcon.MyEnum.Solid;
        this.iconAwsome1.Location = new System.Drawing.Point(6, 7);
        this.iconAwsome1.Name = "iconAwsome1";
        this.iconAwsome1.PaddingIcon = new System.Windows.Forms.Padding(0, 3, 0, 0);
        this.iconAwsome1.PaddingText = new System.Windows.Forms.Padding(0, 0, 0, 0);
        this.iconAwsome1.Radius = 500;
        this.iconAwsome1.Shape = BaseControls.GreenShape.RoundedRectangl;
        this.iconAwsome1.Side = 8;
        this.iconAwsome1.Size = new System.Drawing.Size(44, 44);
        this.iconAwsome1.TabIndex = 0;
        this.iconAwsome1.TabStop = false;
        this.iconAwsome1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.label1.Location = new System.Drawing.Point(58, 8);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(348, 45);
        this.label1.TabIndex = 1;
        this.label1.Text = "label1";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // MsAlart
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 30F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
        this.ClientSize = new System.Drawing.Size(432, 70);
        this.Controls.Add(this.panleDesgin1);
        this.Font = new System.Drawing.Font("Cairo", 12F);
        this.ForeColor = System.Drawing.Color.White;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.KeyPreview = true;
        this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
        this.Name = "MsAlart";
        this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        this.Text = "MsResult";
        this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MsAlart_FormClosing);
        this.Load += new System.EventHandler(this.MsAlart_Load);
        this.Shown += new System.EventHandler(this.MsAlart_Shown);
        this.panleDesgin1.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private Green.GreenIconAwesome iconAwsome1;
    private Green.GreenPanel panleDesgin1;
    private System.Windows.Forms.Label label1;
}
