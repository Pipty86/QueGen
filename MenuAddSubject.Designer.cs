namespace QueGen
{
    partial class MenuAddSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAddSubject));
            this.Label_Prompt_Module = new System.Windows.Forms.Label();
            this.ComboBoxSelectModule = new System.Windows.Forms.ComboBox();
            this.Label_Prompt_Subject = new System.Windows.Forms.Label();
            this.Input_Subject = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Label_Warning_Subject_Empty = new System.Windows.Forms.Label();
            this.Label_Warning_Module_Empty = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Prompt_Module
            // 
            this.Label_Prompt_Module.AutoSize = true;
            this.Label_Prompt_Module.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prompt_Module.Location = new System.Drawing.Point(133, 94);
            this.Label_Prompt_Module.Name = "Label_Prompt_Module";
            this.Label_Prompt_Module.Size = new System.Drawing.Size(198, 31);
            this.Label_Prompt_Module.TabIndex = 1;
            this.Label_Prompt_Module.Text = "Select Module";
            // 
            // ComboBoxSelectModule
            // 
            this.ComboBoxSelectModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSelectModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSelectModule.FormattingEnabled = true;
            this.ComboBoxSelectModule.Location = new System.Drawing.Point(139, 137);
            this.ComboBoxSelectModule.Name = "ComboBoxSelectModule";
            this.ComboBoxSelectModule.Size = new System.Drawing.Size(733, 33);
            this.ComboBoxSelectModule.TabIndex = 2;
            this.ComboBoxSelectModule.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Label_Prompt_Subject
            // 
            this.Label_Prompt_Subject.AutoSize = true;
            this.Label_Prompt_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prompt_Subject.Location = new System.Drawing.Point(133, 257);
            this.Label_Prompt_Subject.Name = "Label_Prompt_Subject";
            this.Label_Prompt_Subject.Size = new System.Drawing.Size(190, 31);
            this.Label_Prompt_Subject.TabIndex = 3;
            this.Label_Prompt_Subject.Text = "Enter Subject";
            // 
            // Input_Subject
            // 
            this.Input_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Subject.Location = new System.Drawing.Point(139, 300);
            this.Input_Subject.Multiline = true;
            this.Input_Subject.Name = "Input_Subject";
            this.Input_Subject.Size = new System.Drawing.Size(733, 162);
            this.Input_Subject.TabIndex = 4;
            this.Input_Subject.TextChanged += new System.EventHandler(this.Input_Module_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(770, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Warning_Subject_Empty
            // 
            this.Label_Warning_Subject_Empty.AutoSize = true;
            this.Label_Warning_Subject_Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Warning_Subject_Empty.ForeColor = System.Drawing.Color.Maroon;
            this.Label_Warning_Subject_Empty.Location = new System.Drawing.Point(133, 465);
            this.Label_Warning_Subject_Empty.Name = "Label_Warning_Subject_Empty";
            this.Label_Warning_Subject_Empty.Size = new System.Drawing.Size(394, 31);
            this.Label_Warning_Subject_Empty.TabIndex = 6;
            this.Label_Warning_Subject_Empty.Text = "Subject name cannot be empty!";
            this.Label_Warning_Subject_Empty.Click += new System.EventHandler(this.Label_Warning_Subject_Empty_Click);
            // 
            // Label_Warning_Module_Empty
            // 
            this.Label_Warning_Module_Empty.AutoSize = true;
            this.Label_Warning_Module_Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Warning_Module_Empty.ForeColor = System.Drawing.Color.Maroon;
            this.Label_Warning_Module_Empty.Location = new System.Drawing.Point(133, 173);
            this.Label_Warning_Module_Empty.Name = "Label_Warning_Module_Empty";
            this.Label_Warning_Module_Empty.Size = new System.Drawing.Size(376, 31);
            this.Label_Warning_Module_Empty.TabIndex = 7;
            this.Label_Warning_Module_Empty.Text = "Please select the Module first!";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(12, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(950, 634);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "VIEW";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MenuAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Label_Warning_Module_Empty);
            this.Controls.Add(this.Label_Warning_Subject_Empty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Input_Subject);
            this.Controls.Add(this.Label_Prompt_Subject);
            this.Controls.Add(this.ComboBoxSelectModule);
            this.Controls.Add(this.Label_Prompt_Module);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueGen - Add Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Prompt_Module;
        private System.Windows.Forms.ComboBox ComboBoxSelectModule;
        private System.Windows.Forms.Label Label_Prompt_Subject;
        private System.Windows.Forms.TextBox Input_Subject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label_Warning_Subject_Empty;
        private System.Windows.Forms.Label Label_Warning_Module_Empty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}