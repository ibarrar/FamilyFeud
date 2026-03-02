namespace FamilyFeud
{
    partial class frmFamilyFeud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbBoxQuestion = new System.Windows.Forms.ComboBox();
            this.FamilyFeudDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FamilyFeudDataSet = new FamilyFeud.FamilyFeudDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowScreen = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.timerValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTeam1Name = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTeam3Name = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblXXX3 = new System.Windows.Forms.Label();
            this.btnXforTeam3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTeam2Name = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.questionsTableAdapter = new FamilyFeud.FamilyFeudDataSetTableAdapters.QuestionsTableAdapter();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.XXXClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyFeudDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyFeudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBoxQuestion
            // 
            this.cmbBoxQuestion.DataSource = this.FamilyFeudDataSetBindingSource;
            this.cmbBoxQuestion.DisplayMember = "question";
            this.cmbBoxQuestion.FormattingEnabled = true;
            this.cmbBoxQuestion.Location = new System.Drawing.Point(53, 48);
            this.cmbBoxQuestion.Name = "cmbBoxQuestion";
            this.cmbBoxQuestion.Size = new System.Drawing.Size(247, 21);
            this.cmbBoxQuestion.TabIndex = 0;
            // 
            // FamilyFeudDataSetBindingSource
            // 
            this.FamilyFeudDataSetBindingSource.DataMember = "Questions";
            this.FamilyFeudDataSetBindingSource.DataSource = this.FamilyFeudDataSet;
            // 
            // FamilyFeudDataSet
            // 
            this.FamilyFeudDataSet.DataSetName = "FamilyFeudDataSet";
            this.FamilyFeudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*** Survey Question ***";
            // 
            // btnShowScreen
            // 
            this.btnShowScreen.Location = new System.Drawing.Point(139, 75);
            this.btnShowScreen.Name = "btnShowScreen";
            this.btnShowScreen.Size = new System.Drawing.Size(75, 23);
            this.btnShowScreen.TabIndex = 2;
            this.btnShowScreen.Text = "Show";
            this.btnShowScreen.UseVisualStyleBackColor = true;
            this.btnShowScreen.Click += new System.EventHandler(this.btnShowScreen_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Enabled = false;
            this.btnStartTimer.Location = new System.Drawing.Point(42, 220);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(74, 23);
            this.btnStartTimer.TabIndex = 5;
            this.btnStartTimer.Text = "Start Timer";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // timerValue
            // 
            this.timerValue.Enabled = false;
            this.timerValue.Location = new System.Drawing.Point(137, 221);
            this.timerValue.Name = "timerValue";
            this.timerValue.Size = new System.Drawing.Size(79, 20);
            this.timerValue.TabIndex = 6;
            this.timerValue.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTeam1Name);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtTeam1Name
            // 
            this.txtTeam1Name.Location = new System.Drawing.Point(4, 17);
            this.txtTeam1Name.Name = "txtTeam1Name";
            this.txtTeam1Name.Size = new System.Drawing.Size(100, 20);
            this.txtTeam1Name.TabIndex = 4;
            this.txtTeam1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(20, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Team 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(63, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Score:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTeam3Name);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(122, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 65);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // txtTeam3Name
            // 
            this.txtTeam3Name.Location = new System.Drawing.Point(4, 17);
            this.txtTeam3Name.Name = "txtTeam3Name";
            this.txtTeam3Name.Size = new System.Drawing.Size(100, 20);
            this.txtTeam3Name.TabIndex = 5;
            this.txtTeam3Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(24, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(62, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Team 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(58, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(36, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Score:";
            // 
            // lblXXX3
            // 
            this.lblXXX3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXXX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXXX3.ForeColor = System.Drawing.Color.Red;
            this.lblXXX3.Location = new System.Drawing.Point(129, 174);
            this.lblXXX3.Name = "lblXXX3";
            this.lblXXX3.Size = new System.Drawing.Size(94, 40);
            this.lblXXX3.TabIndex = 0;
            this.lblXXX3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXforTeam3
            // 
            this.btnXforTeam3.Enabled = false;
            this.btnXforTeam3.Location = new System.Drawing.Point(235, 183);
            this.btnXforTeam3.Name = "btnXforTeam3";
            this.btnXforTeam3.Size = new System.Drawing.Size(94, 23);
            this.btnXforTeam3.TabIndex = 3;
            this.btnXforTeam3.Text = "Wrong Answer";
            this.btnXforTeam3.UseVisualStyleBackColor = true;
            this.btnXforTeam3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTeam2Name);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(236, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(108, 65);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtTeam2Name
            // 
            this.txtTeam2Name.Location = new System.Drawing.Point(4, 17);
            this.txtTeam2Name.Name = "txtTeam2Name";
            this.txtTeam2Name.Size = new System.Drawing.Size(100, 20);
            this.txtTeam2Name.TabIndex = 5;
            this.txtTeam2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(19, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(62, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Team 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(59, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Score:";
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Enabled = false;
            this.btnStopTimer.Location = new System.Drawing.Point(235, 220);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(75, 23);
            this.btnStopTimer.TabIndex = 8;
            this.btnStopTimer.Text = "Stop Timer";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // XXXClear
            // 
            this.XXXClear.Enabled = false;
            this.XXXClear.Location = new System.Drawing.Point(22, 183);
            this.XXXClear.Name = "XXXClear";
            this.XXXClear.Size = new System.Drawing.Size(94, 23);
            this.XXXClear.TabIndex = 3;
            this.XXXClear.Text = "Clear Xs";
            this.XXXClear.UseVisualStyleBackColor = true;
            this.XXXClear.Click += new System.EventHandler(this.Clear_Xs_Click);
            // 
            // frmFamilyFeud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 254);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblXXX3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.XXXClear);
            this.Controls.Add(this.btnXforTeam3);
            this.Controls.Add(this.timerValue);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.btnShowScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxQuestion);
            this.Name = "frmFamilyFeud";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FamilyFeud AirlineOps Edition";
            this.Load += new System.EventHandler(this.frmFamilyFeud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FamilyFeudDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyFeudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowScreen;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.NumericUpDown timerValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXforTeam3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblXXX3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.BindingSource FamilyFeudDataSetBindingSource;
        private FamilyFeudDataSet FamilyFeudDataSet;
        private FamilyFeud.FamilyFeudDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Button XXXClear;
        private System.Windows.Forms.TextBox txtTeam1Name;
        private System.Windows.Forms.TextBox txtTeam3Name;
        private System.Windows.Forms.TextBox txtTeam2Name;
    }
}

