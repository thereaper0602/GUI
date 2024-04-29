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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDrawText frm = new FrmDrawText();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void drawByMouseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDrawMouse frm = new FrmDrawMouse();
            frm.MdiParent = this;
            frm.Show();
        }

        private void drawImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DrawImage frm = new DrawImage();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
