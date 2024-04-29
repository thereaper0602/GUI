using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace BT_C7
{
    public partial class FrmDrawMouse : Form
    {
        Bitmap bmp;
        Point oldPoint;
        int sizePen;
        Color penColor;
        private string keyBuffer = "";
        private int index = 0;
        public FrmDrawMouse()
        {
            InitializeComponent();
        }

        private void FrmDrawMouse_Load(object sender, EventArgs e)
        {
            sizePen = 1;
            penColor = Color.Red;
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void FrmDrawMouse_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint = e.Location;
        }

        private void FrmDrawMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(penColor, sizePen);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(pen, oldPoint, e.Location);
                oldPoint = e.Location;
                DoubleBuffered = true;
                Invalidate();
                /*
                 * Invalidate() : đánh dấu điều khiển đó rằng nó đã bị thay đổi và cần được cập nhật trên màn hình.
                 * Sau khi một điều khiển bị gọi Invalidate(), hệ thống sẽ sau đó gọi phương thức 
                 * Paint của điều khiển tại thời điểm thích hợp để cập nhật lại hình ảnh hiển thị.
                 */
            }
        }

        private void FrmDrawMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.R:penColor = Color.Red;break;
                case Keys.G:penColor = Color.Green;break;
                case Keys.B:penColor = Color.Blue;break;
                case Keys.Up:sizePen++;break;
                case Keys.Down:sizePen--;break;
            }
            return true;
        }
    }
}
