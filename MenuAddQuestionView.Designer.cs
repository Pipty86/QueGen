namespace QueGen
{
    partial class MenuAddQuestionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAddQuestionView));
            this.LabelPromptSubject = new System.Windows.Forms.Label();
            this.LabelPromptMode = new System.Windows.Forms.Label();
            this.CB_Subject = new System.Windows.Forms.ComboBox();
            this.CB_Mode = new System.Windows.Forms.ComboBox();
            this.LabelPromptLevel = new System.Windows.Forms.Label();
            this.CB_Level = new System.Windows.Forms.ComboBox();
            this.LabelPromptQuestion = new System.Windows.Forms.Label();
            this.CB_Question = new System.Windows.Forms.TextBox();
            this.CB_Module = new System.Windows.Forms.ComboBox();
            this.LabelPromptModule = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelPromptSubject
            // 
            this.LabelPromptSubject.AutoSize = true;
            this.LabelPromptSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptSubject.Location = new System.Drawing.Point(12, 61);
            this.LabelPromptSubject.Name = "LabelPromptSubject";
            this.LabelPromptSubject.Size = new System.Drawing.Size(80, 24);
            this.LabelPromptSubject.TabIndex = 2;
            this.LabelPromptSubject.Text = "Subject";
            // 
            // LabelPromptMode
            // 
            this.LabelPromptMode.AutoSize = true;
            this.LabelPromptMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptMode.Location = new System.Drawing.Point(29, 107);
            this.LabelPromptMode.Name = "LabelPromptMode";
            this.LabelPromptMode.Size = new System.Drawing.Size(63, 24);
            this.LabelPromptMode.TabIndex = 3;
            this.LabelPromptMode.Text = "Mode";
            // 
            // CB_Subject
            // 
            this.CB_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Subject.FormattingEnabled = true;
            this.CB_Subject.Location = new System.Drawing.Point(98, 58);
            this.CB_Subject.Name = "CB_Subject";
            this.CB_Subject.Size = new System.Drawing.Size(954, 32);
            this.CB_Subject.TabIndex = 4;
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
            this.CB_Mode.Location = new System.Drawing.Point(98, 104);
            this.CB_Mode.Name = "CB_Mode";
            this.CB_Mode.Size = new System.Drawing.Size(323, 32);
            this.CB_Mode.TabIndex = 5;
            this.CB_Mode.SelectedIndexChanged += new System.EventHandler(this.CB_Mode_SelectedIndexChanged);
            // 
            // LabelPromptLevel
            // 
            this.LabelPromptLevel.AutoSize = true;
            this.LabelPromptLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptLevel.Location = new System.Drawing.Point(480, 107);
            this.LabelPromptLevel.Name = "LabelPromptLevel";
            this.LabelPromptLevel.Size = new System.Drawing.Size(60, 24);
            this.LabelPromptLevel.TabIndex = 6;
            this.LabelPromptLevel.Text = "Level";
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
            this.CB_Level.Location = new System.Drawing.Point(546, 104);
            this.CB_Level.Name = "CB_Level";
            this.CB_Level.Size = new System.Drawing.Size(187, 32);
            this.CB_Level.TabIndex = 7;
            this.CB_Level.SelectedIndexChanged += new System.EventHandler(this.CB_Level_SelectedIndexChanged);
            // 
            // LabelPromptQuestion
            // 
            this.LabelPromptQuestion.AutoSize = true;
            this.LabelPromptQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptQuestion.Location = new System.Drawing.Point(12, 139);
            this.LabelPromptQuestion.Name = "LabelPromptQuestion";
            this.LabelPromptQuestion.Size = new System.Drawing.Size(94, 24);
            this.LabelPromptQuestion.TabIndex = 8;
            this.LabelPromptQuestion.Text = "Question";
            // 
            // CB_Question
            // 
            this.CB_Question.AcceptsReturn = true;
            this.CB_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Question.Location = new System.Drawing.Point(16, 166);
            this.CB_Question.Multiline = true;
            this.CB_Question.Name = "CB_Question";
            this.CB_Question.Size = new System.Drawing.Size(928, 440);
            this.CB_Question.TabIndex = 9;
            this.CB_Question.TextChanged += new System.EventHandler(this.CB_Question_TextChanged);
            // 
            // CB_Module
            // 
            this.CB_Module.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Module.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Module.FormattingEnabled = true;
            this.CB_Module.Location = new System.Drawing.Point(98, 12);
            this.CB_Module.Name = "CB_Module";
            this.CB_Module.Size = new System.Drawing.Size(954, 32);
            this.CB_Module.TabIndex = 12;
            this.CB_Module.SelectedIndexChanged += new System.EventHandler(this.CB_Module_SelectedIndexChanged);
            // 
            // LabelPromptModule
            // 
            this.LabelPromptModule.AutoSize = true;
            this.LabelPromptModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromptModule.Location = new System.Drawing.Point(12, 15);
            this.LabelPromptModule.Name = "LabelPromptModule";
            this.LabelPromptModule.Size = new System.Drawing.Size(80, 24);
            this.LabelPromptModule.TabIndex = 13;
            this.LabelPromptModule.Text = "Module";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(950, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(16, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "PREV";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(842, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = "NEXT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(950, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 35);
            this.button4.TabIndex = 17;
            this.button4.Text = "EDIT";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(950, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 35);
            this.button5.TabIndex = 18;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MenuAddQuestionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelPromptModule);
            this.Controls.Add(this.CB_Module);
            this.Controls.Add(this.CB_Question);
            this.Controls.Add(this.LabelPromptQuestion);
            this.Controls.Add(this.CB_Level);
            this.Controls.Add(this.LabelPromptLevel);
            this.Controls.Add(this.CB_Mode);
            this.Controls.Add(this.CB_Subject);
            this.Controls.Add(this.LabelPromptMode);
            this.Controls.Add(this.LabelPromptSubject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAddQuestionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueGen - Questions (View Only)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPromptSubject;
        private System.Windows.Forms.Label LabelPromptMode;
        private System.Windows.Forms.ComboBox CB_Subject;
        private System.Windows.Forms.ComboBox CB_Mode;
        private System.Windows.Forms.Label LabelPromptLevel;
        private System.Windows.Forms.ComboBox CB_Level;
        private System.Windows.Forms.Label LabelPromptQuestion;
        private System.Windows.Forms.TextBox CB_Question;
        private System.Windows.Forms.ComboBox CB_Module;
        private System.Windows.Forms.Label LabelPromptModule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}