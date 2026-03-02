using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FamilyFeud
{
    public partial class GameDisplay : Form
    {
        const string EXES_VALUE = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        public int seconds;

        public string QuestionString
        {
            set
            {
                this.Text = value;
                this.txtGameQuestion.Text = value;
                updateScore();
            }
        }

        public string Answer1
        {
            set 
            {
                if (value == "X")
                {
                    this.answers1.Text = EXES_VALUE;
                }
                else
                {
                    this.answers1.Text = value;
                }
            }
        }
        public string Answer2
        {
            set
            {
                if (value == "X")
                {
                    this.answers2.Text = EXES_VALUE;
                }
                else
                {
                    this.answers2.Text = value;
                }
            }
        }
        public string Answer3
        {
            set
            {
                if (value == "X")
                {
                    this.answers3.Text = EXES_VALUE;
                }
                else
                {
                    this.answers3.Text = value;
                }
            }
        }
        public string Answer4
        {
            set
            {
                if (value == "X")
                {
                    this.answers4.Text = EXES_VALUE;
                }
                else
                {
                    this.answers4.Text = value;
                }
            }
        }
        public string Answer5
        {
            set
            {
                if (value == "X")
                {
                    this.answers5.Text = EXES_VALUE;
                }
                else
                {
                    this.answers5.Text = value;
                }
            }
        }
        public string Answer6
        {
            set
            {
                if (value == "X")
                {
                    this.answers6.Text = EXES_VALUE;
                }
                else
                {
                    this.answers6.Text = value;
                }
            }
        }
        public string Answer7
        {
            set
            {
                if (value == "X")
                {
                    this.answers7.Text = EXES_VALUE;
                }
                else
                {
                    this.answers7.Text = value;
                }
            }
        }
        public string Answer8
        {
            set
            {
                if (value == "X")
                {
                    this.answers8.Text = EXES_VALUE;
                }
                else
                {
                    this.answers8.Text = value;
                }
            }
        }
        public string Answer9
        {
            set
            {
                if (value == "X")
                {
                    this.answers9.Text = EXES_VALUE;
                }
                else
                {
                    this.answers9.Text = value;
                }
            }
        }
        public string Answer10
        {
            set
            {
                if (value == "X")
                {
                    this.answers10.Text = EXES_VALUE;
                }
                else
                {
                    this.answers10.Text = value;
                }
            }
        }

        public string Count1
        {
            set { this.count1.Text = value; }
        }
        public string Count2
        {
            set { this.count2.Text = value; }
        }
        public string Count3
        {
            set { this.count3.Text = value; }
        }
        public string Count4
        {
            set { this.count4.Text = value; }
        }
        public string Count5
        {
            set { this.count5.Text = value; }
        }
        public string Count6
        {
            set { this.count6.Text = value; }
        }
        public string Count7
        {
            set { this.count7.Text = value; }
        }
        public string Count8
        {
            set { this.count8.Text = value; }
        }
        public string Count9
        {
            set { this.count9.Text = value; }
        }
        public string Count10
        {
            set { this.count10.Text = value; }
        }

        public GameDisplay(string question)
        {
            InitializeComponent();
            this.txtGameQuestion.Text = question;
            this.timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                FamilyFeud.Program.FamilyFeud.cs.PlayAMp3("ff-bell.mp3");
                this.lblTimer.Text = string.Format("{0}", seconds);  
                seconds -= 1;             
            }
            else
            {
                FamilyFeud.Program.FamilyFeud.cs.PlayAMp3("ff-ndansr.mp3");
                this.lblTimer.Text = "XX";
                this.timer1.Stop();
            }
        }

        public void startTimer()
        {
            seconds = FamilyFeud.Program.FamilyFeud.TimerValue;
            this.timer1.Start();
        }

        public void stopTimer()
        {
            this.timer1.Stop();
        }


        public void displayX(string x)
        {
            this.label52.Text = x;
        }

        public void updateScore()
        {
            int score = 0;
            if (!string.IsNullOrEmpty(count1.Text))
                    score = int.Parse(count1.Text);
            if (!string.IsNullOrEmpty(count2.Text))
                    score += int.Parse(count2.Text);
            if (!string.IsNullOrEmpty(count3.Text))
                score += int.Parse(count3.Text);
            if (!string.IsNullOrEmpty(count4.Text))
                score += int.Parse(count4.Text);
            if (!string.IsNullOrEmpty(count5.Text))
                score += int.Parse(count5.Text);
            if (!string.IsNullOrEmpty(count6.Text))
                score += int.Parse(count6.Text);
            if (!string.IsNullOrEmpty(count7.Text))
                score += int.Parse(count7.Text);
            if (!string.IsNullOrEmpty(count8.Text))
                score += int.Parse(count8.Text);
            if (!string.IsNullOrEmpty(count9.Text))
                score += int.Parse(count9.Text);
            if (!string.IsNullOrEmpty(count10.Text))
                score += int.Parse(count10.Text);

            this.score.Text = score.ToString();
        }

        private void GameDisplay_Load(object sender, EventArgs e)
        {

        }



        private void GameDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
