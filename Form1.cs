using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DimGray;
            startGame();
        }

        int color = 0; //0 - pink, 1 - cyan, 2 - yellow, 3 - magenta
        int colorp = 0; //0 - pink, 1 - cyan, 2 - yellow, 3 - magenta
        bool started = false;
        bool falls = true;
        bool jump = false;
        int ypos = 200;

        private void startGame()
        {
            panel1.Location = new Point(90, ypos);
            Random rand = new Random();
            colorp = rand.Next(0, 4);
            if (colorp == 3)
            {
                panel1.BackColor = Color.Magenta;
            }
            else if (colorp == 2)
            {
                panel1.BackColor = Color.Yellow;
            }
            else if (colorp == 1)
            {
                panel1.BackColor = Color.Cyan;
            }
            else if (colorp == 0)
            {
                panel1.BackColor = Color.Pink;
            }

            panel1.Location = new Point(90, ypos + 30);
            pbBall.Location = new Point(128, 382);

            Random rdm = new Random();
            color = rdm.Next(0, 4);
            if(color > 0) { color = color - 1; }
            if(color == 0)
            {
                pbBall.BackColor = Color.Pink;
            }
            else if(color == 1)
            {
                pbBall.BackColor = Color.Cyan;
            }
            else if(color == 2)
            {
                pbBall.BackColor = Color.Yellow;
            }
            else if(color == 3)
            {
                pbBall.BackColor = Color.Magenta;
            }

            timerMove.Start();
            timerHit.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        Point speed = new Point(0, 0);
        Point panelSpeed = new Point(1, 0);

        private void timerMove_Tick(object sender, EventArgs e)
        {
            if(started)
            {
                if (jump)
                {
                    speed.Y = -13;
                    jump = false;
                }

                speed.Y += 1;

                if (panel1.Location.X + panel1.Width > 285)
                {
                    panelSpeed.X *= -1;
                }
                else if(panel1.Location.X < 0)
                {
                    panelSpeed.X *= -1;
                }

                panel1.Location = new Point(panel1.Location.X + panelSpeed.X, panel1.Location.Y + panelSpeed.Y);
                pbBall.Location = new Point(pbBall.Location.X + speed.X, pbBall.Location.Y + speed.Y);

                if(pbBall.Location.Y >= 500)
                {
                    timerMove.Stop();   
                    gameOver();
                }
              
                if(pbBall.Location.X <= panel1.Location.X - panel1.Width)
                {
                    timerMove.Stop();
                    gameOver();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                started = true;
                falls = false;
                jump = true;
                timerMove.Start();
            }

            if(e.KeyCode == Keys.R)
            {
                restart();
                jump = false;        
                falls = false;
            }
        }

        private void gameOver()
        {
            pbBall.Location = new Point(130, 400);
            MessageBox.Show("Verloren");
        }

        public void restart()
        {
            falls = false;
            pbBall.Location = new Point(130, 400);
            startGame();
        }

        private void timerHit_Tick(object sender, EventArgs e)
        {
            Rectangle panel = this.panel1.ClientRectangle;
            panel.Offset(this.panel1.Location);
            Rectangle ball = this.pbBall.ClientRectangle;
            ball.Offset(this.pbBall.Location);

            if (ball.IntersectsWith(panel))
            {
                if(color == colorp)
                {

                }
                else
                {
                    timerMove.Stop();
                    gameOver();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
