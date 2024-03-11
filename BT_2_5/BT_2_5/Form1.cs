using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_2_5
{
    public partial class Form1 : Form
    {
        private string restore = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string getChar = label1.Text.Substring(0,1);
            string getRest = label1.Text.Substring(1);
            string finalString = getRest + getChar;
            label1.Text = finalString;
        }

        private void chenBt_Click(object sender, EventArgs e)
        {
            try
            {
                change();
                int pos = int.Parse(chenTxt.Text);
                s1Txt.Text = s1Txt.Text.Insert(pos, s2Txt.Text);
            }
            catch(FormatException) 
            {
                MessageBox.Show("Lỗi định dạng");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Giá trị vượt quá giới hạn");
            }
        }

        private void replace_s2_s3Bt_Click(object sender, EventArgs e)
        {
            try
            {
                change();
                if (s1Txt.Text.Contains(s2Txt.Text))
                {
                    s1Txt.Text = s1Txt.Text.Replace(s2Txt.Text, s3Txt.Text);
                }
                else
                {
                    MessageBox.Show("s2 is not in s1");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi định dạng");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void delS2_Click(object sender, EventArgs e)
        {
            try
            {
                change();
                if (s1Txt.Text.Contains(s2Txt.Text))
                {
                    int start = s1Txt.Text.IndexOf(s2Txt.Text);
                    int end = s2Txt.Text.Length;
                    s1Txt.Text = s1Txt.Text.Remove(start, end);
                }
                else
                {
                    MessageBox.Show("s2 is not in s1");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Lỗi định dạng");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Giá trị vượt quá giới hạn");
            }
            catch(Exception) {
                MessageBox.Show("Error");
            }
        }

        private void reverseBt_Click(object sender, EventArgs e)
        {
            try
            {
                change();
                char[] token = { ' ', '\t', '\r', '\n' };
                string[] arr = s1Txt.Text.Split(token);
                string newStr = String.Empty;
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    newStr += arr[i] + " ";
                }
                s1Txt.Text = newStr.Trim();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi định dạng");
            }
        }

        private void normalizedBt_Click(object sender, EventArgs e)
        {
            try
            {
                change();
                s1Txt.Text.Trim();
                char[] token = { ' ' };
                string[] arr = s1Txt.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
                string newStr = String.Empty;
                foreach (string ele in arr)
                {
                    string first = ele.Substring(0, 1).ToUpper();
                    string second = ele.Substring(1).ToLower();
                    newStr += (first + second + " ");
                }
                s1Txt.Text = newStr.Trim();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi định dạng");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Giá trị vượt quá giới hạn");
            }
        }

        private void getSubStringBt_Click(object sender, EventArgs e)
        {
            try
            {
                change();
                int start = int.Parse(fromTxt.Text);
                int length = int.Parse(idxNumTxt.Text);
                MessageBox.Show("Chuỗi con là : " + s1Txt.Text.Substring(start, length));
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi định dạng");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Giá trị vượt quá giới hạn");
            }
        }
        private void change()
        {
            if (restore != String.Empty && restore == s1Txt.Text)
            {
                return;
            }
            else
            {
                restore = s1Txt.Text;
            }
        }

        private void refreshBt_Click(object sender, EventArgs e)
        {
            s1Txt.Text = restore;
        }
    }
}
