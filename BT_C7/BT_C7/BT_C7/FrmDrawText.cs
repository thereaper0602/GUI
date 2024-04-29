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
    public partial class FrmDrawText : Form
    {
        public FrmDrawText()
        {
            InitializeComponent();
        }



        private void FrmDrawText_Load(object sender, EventArgs e)
        {

        }

        private void FrmDrawText_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Arial", 40,FontStyle.Bold);
            string str = "HELLO";

            // string 1
            StringFormat format_1 = new StringFormat();
            format_1.LineAlignment = StringAlignment.Near;
            format_1.FormatFlags = StringFormatFlags.DirectionVertical;
            HatchBrush hb = new HatchBrush(HatchStyle.LightVertical, Color.Red, Color.Yellow);
            e.Graphics.DrawString(str, font, hb, ClientRectangle, format_1);

            // string 2
            format_1.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            e.Graphics.DrawString(str, font, Brushes.DarkGreen, this.ClientRectangle, format_1);

            // string 3
            LinearGradientBrush lgb = new LinearGradientBrush(new Rectangle(50, 50, 10, 10), Color.Blue, Color.White, 45);
            format_1.FormatFlags = StringFormatFlags.DirectionVertical;
            format_1.Alignment = StringAlignment.Far;
            format_1.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString(str, font, lgb, this.ClientRectangle, format_1);

            // string 4
            TextureBrush tb = new TextureBrush(Image.FromFile(Application.StartupPath + @"/img.jpg"));
            format_1 = new StringFormat();
            format_1.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString(str, font, tb, this.ClientRectangle, format_1);
        }
    }
}
