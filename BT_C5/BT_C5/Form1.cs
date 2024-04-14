using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BT_C5
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private Point OldPoint;
        private String[] files;
        Random rand = new Random();
        private int imgSize = 120;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Lưu vị trí ban đầu khi click chuột lên
            OldPoint = e.Location;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            files = Directory.GetFiles(Application.StartupPath + @"\Images\");
            AddNewImage();
        }

        private void AddNewImage()
        {
            count++;// mục đích để đặt tên cho các pictureBox
            PictureBox pic = new PictureBox();
            Image img = Image.FromFile(files[rand.Next(files.Length)]);
            pic.Image = img;
            pic.Name = count.ToString(); // đặt tên
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Width = pic.Height = imgSize;
            pic.MouseDown += Pic_MouseDown;// thêm sự kiện click chuột cho pictureBox
            pic.MouseMove += Pic_MouseMove;
            pic.MouseUp += Pic_MouseUp;
            pic.Location = new Point(0, 0);
            this.Controls.Add(pic);
            /* @method SetchildIndex : đặt chỉ số cho 1 control cụ thể nào đó 
             *                         để Controls.Count - 1 có nghĩa là để control đó thành 
             *                         phần tử cuối cùng .Điều đó có nghĩa là nó sẽ bị các 
             *                         control đè lên
             */
            this.Controls.SetChildIndex(pnBound, this.Controls.Count - 1);
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            /**
             * @ properties Bounds : trả về đối tượng là một Rectangle
             * 
             **/
            if (pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                AddNewImage();
            }
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                int dx = e.X - OldPoint.X;
                int dy = e.Y - OldPoint.Y;
                pic.Left += dx;
                pic.Top += dy;
            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            OldPoint = e.Location;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /** Control[] control : Tập hợp các control của form   
             * @ method thís.Controls.Find(String name,bool) : Tham số đầu tiên : tìm một hoặc nhiều
             *                                                 control phù hợp với tên tương ứng.
             *                                                 Tham số thứ 2 chỉ định có kiếm các subcontrol
             *                                                 của các control hay không . "false" là không
             *                                                              
            **/
            Control[] control = this.Controls.Find(count.ToString(), false);
            PictureBox pic = (PictureBox)control[0];
            switch (e.KeyData)
            {
                case Keys.Left:
                    {
                        if(pic.Left > 0)
                        {
                            pic.Left-=20;
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if (pic.Right <= ClientRectangle.Width)
                        {
                            pic.Left+=20;
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if (pic.Bottom <= ClientRectangle.Height)
                        {
                            pic.Top+=20;
                        }
                        break;
                    }
                case Keys.Up:
                    {
                        if (pic.Top > 0)
                        {
                            pic.Top-=20;
                        }
                        break;
                    }
            }
            if (pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                AddNewImage();
            }
        }
    }
}
