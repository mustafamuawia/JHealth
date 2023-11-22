using System;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

using System.Text;

using System.Windows.Forms;

public enum AlartType
{
    Save,
    Error,
    help,
    Update,
    Delete
}

public partial class MsAlart : Form
{

    protected override bool ShowWithoutActivation { get { return true; } }

    protected override CreateParams CreateParams
    {
        get
        {
            //make sure Top Most property on form is set to false
            //otherwise this doesn't work
            int WS_EX_TOPMOST = 0x00000008;
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= WS_EX_TOPMOST;
            return cp;
        }
    }
    public GraphicsPath RoundedRectangl(Rectangle r, int curve)
    {
        GraphicsPath g;
        curve = (curve >= r.Height) ? r.Height : curve;
        g = new GraphicsPath(FillMode.Winding);
        g.AddArc(r.X, r.Y, curve, curve, 180f, 90f);
        g.AddArc(r.Right - curve, r.Y, curve, curve, 270f, 90f);
        g.AddArc(r.Right - curve, r.Bottom - curve, curve, curve, 0f, 90f);
        g.AddArc(r.X, r.Bottom - curve, curve, curve, 90f, 90f);
        g.CloseFigure();
        return g;

    }
    int x = 0, y = 0;
    public MsAlart()
    {
        InitializeComponent();

        this.ShowInTaskbar = false;

    }
    public AlartType AlartType { get; set; }
    public string message { get; set; }
    public string charSet { get; set; }



    int index = 0;

    private void MsAlart_Shown(object sender, EventArgs e)
    {
        while (y >= Screen.PrimaryScreen.WorkingArea.Height - this.Height / 2)
        {
            y -= 10;
            this.Location = new Point(x, y);

            Refresh();
        }
        while (y >= Screen.PrimaryScreen.WorkingArea.Height - this.Height)
        {
            y -= 3;
            this.Location = new Point(x, y);

            Refresh();
        }
        timer1.Start();


    }

    private void MsAlart_FormClosing(object sender, FormClosingEventArgs e)
    {

        while (y <= Screen.PrimaryScreen.WorkingArea.Height - this.Height)
        {
            y += 3;
            this.Location = new Point(x, y);
            Refresh();
        }
        while (y <= Screen.PrimaryScreen.WorkingArea.Height - this.Height + 100)
        {
            y += 25;
            this.Location = new Point(x, y);

            Refresh();
        }
    }

    private void MsAlart_Load(object sender, EventArgs e)
    {
        x = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
        y = Screen.PrimaryScreen.WorkingArea.Height + this.Height - 30;
        this.Location = new Point(x, y);

        iconAwsome1.CharSet = charSet;
        label1.Text = message;

        switch (AlartType)
        {
            case AlartType.Save:
                iconAwsome1.IconColor = Color.FromArgb(255, 33, 191, 115);
                panleDesgin1.BackgroundColor = iconAwsome1.IconColor;
                break;
            case AlartType.Update:
                iconAwsome1.IconColor = ColorTranslator.FromHtml("#28527a");
                panleDesgin1.BackgroundColor = iconAwsome1.IconColor;
                break;
            case AlartType.Error:
                iconAwsome1.IconColor = Color.FromArgb(255, 255, 0, 0);
                panleDesgin1.BackgroundColor = iconAwsome1.IconColor;
                break;
            case AlartType.help:
                iconAwsome1.IconColor = Color.FromArgb(255, 99, 58, 130);
                panleDesgin1.BackgroundColor = iconAwsome1.IconColor;
                break;

        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        if (index == 1)
        {
            this.Close();
        }
        index = 1;
    }
}
