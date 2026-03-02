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
    public partial class frmAnswers : Form
    {
        public frmAnswers()
        {           
            InitializeComponent();
        }
        public string QuestionString
        {
            set
            {               
                this.label1.Text = value;
                this.Text = value;
                repaintGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FamilyFeud.Program.FamilyFeud.disableControls();
            FamilyFeud.Program.FamilyFeud.gameDisplay.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           if (dataGridView1.Columns[e.ColumnIndex].Name == "reveal") //check if the click is in the correct column
           {
               FamilyFeud.Program.FamilyFeud.cs.PlayAMp3("revealanswer.wav");
              //Object selectedItem= dataGridView1.Rows[e.RowIndex].DataBoundItem; //get the data bound item
              //MessageBox.Show(item.ToString()); //(optional) show a message to show we pressed the button for that item
               revealHandler(e.RowIndex);
               FamilyFeud.Program.FamilyFeud.gameDisplay.updateScore();
           }

        }

        private void frmAnswers_Load(object sender, EventArgs e)
        {
            //repaintGrid();
        }

        private void frmAnswers_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            FamilyFeud.Program.FamilyFeud.disableControls();
            FamilyFeud.Program.FamilyFeud.gameDisplay.Hide();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            repaintGrid();
        }

        private void repaintGrid()
        {
            try
            {
                this.answerTableAdapter.Fill(FamilyFeudDataSet.Answer, this.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            if (FamilyFeud.Program.FamilyFeud.gameDisplay == null)
            {
                return;
            }
            ClearGrid();

            for (int i = 0; i < this.dataGridView1.RowCount && i < 10; i++)
            {
                DataGridViewRow row = this.dataGridView1.Rows[i];                
                if (row.IsNewRow)
                {
                    continue;
                }

                switch (i)
                {
                    case 0:
                        FamilyFeud.Program.FamilyFeud.gameDisplay.Answer1 = "X";                       
                        break;
                    case 1:
                        FamilyFeud.Program.FamilyFeud.gameDisplay.Answer2 = "X";
                        break;
                    case 2:
                        FamilyFeud.Program.FamilyFeud.gameDisplay.Answer3 = "X";
                        break;
                    case 3:
                        FamilyFeud.Program.FamilyFeud.gameDisplay.Answer4 = "X";
                        break;
                    case 4:
                        FamilyFeud.Program.FamilyFeud.gameDisplay.Answer5 = "X";
                        break;
                    case 5:
                        FamilyFeud.Program.FamilyFeud.gameDisplay.Answer6 = "X";
                        break;
                    case 6:
                        FamilyFeud.Program.FamilyFeud.gameDisplay.Answer7 = "X";
                        break;
                    case 7:
                        FamilyFeud.Program.FamilyFeud.gameDisplay.Answer8 = "X";
                        break;
                    case 8:
                        FamilyFeud.Program.FamilyFeud.gameDisplay.Answer9 = "X";
                        break;
                    case 9:
                        FamilyFeud.Program.FamilyFeud.gameDisplay.Answer10 = "X";
                        break;
                    default:
                        break;
                }
            }
        }

        private void revealHandler(int index)
        {
            DataGridViewRow row = this.dataGridView1.Rows[index];
            if (row.IsNewRow)
            {
                return;
            }

            switch (index)
            {
                case 0:
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Answer1 = row.Cells[1].Value.ToString();
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Count1 = row.Cells[2].Value.ToString();
                    break;
                case 1:
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Answer2 = row.Cells[1].Value.ToString();
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Count2 = row.Cells[2].Value.ToString();
                    break;
                case 2:
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Answer3 = row.Cells[1].Value.ToString();
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Count3 = row.Cells[2].Value.ToString();
                    break;
                case 3:
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Answer4 = row.Cells[1].Value.ToString();
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Count4 = row.Cells[2].Value.ToString();
                    break;
                case 4:
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Answer5 = row.Cells[1].Value.ToString();
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Count5 = row.Cells[2].Value.ToString();
                    break;
                case 5:
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Answer6 = row.Cells[1].Value.ToString();
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Count6 = row.Cells[2].Value.ToString();
                    break;
                case 6:
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Answer7 = row.Cells[1].Value.ToString();
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Count7 = row.Cells[2].Value.ToString();
                    break;
                case 7:
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Answer8 = row.Cells[1].Value.ToString();
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Count8 = row.Cells[2].Value.ToString();
                    break;
                case 8:
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Answer9 = row.Cells[1].Value.ToString();
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Count9 = row.Cells[2].Value.ToString();
                    break;
                case 9:
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Answer10 = row.Cells[1].Value.ToString();
                    FamilyFeud.Program.FamilyFeud.gameDisplay.Count10 = row.Cells[2].Value.ToString();
                    break;
                default:
                    break;
            }            
        }

        private void ClearGrid()
        {
            if (FamilyFeud.Program.FamilyFeud.gameDisplay != null)
            {
                // Clear answers and count
                FamilyFeud.Program.FamilyFeud.gameDisplay.Answer1 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Answer2 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Answer3 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Answer4 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Answer5 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Answer6 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Answer7 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Answer8 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Answer9 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Answer10 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Count1 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Count2 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Count3 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Count4 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Count5 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Count6 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Count7 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Count8 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Count9 = "";
                FamilyFeud.Program.FamilyFeud.gameDisplay.Count10 = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.FamilyFeudDataSetBindingSource.EndEdit();
                this.answerTableAdapter.Adapter.Update(this.FamilyFeudDataSet.Answer);
            }
            catch( Exception ex)
            {
                MessageBox.Show("Save Failed!" + ex.Message);
            }
        }

    }
}
