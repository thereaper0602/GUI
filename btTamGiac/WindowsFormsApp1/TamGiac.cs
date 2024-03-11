using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class TamGiac
    {
        private Diem d1;
        private Diem d2;
        private Diem d3;

        public TamGiac(Diem d1, Diem d2, Diem d3)
        {
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
        }

        public static double area(Diem d1, Diem d2, Diem d3)
        {

            return Math.Abs((d2.getX - d1.getX) * (d3.getY - d1.getY) - (d3.getX - d1.getX) * (d2.getY - d1.getY)) / 2;
        }
        public bool checkPoint(Diem c)
        {
            double areaABC = area(d1, d2, d3);
            double areaPAB = area(c, d1, d2);
            double areaPBC = area(c, d2, d3);
            double areaPCA = area(c, d1, d3);
            return areaABC == (areaPAB + areaPBC + areaPCA);
        }

        public bool checkPolygon()
        {
            double AB = Math.Sqrt(Math.Pow(this.d2.getX - this.d1.getX, 2) + Math.Pow(this.d2.getY - this.d1.getY, 2));
            double AC = Math.Sqrt(Math.Pow(this.d3.getX - this.d1.getX, 2) + Math.Pow(this.d3.getY - this.d1.getY, 2));
            double BC = Math.Sqrt(Math.Pow(this.d3.getX - this.d2.getX, 2) + Math.Pow(this.d3.getY - this.d2.getY, 2));
            return (AB + AC) > BC && (AB + BC) > AC && (AC + BC) > AB;
        }
    }
}
