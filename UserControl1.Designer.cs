namespace QueGen
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HomeBtnQuestion = new System.Windows.Forms.Button();
            this.HomeBtnModule = new System.Windows.Forms.Button();
            this.HomeBtnSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeBtnQuestion
            // 
            this.HomeBtnQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeBtnQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomeBtnQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HomeBtnQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtnQuestion.Location = new System.Drawing.Point(448, 460);
            this.HomeBtnQuestion.Name = "HomeBtnQuestion";
            this.HomeBtnQuestion.Size = new System.Drawing.Size(151, 60);
            this.HomeBtnQuestion.TabIndex = 6;
            this.HomeBtnQuestion.Text = "QUESTION";
            this.HomeBtnQuestion.UseVisualStyleBackColor = false;
            // 
            // HomeBtnModule
            // 
            this.HomeBtnModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeBtnModule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomeBtnModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HomeBtnModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtnModule.Location = new System.Drawing.Point(448, 192);
            this.HomeBtnModule.Name = "HomeBtnModule";
            this.HomeBtnModule.Size = new System.Drawing.Size(151, 60);
            this.HomeBtnModule.TabIndex = 5;
            this.HomeBtnModule.Text = "MODULE";
            this.HomeBtnModule.UseVisualStyleBackColor = false;
            this.HomeBtnModule.Click += new System.EventHandler(this.HomeBtnModule_Click);
            // 
            // HomeBtnSubject
            // 
            this.HomeBtnSubject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HomeBtnSubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomeBtnSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HomeBtnSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtnSubject.Location = new System.Drawing.Point(448, 322);
            this.HomeBtnSubject.Name = "HomeBtnSubject";
            this.HomeBtnSubject.Size = new System.Drawing.Size(151, 60);
            this.HomeBtnSubject.TabIndex = 4;
            this.HomeBtnSubject.Text = "SUBJECT";
            this.HomeBtnSubject.UseVisualStyleBackColor = false;
            this.HomeBtnSubject.Click += new System.EventHandler(this.HomeBtnSubject_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.HomeBtnQuestion);
            this.Controls.Add(this.HomeBtnModule);
            this.Controls.Add(this.HomeBtnSubject);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1080, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeBtnQuestion;
        private System.Windows.Forms.Button HomeBtnModule;
        private System.Windows.Forms.Button HomeBtnSubject;
    }
}
