using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_C7
{
    public partial class DrawImage : Form
    {
        public DrawImage()
        {
            InitializeComponent();
        }

        private void DrawImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r1 = new Rectangle(0,0,this.ClientRectangle.Width / 2,this.ClientRectangle.Height / 2);
            Rectangle r2 = new Rectangle(0, this.ClientRectangle.Height / 2, this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2);
            Rectangle r3 = new Rectangle(this.ClientRectangle.Width / 2, 0, this.ClientRectangle.Width/2, this.ClientRectangle.Height);
            DrawImage_1(r1, e.Graphics);
            DrawText(r2, e.Graphics);
            DrawPolygon(r3,e.Graphics);
        }

        private void DrawImage_1(Rectangle r,Graphics g)
        {
            Image img = Image.FromFile(Application.StartupPath + @"/codeForces.jpg");
            g.DrawImage(img, r);

            // ve chu
            Font font = new Font("Arial", 25, FontStyle.Italic);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Far;
            SolidBrush sb = new SolidBrush(Color.FromArgb(50, 255, 255));
            g.DrawString("Code", font, sb, r,format);
        }

        private void DrawText(Rectangle r, Graphics g)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(r, Color.Black, Color.White,45);
            g.FillRectangle(lgb, r);
            SolidBrush sb = new SolidBrush(Color.Orange);
            Font f = new Font("Arial",30,FontStyle.Italic | FontStyle.Bold);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Center;
            fm.LineAlignment = StringAlignment.Center;
            g.DrawString("HELLO", f, sb, r, fm);
        }

        private void DrawPolygon(Rectangle r,Graphics g)
        {
            Point[] points = { new Point(r.Left, r.Height / 5), new Point(r.Left + r.Width / 2, 0), new Point(r.Width + r.Left, r.Height / 5), new Point(r.Left + r.Width / 2, r.Height) };
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(points);
            PathGradientBrush pgb = new PathGradientBrush(path);
            pgb.CenterColor = Color.White;
            Color[] colors = { Color.Red, Color.Yellow, Color.Cyan};
            pgb.SurroundColors = colors;
            g.FillPath(pgb, path);
        }
    }
}
