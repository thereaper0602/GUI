using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raceGame
{
    public partial class Form1 : Form
    {
        Random rand;
        private Point oldPoint1, oldPoint2, oldPoint3;
        private Stopwatch stopwatch;
        private Timer timer;
        private bool isMove;
        private const int tick = 1000;
        private const int V = 2000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == (Keys.Control | Keys.S)) {
                stopwatch.Start();
                timer.Start();
                timer1.Enabled = true;
            }
            else if(e.KeyData == (Keys.Control | Keys.P))
            {
                stopwatch.Stop();
                timer.Stop();
                timer1.Enabled = false;
            }
            else if(e.KeyData == (Keys.Control | Keys.R))
            {
                player1.Location = oldPoint1;
                player2.Location = oldPoint2;
                player3.Location = oldPoint3;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            oldPoint1 = player1.Location; oldPoint2 = player2.Location; oldPoint2 = player2.Location;
            timer = new Timer();
            timer.Interval = 10;
            this.KeyPreview = true;
            rand = new Random();
            isMove = timer1.Enabled;
        }

        private void Timer_Tick(object sender,EventArgs e)
        {
            second1.Text = $"{stopwatch.Elapsed.Seconds:D2}.{stopwatch.Elapsed.Milliseconds:D3}";
            second2.Text = $"{stopwatch.Elapsed.Seconds:D2}.{stopwatch.Elapsed.Milliseconds:D3}";
            second3.Text = $"{stopwatch.Elapsed.Seconds:D2}.{stopwatch.Elapsed.Milliseconds:D3}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int move1 = rand.Next(10, 16);
            int move2 = rand.Next(10, 16);
            int move3 = rand.Next(10, 16);
            player1.Left += move1;
            player2.Left += move2;
            player3.Left += move3;
            timer.Tick += Timer_Tick;
            if (player1.Right >= panel1.Width || player2.Right >= panel2.Width || player3.Right >= panel3.Width)
            {
                timer1.Enabled = false;
                stopwatch.Stop();
                timer.Stop();
                if (player1.Right >= panel1.Width)
                {
                    winnerLb.Text = "Player1 Win";
                }
                else if (player2.Right >= panel2.Width)
                {
                    winnerLb.Text = "Player2 Win";
                }
                else if (player3.Right >= panel3.Width)
                {
                    winnerLb.Text = "Player3 Win";
                }
            }
        }
    }
}
