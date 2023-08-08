namespace QueGen
{
    partial class MenuAddModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAddModule));
            this.Label_Prompt_Module = new System.Windows.Forms.Label();
            this.Input_Module = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Label_Warning_Module_Empty = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Prompt_Module
            // 
            this.Label_Prompt_Module.AutoSize = true;
            this.Label_Prompt_Module.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prompt_Module.Location = new System.Drawing.Point(236, 220);
            this.Label_Prompt_Module.Name = "Label_Prompt_Module";
            this.Label_Prompt_Module.Size = new System.Drawing.Size(186, 31);
            this.Label_Prompt_Module.TabIndex = 0;
            this.Label_Prompt_Module.Text = "Enter Module";
            // 
            // Input_Module
            // 
            this.Input_Module.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Module.Location = new System.Drawing.Point(242, 273);
            this.Input_Module.Multiline = true;
            this.Input_Module.Name = "Input_Module";
            this.Input_Module.Size = new System.Drawing.Size(621, 162);
            this.Input_Module.TabIndex = 1;
            this.Input_Module.TextChanged += new System.EventHandler(this.Input_Module_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(761, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Warning_Module_Empty
            // 
            this.Label_Warning_Module_Empty.AutoSize = true;
            this.Label_Warning_Module_Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Warning_Module_Empty.ForeColor = System.Drawing.Color.Maroon;
            this.Label_Warning_Module_Empty.Location = new System.Drawing.Point(239, 438);
            this.Label_Warning_Module_Empty.Name = "Label_Warning_Module_Empty";
            this.Label_Warning_Module_Empty.Size = new System.Drawing.Size(391, 31);
            this.Label_Warning_Module_Empty.TabIndex = 3;
            this.Label_Warning_Module_Empty.Text = "Module name cannot be empty!";
            this.Label_Warning_Module_Empty.Click += new System.EventHandler(this.Label_Warning_Module_Empty_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(34, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(950, 620);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "VIEW";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MenuAddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Label_Warning_Module_Empty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Input_Module);
            this.Controls.Add(this.Label_Prompt_Module);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAddModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueGen - Add Module";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Prompt_Module;
        private System.Windows.Forms.TextBox Input_Module;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label_Warning_Module_Empty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

