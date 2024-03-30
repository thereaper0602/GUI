using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_2_6
{
    public partial class Form1 : Form
    {
        private int n;
        private int[] arr;
        private int[] even;
        private int[] odd;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(soPtTxt.Text);
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = rand.Next(0, 100);
                }
                OriginalTxt.Text = String.Join(",", arr);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi cú pháp");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Số quá lớn hoặc quá nhỏ");
            }
            catch(Exception) {
                MessageBox.Show("Lỗi");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int[] method = new int[n];
                arr.CopyTo(method, 0);
                // tang
                Array.Sort(method);
                increaseTxt.Text = String.Join(",", method);

                // giam
                Array.Reverse(method);
                decreaseTxt.Text = String.Join(",", method);

                // dao nguoc
                arr.CopyTo(method, 0);
                Array.Reverse(method);
                reverseTxt.Text = String.Join(",", method);

                // chan tang , le giam
                //
                //int sizeOdd = 0,sizeEven = 0;
                //for(int i = 0; i < n; i++)
                //{
                //    if (arr[i] % 2 != 0) sizeOdd++;
                //    else sizeEven++;
                //}
                //odd = new int[sizeOdd];
                //sizeOdd = 0;
                //even = new int[sizeEven];
                //sizeEven = 0;
                //for(int i = 0; i < n; i++)
                //{
                //    if (arr[i] % 2 != 0) odd[sizeOdd++] = arr[i];
                //    else even[sizeEven++] = arr[i];
                //}
                //Array.Sort(even);
                //Array.Sort(odd);Array.Reverse(odd);
                //int[] complete = new int[sizeOdd + sizeEven];
                //even.CopyTo(complete, 0);
                //odd.CopyTo(complete, even.Length);
                //oddEvenTxt.Text = String.Join(",", complete);

                var even = arr.Where(x => x % 2 == 0).OrderBy(x => x);
                var odd = arr.Where(x => x % 2 != 0).OrderByDescending(x => x);
                oddEvenTxt.Text = String.Join(",", even.Concat(odd));
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
