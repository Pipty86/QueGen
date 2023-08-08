namespace QueGen
{
    partial class MenuHomeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuHomeMain));
            this.HomeBtnAdd = new System.Windows.Forms.Button();
            this.HomeBtnView = new System.Windows.Forms.Button();
            this.HomeBtnUpdate = new System.Windows.Forms.Button();
            this.HomeBtnDel = new System.Windows.Forms.Button();
            this.Lbl_Trademark = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControl11 = new QueGen.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBtnAdd
            // 
            this.HomeBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HomeBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtnAdd.Location = new System.Drawing.Point(12, 37);
            this.HomeBtnAdd.Name = "HomeBtnAdd";
            this.HomeBtnAdd.Size = new System.Drawing.Size(151, 60);
            this.HomeBtnAdd.TabIndex = 0;
            this.HomeBtnAdd.Text = "ADD";
            this.HomeBtnAdd.UseVisualStyleBackColor = false;
            this.HomeBtnAdd.Click += new System.EventHandler(this.HomeBtnAdd_Click);
            // 
            // HomeBtnView
            // 
            this.HomeBtnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HomeBtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtnView.Location = new System.Drawing.Point(12, 103);
            this.HomeBtnView.Name = "HomeBtnView";
            this.HomeBtnView.Size = new System.Drawing.Size(151, 60);
            this.HomeBtnView.TabIndex = 1;
            this.HomeBtnView.Text = "VIEW";
            this.HomeBtnView.UseVisualStyleBackColor = false;
            this.HomeBtnView.Click += new System.EventHandler(this.HomeBtnView_Click);
            // 
            // HomeBtnUpdate
            // 
            this.HomeBtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HomeBtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtnUpdate.Location = new System.Drawing.Point(12, 169);
            this.HomeBtnUpdate.Name = "HomeBtnUpdate";
            this.HomeBtnUpdate.Size = new System.Drawing.Size(151, 60);
            this.HomeBtnUpdate.TabIndex = 1;
            this.HomeBtnUpdate.Text = "UPDATE";
            this.HomeBtnUpdate.UseVisualStyleBackColor = false;
            // 
            // HomeBtnDel
            // 
            this.HomeBtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.HomeBtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtnDel.Location = new System.Drawing.Point(12, 235);
            this.HomeBtnDel.Name = "HomeBtnDel";
            this.HomeBtnDel.Size = new System.Drawing.Size(151, 60);
            this.HomeBtnDel.TabIndex = 1;
            this.HomeBtnDel.Text = "DELETE";
            this.HomeBtnDel.UseVisualStyleBackColor = false;
            // 
            // Lbl_Trademark
            // 
            this.Lbl_Trademark.AutoSize = true;
            this.Lbl_Trademark.Location = new System.Drawing.Point(9, 1019);
            this.Lbl_Trademark.Name = "Lbl_Trademark";
            this.Lbl_Trademark.Size = new System.Drawing.Size(223, 13);
            this.Lbl_Trademark.TabIndex = 2;
            this.Lbl_Trademark.Text = "Personal use, not for resale or commercial use";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(185, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1727, 1075);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userControl11
            // 
            this.userControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl11.Location = new System.Drawing.Point(185, -27);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1718, 1075);
            this.userControl11.TabIndex = 4;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // MenuHomeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.Lbl_Trademark);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HomeBtnDel);
            this.Controls.Add(this.HomeBtnUpdate);
            this.Controls.Add(this.HomeBtnView);
            this.Controls.Add(this.HomeBtnAdd);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuHomeMain";
            this.Text = "QueGen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeBtnAdd;
        private System.Windows.Forms.Button HomeBtnView;
        private System.Windows.Forms.Button HomeBtnUpdate;
        private System.Windows.Forms.Button HomeBtnDel;
        private System.Windows.Forms.Label Lbl_Trademark;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControl1 userControl11;
    }
}