using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        TamGiac poly;
        Diem d1, d2, d3;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkPolyBt_Click(object sender, EventArgs e)
        {
            try
            {
                updatePoints();
                poly = new TamGiac(d1, d2, d3);
                if (poly.checkPolygon() == true)
                {
                    MessageBox.Show("Hợp lệ");
                }
                else
                {
                    MessageBox.Show("Không hợp lệ");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui long nhap so thuc");
            }
            catch (OverflowException)
            {
                MessageBox.Show("So qua lon hoac qua nho");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void checkBt_Click(object sender, EventArgs e)
        {
            try
            {
                updatePoints();
                Diem c = new Diem(double.Parse(c1txt.Text), double.Parse(c2txt.Text));
                if (poly == null)
                {
                    poly = new TamGiac(d1, d2, d3);
                }
                if (poly.checkPoint(c))
                {
                    MessageBox.Show("ĐIỂM C CÓ NẰM TRONG TAM GIÁC");
                }
                else
                {
                    MessageBox.Show("ĐIỂM C KHÔNG NẰM TRONG TAM GIÁC");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui long nhap so thuc");
            }
            catch (OverflowException)
            {
                MessageBox.Show("So qua lon hoac qua nho");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void updatePoints()
        {
            d1 = new Diem(double.Parse(x1txt.Text), double.Parse(y1txt.Text));
            d2 = new Diem(double.Parse(x2txt.Text), double.Parse(y2txt.Text));
            d3 = new Diem(double.Parse(x3txt.Text), double.Parse(y3txt.Text));
        }
    }
}
