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
    public partial class frmFamilyFeud : Form
    {
        public frmAnswers answers;
        public GameDisplay gameDisplay;
        public csSound cs;
        public int seconds = 0;


        /* Properties */
        public int TimerValue
        {
            get { return (int) timerValue.Value; }
        }
        

        public frmFamilyFeud()
        {
            InitializeComponent();
            cs = new csSound();
            //cs.PlayAMp3("familyfeud76.mp3");            
        }

        public void enableControls()
        {
            this.cmbBoxQuestion.Enabled = false;
            this.btnShowScreen.Enabled = false;
            this.checkBox1.Enabled = true;
            this.checkBox2.Enabled = true;
            this.checkBox3.Enabled = true;
            this.btnStartTimer.Enabled = true;
            this.timerValue.Enabled = true;
            this.btnStopTimer.Enabled = true;
            //if (checkBox1.Checked)
            //{
            //    this.txtTeam1Name.ReadOnly = false;
            //}
            //if (checkBox2.Checked)
            //{
            //    this.txtTeam2Name.ReadOnly = false;
            //}
            //if (checkBox3.Checked)
            //{
            //    this.txtTeam3Name.ReadOnly = false;
            //}
            this.btnXforTeam3.Enabled = true;
            this.XXXClear.Enabled = true;
        }

        public void disableControls()
        {
            this.cmbBoxQuestion.Enabled = true;
            this.btnShowScreen.Enabled = true;
            this.checkBox1.Enabled = false;
            this.checkBox2.Enabled = false;
            this.checkBox3.Enabled = false;
            this.btnStartTimer.Enabled = false;
            this.btnStopTimer.Enabled = false;
            this.timerValue.Enabled = false;
            //this.txtTeam1Name.ReadOnly = true;
            //this.txtTeam2Name.ReadOnly = true;
            //this.txtTeam3Name.ReadOnly = true;
        }

        private void btnShowScreen_Click(object sender, EventArgs e)
        {
            if (answers == null)
            {
                answers = new frmAnswers();
            }
            enableControls();
            if (cmbBoxQuestion.Items.Count != 0)
            {
                answers.QuestionString = cmbBoxQuestion.Text;
            }
            else if (cmbBoxQuestion.Text != string.Empty)
            {
                answers.QuestionString = "New <" +cmbBoxQuestion.Text + "> New";
            }
            else
            {
                answers.QuestionString = "Survey Question Sample...";
            }

            if (gameDisplay == null)
            {
                gameDisplay = new GameDisplay(answers.Text);
            }
            gameDisplay.QuestionString = answers.Text;

            gameDisplay.Show();
            answers.Show();
            //cs.PlayAMp3("familyfeud76.mp3");
        }

        private void frmFamilyFeud_Load(object sender, EventArgs e)
        {
            // Check for Database connection
            try
            {
                // TODO: This line of code loads data into the 'FamilyFeudDataSet.Questions' table. You can move, or remove it, as needed.
                this.questionsTableAdapter.Fill(this.FamilyFeudDataSet.Questions);
                // TODO: This line of code loads data into the 'FamilyFeudDataSet1.Questions' table. You can move, or remove it, as needed.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : \n" + ex.Message + "\nFamilyFeud Database may not exist.\nPlease check server status...");
            }                           

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (gameDisplay != null)
            {
                gameDisplay.startTimer();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.textBox1.Enabled = true;
                this.txtTeam1Name.Enabled = true;
            }
            else
            {
                this.textBox1.Enabled = false;
                this.txtTeam1Name.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.textBox2.Enabled = true;
                this.txtTeam2Name.Enabled = true;
            }
            else
            {                
                this.textBox2.Enabled = false;
                this.txtTeam2Name.Enabled = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                this.textBox3.Enabled = true;
                this.txtTeam3Name.Enabled = true;

            }
            else
            {             
                this.textBox3.Enabled = false;
                this.txtTeam3Name.Enabled = false;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (gameDisplay != null)
        //    {

        //        if (this.lblXXX1.Text == "X X X ")
        //        {
        //            this.lblXXX1.Text = string.Empty;
        //        }
        //        else
        //        {
        //            cs.PlayAMp3("ff-strike.mp3");
        //            this.lblXXX1.Text += "X ";
        //        }
        //        gameDisplay.displayX(this.lblXXX1.Text);
                
        //    }

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (gameDisplay != null)
        //    {

        //        if (this.lblXXX2.Text == "X X X ")
        //        {
        //            this.lblXXX2.Text = string.Empty;
        //        }
        //        else
        //        {
        //            cs.PlayAMp3("ff-strike.mp3");
        //            this.lblXXX2.Text += "X ";
        //        }
        //        gameDisplay.displayX(this.lblXXX2.Text);
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            if (gameDisplay != null)
            {
                if (this.lblXXX3.Text == "X X X ")
                {
                    this.lblXXX3.Text = string.Empty;
                }
                else
                {
                    cs.PlayAMp3("ff-strike.mp3");
                    this.lblXXX3.Text += "X ";
                }
                gameDisplay.displayX(this.lblXXX3.Text);
            }
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            if (gameDisplay != null)
            {
                gameDisplay.stopTimer();
            }
        }

        private void Clear_Xs_Click(object sender, EventArgs e)
        {
            this.lblXXX3.Text = string.Empty;
            gameDisplay.displayX(this.lblXXX3.Text);
        }
    }
}
