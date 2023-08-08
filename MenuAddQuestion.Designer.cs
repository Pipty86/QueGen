namespace QueGen
{
    partial class MenuAddQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAddQuestion));
            this.LabelPromptModule = new System.Windows.Forms.Label();
            this.LabelPromptLevel = new System.Windows.Forms.Label();
            this.LabelPromptSubject = new System.Windows.Forms.Label();
            this.LabelPromptMode = new System.Windows.Forms.Label();
            this.CB_Module = new System.Windows.Forms.ComboBox();
            this.CB_Subject = new System.Windows.Forms.ComboBox();
            this.CB_Mode = new System.Windows.Forms.ComboBox();
            this.CB_Level = new System.Windows.Forms.ComboBox();
            this.LabelPromptMarks = new System.Windows.Forms.Label();
            this.CB_Mark = new System.Windows.Forms.TextBox();
            this.LabelPromptQuestion = new System.Windows.Forms.Label();
            this.CB_Question = new System.Windows.Forms.TextBox();
            this.LabelPromptAnswer = new System.Windows.Forms.Label();
            this.CB_Answer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelPromptModule
            // 
            this.LabelPromptModule.AutoSize = true;
            this.LabelPromptModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptModule.Location = new System.Drawing.Point(12, 23);
            this.LabelPromptModule.Name = "LabelPromptModule";
            this.LabelPromptModule.Size = new System.Drawing.Size(80, 24);
            this.LabelPromptModule.TabIndex = 0;
            this.LabelPromptModule.Text = "Module";
            // 
            // LabelPromptLevel
            // 
            this.LabelPromptLevel.AutoSize = true;
            this.LabelPromptLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptLevel.Location = new System.Drawing.Point(474, 119);
            this.LabelPromptLevel.Name = "LabelPromptLevel";
            this.LabelPromptLevel.Size = new System.Drawing.Size(60, 24);
            this.LabelPromptLevel.TabIndex = 1;
            this.LabelPromptLevel.Text = "Level";
            // 
            // LabelPromptSubject
            // 
            this.LabelPromptSubject.AutoSize = true;
            this.LabelPromptSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptSubject.Location = new System.Drawing.Point(12, 71);
            this.LabelPromptSubject.Name = "LabelPromptSubject";
            this.LabelPromptSubject.Size = new System.Drawing.Size(80, 24);
            this.LabelPromptSubject.TabIndex = 1;
            this.LabelPromptSubject.Text = "Subject";
            // 
            // LabelPromptMode
            // 
            this.LabelPromptMode.AutoSize = true;
            this.LabelPromptMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptMode.Location = new System.Drawing.Point(12, 119);
            this.LabelPromptMode.Name = "LabelPromptMode";
            this.LabelPromptMode.Size = new System.Drawing.Size(63, 24);
            this.LabelPromptMode.TabIndex = 1;
            this.LabelPromptMode.Text = "Mode";
            // 
            // CB_Module
            // 
            this.CB_Module.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Module.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Module.FormattingEnabled = true;
            this.CB_Module.Location = new System.Drawing.Point(98, 19);
            this.CB_Module.Name = "CB_Module";
            this.CB_Module.Size = new System.Drawing.Size(954, 32);
            this.CB_Module.TabIndex = 2;
            this.CB_Module.SelectedIndexChanged += new System.EventHandler(this.CB_Module_SelectedIndexChanged);
            // 
            // CB_Subject
            // 
            this.CB_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Subject.FormattingEnabled = true;
            this.CB_Subject.Location = new System.Drawing.Point(98, 68);
            this.CB_Subject.Name = "CB_Subject";
            this.CB_Subject.Size = new System.Drawing.Size(954, 32);
            this.CB_Subject.TabIndex = 3;
            this.CB_Subject.SelectedIndexChanged += new System.EventHandler(this.CB_Subject_SelectedIndexChanged);
            // 
            // CB_Mode
            // 
            this.CB_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Mode.FormattingEnabled = true;
            this.CB_Mode.Items.AddRange(new object[] {
            "Multiple Choice Questions",
            "Subjective",
            "Oral",
            "True/False"});
            this.CB_Mode.Location = new System.Drawing.Point(98, 116);
            this.CB_Mode.Name = "CB_Mode";
            this.CB_Mode.Size = new System.Drawing.Size(323, 32);
            this.CB_Mode.TabIndex = 3;
            this.CB_Mode.SelectedIndexChanged += new System.EventHandler(this.CB_Mode_SelectedIndexChanged);
            // 
            // CB_Level
            // 
            this.CB_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Level.FormattingEnabled = true;
            this.CB_Level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CB_Level.Location = new System.Drawing.Point(540, 116);
            this.CB_Level.Name = "CB_Level";
            this.CB_Level.Size = new System.Drawing.Size(187, 32);
            this.CB_Level.TabIndex = 4;
            this.CB_Level.SelectedIndexChanged += new System.EventHandler(this.CB_Level_SelectedIndexChanged);
            // 
            // LabelPromptMarks
            // 
            this.LabelPromptMarks.AutoSize = true;
            this.LabelPromptMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptMarks.Location = new System.Drawing.Point(809, 119);
            this.LabelPromptMarks.Name = "LabelPromptMarks";
            this.LabelPromptMarks.Size = new System.Drawing.Size(65, 24);
            this.LabelPromptMarks.TabIndex = 5;
            this.LabelPromptMarks.Text = "Marks";
            // 
            // CB_Mark
            // 
            this.CB_Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Mark.Location = new System.Drawing.Point(875, 116);
            this.CB_Mark.Name = "CB_Mark";
            this.CB_Mark.Size = new System.Drawing.Size(177, 29);
            this.CB_Mark.TabIndex = 6;
            this.CB_Mark.TextChanged += new System.EventHandler(this.CB_Mark_TextChanged);
            // 
            // LabelPromptQuestion
            // 
            this.LabelPromptQuestion.AutoSize = true;
            this.LabelPromptQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptQuestion.Location = new System.Drawing.Point(12, 178);
            this.LabelPromptQuestion.Name = "LabelPromptQuestion";
            this.LabelPromptQuestion.Size = new System.Drawing.Size(94, 24);
            this.LabelPromptQuestion.TabIndex = 7;
            this.LabelPromptQuestion.Text = "Question";
            // 
            // CB_Question
            // 
            this.CB_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Question.Location = new System.Drawing.Point(16, 205);
            this.CB_Question.Multiline = true;
            this.CB_Question.Name = "CB_Question";
            this.CB_Question.Size = new System.Drawing.Size(1036, 250);
            this.CB_Question.TabIndex = 8;
            this.CB_Question.TextChanged += new System.EventHandler(this.CB_Question_TextChanged);
            // 
            // LabelPromptAnswer
            // 
            this.LabelPromptAnswer.AutoSize = true;
            this.LabelPromptAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptAnswer.Location = new System.Drawing.Point(12, 482);
            this.LabelPromptAnswer.Name = "LabelPromptAnswer";
            this.LabelPromptAnswer.Size = new System.Drawing.Size(80, 24);
            this.LabelPromptAnswer.TabIndex = 7;
            this.LabelPromptAnswer.Text = "Answer";
            // 
            // CB_Answer
            // 
            this.CB_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Answer.Location = new System.Drawing.Point(16, 509);
            this.CB_Answer.Multiline = true;
            this.CB_Answer.Name = "CB_Answer";
            this.CB_Answer.Size = new System.Drawing.Size(1036, 142);
            this.CB_Answer.TabIndex = 8;
            this.CB_Answer.TextChanged += new System.EventHandler(this.CB_Answer_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(950, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(813, 684);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "VIEW";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(16, 684);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1064, 731);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CB_Answer);
            this.Controls.Add(this.CB_Question);
            this.Controls.Add(this.LabelPromptAnswer);
            this.Controls.Add(this.LabelPromptQuestion);
            this.Controls.Add(this.CB_Mark);
            this.Controls.Add(this.LabelPromptMarks);
            this.Controls.Add(this.CB_Level);
            this.Controls.Add(this.CB_Mode);
            this.Controls.Add(this.CB_Subject);
            this.Controls.Add(this.CB_Module);
            this.Controls.Add(this.LabelPromptSubject);
            this.Controls.Add(this.LabelPromptMode);
            this.Controls.Add(this.LabelPromptLevel);
            this.Controls.Add(this.LabelPromptModule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAddQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueGen - Add Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPromptModule;
        private System.Windows.Forms.Label LabelPromptLevel;
        private System.Windows.Forms.Label LabelPromptSubject;
        private System.Windows.Forms.Label LabelPromptMode;
        private System.Windows.Forms.ComboBox CB_Module;
        private System.Windows.Forms.ComboBox CB_Subject;
        private System.Windows.Forms.ComboBox CB_Mode;
        private System.Windows.Forms.ComboBox CB_Level;
        private System.Windows.Forms.Label LabelPromptMarks;
        private System.Windows.Forms.TextBox CB_Mark;
        private System.Windows.Forms.Label LabelPromptQuestion;
        private System.Windows.Forms.TextBox CB_Question;
        private System.Windows.Forms.Label LabelPromptAnswer;
        private System.Windows.Forms.TextBox CB_Answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}