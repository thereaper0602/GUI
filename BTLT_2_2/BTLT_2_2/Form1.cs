using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLT_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double[] Solve(int a,int b,int c)
        {
            int delta = (b * b) - 4 * a * c;
            if(delta < 0)
            {
                return null;
            }
            double sqrtDelta = Math.Sqrt(delta);
            if(delta == 0) {
                return new double[] { -b / (2.0 * a) };
            }
            else
            {
                return new double[] {
                    (-b + sqrtDelta) / (2 * a),
                    (-b - sqrtDelta) / (2 * a)
                };
            }
        }

        private void solveBt_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int a = int.Parse(aTxt.Text);
            //    int b = int.Parse(bTxt.Text);
            //    int c = int.Parse(cTxt.Text);
            //    var Solution = Solve(a, b, c);
            //    if (Solve(a,b,c).Length == 2)
            //    {
            //        ketQualb.Text = $"x1 = {Solution[0]}\nx2 = {Solve(a, b, c)[1]}";
            //    }
            //    else if(Solution.Length == 1)
            //    {
            //        ketQualb.Text = $"x1 = x2 = {Solution[0]}";
            //    }
            //    else if(Solution == null)
            //    {
            //        ketQualb.Text = "Phương trình vô nghiệm";
            //    }
            //}
            //catch (FormatException){
            //    MessageBox.Show("Vui lòng nhập đủ số cho cả 3 giá trị");
            //}
            //catch (OverflowException)
            //{
            //    MessageBox.Show("Các giá trị quá lớn hoặc quá bé");
            //}
            TextBox textBox1 = new TextBox();

            
        }

        private void CloseBt_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thóat chương trình","Đóng",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = String.Format("{0} : {1:00} : {2:00}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
    }
}
