using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Myachik
{
    public partial class BallForm : Form
    {
        int direction = 1;
        const int step = 10;
        GraphicsPath myPath = new GraphicsPath();

        public BallForm()
        {
            InitializeComponent();
            tsmSpeed1.Click += new System.EventHandler(tsmSpeed_Click);
            tsmSpeed2.Click += new System.EventHandler(tsmSpeed_Click);
            tsmSpeed3.Click += new System.EventHandler(tsmSpeed_Click);
            tsmSpeed4.Click += new System.EventHandler(tsmSpeed_Click);
            tsmSpeed5.Click += new System.EventHandler(tsmSpeed_Click);
            tsmSpeedCrazy.Click += new System.EventHandler(tsmSpeed_Click);
            ball.Click += new System.EventHandler(this.startStopToolStripMenuItem_Click);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(timer.Enabled == false)
            {
                timer.Start();
                tsmStart_Stop.Text = "Start / &Stop";
            }
            else
            {
                timer.Stop();
                tsmStart_Stop.Text = "&Start / Stop";
            }
        }

        private void tsmSpeed_Click(object sender, EventArgs e)
        {
            var s = (ToolStripMenuItem)sender;
            tsmSpeed1.Checked = false;
            tsmSpeed2.Checked = false;
            tsmSpeed3.Checked = false;
            tsmSpeed4.Checked = false;
            tsmSpeed5.Checked = false;
            tsmSpeedCrazy.Checked = false;            
            s.Checked = true;
            if (tsmSpeedCrazy.Checked == true)
                ball.BackColor = Color.Red;
            else
                ball.BackColor = Color.Aqua;
            timer.Interval = Convert.ToInt32(s.Tag);            
        }

        private void timer_Tick(object sender, EventArgs e)
        {            
            switch (direction)
            {
                case 1:
                    if ( ball.Location.X < 20 )
                    {
                        Unsqueeze();
                        Move();
                    }
                    else if ( ball.Location.X < (this.ClientSize.Width - 55) ) // ball.Width не дает корректный результат, поэтому с цифрами                        
                    {
                        Move();                        
                    }
                    else if ( ball.Width > 20 )
                    {
                        Squeeze();
                        ball.Left = this.ClientSize.Width - ball.Width;                        
                    }                    
                    else
                    {
                        direction = -direction;
                        Unsqueeze();
                        Move();
                    }                    
                    break;
                case -1:
                    if ( ball.Location.X > (this.ClientSize.Width - 45) )
                    {
                        Unsqueeze();
                        Move();
                    }
                    else if ( ball.Location.X > 5 )
                    {
                        Move();
                    }
                    else if( ball.Width > 20 )
                    {
                        Squeeze();
                        ball.Left = 0;
                    }
                    else
                    {
                        direction = -direction;
                        Unsqueeze();
                    }                    
                    break;
            }            
        }       

        private void Squeeze()
        {
            ball.Width -= 10;
            ball.Height += 10;
            ball.Top -= 5;

            myPath.Reset();                      
            myPath.AddEllipse(0, 0, ball.Width, ball.Height);
            Region myRegion = new Region(myPath);
            ball.Region = myRegion;
        }

        private void Unsqueeze()
        {
            ball.Width += 10;
            ball.Height -= 10;
            ball.Top += 5;

            myPath.Reset();
            myPath.AddEllipse(0, 0, ball.Width, ball.Height);
            Region myRegion = new Region(myPath);
            ball.Region = myRegion;
        }

        private void Move()
        {
            ball.Left += step * direction;
        }

        private void BallForm_Load(object sender, EventArgs e)
        {                       
            myPath.AddEllipse(0, 0, ball.Width, ball.Height);            
            Region myRegion = new Region(myPath);
            ball.Region = myRegion;
        }
    }
}
