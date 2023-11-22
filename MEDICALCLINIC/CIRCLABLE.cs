using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MEDICALCLINIC
{
    public class CIRCLABLE : PictureBox
    {
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

            this.Region = new System.Drawing.Region(g);
            base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // circularProgress1
            // 
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(0, 0);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.Size = new System.Drawing.Size(0, 0);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }


    }
}
