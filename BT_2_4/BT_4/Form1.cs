using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BT_4
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        string[] ope = {"+","-","x","/"};
        int viTri;
        public void Create()
        {
            viTri = rd.Next(4);
            int num_1 = rd.Next(10);
            int num_2 = rd.Next(10);
            while(num_2 == 0 && viTri == 3)
            {
                num_2 = rd.Next(10);
            }
            lbNum_1.Text = num_1.ToString();
            lbNum_2.Text = num_2.ToString();
            opetxt.Text = ope[viTri];
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create();
            //resultTxt.Text = "";
            resultTxt.Focus();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Create();
            ketQuatxt.Text = "";
            resultTxt.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            resultTxt.Text += bt.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (resultTxt.Text == "") { return; }
            resultTxt.Text = resultTxt.Text.Substring(0, resultTxt.Text.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int res = int.Parse(resultTxt.Text);
                int num_1 = int.Parse(lbNum_1.Text);
                int num_2 = int.Parse(lbNum_2.Text);
                int ketQua = 0;
                switch (viTri)
                {
                    case 0:
                        {
                            ketQua = num_1 + num_2;
                            break;
                        }
                    case 1:
                        {
                            ketQua = num_1 - num_2;
                            break;
                        }
                    case 2:
                        {
                            ketQua = num_1 * num_2;
                            break;
                        }
                    case 3:
                        {
                            ketQua = num_1 / num_2;
                            break;
                        }
                }
                if (ketQua == res)
                {
                    ketQuatxt.Text = "Chính xác";
                }
                else
                {
                    ketQuatxt.Text = "Đáp án không phải là " + res.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}
