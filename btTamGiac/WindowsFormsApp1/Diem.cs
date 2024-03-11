using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Diem
    {
        private double x;
        private double y;
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getX
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double getY
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}
