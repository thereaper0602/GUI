using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_2
{
    public partial class Clock : UserControl
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clockLb.Text = String.Format("{0}:{1:00}:{2:00}",
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second);
        }
    }
}
