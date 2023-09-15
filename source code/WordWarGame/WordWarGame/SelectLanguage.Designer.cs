namespace WordWarGame
{
    partial class SelectLanguage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFrenchLanguage = new System.Windows.Forms.Label();
            this.lbEnglishLanguage = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.lbFrenchLanguage);
            this.panel1.Controls.Add(this.lbEnglishLanguage);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(513, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 251);
            this.panel1.TabIndex = 0;
            // 
            // lbFrenchLanguage
            // 
            this.lbFrenchLanguage.AutoSize = true;
            this.lbFrenchLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbFrenchLanguage.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrenchLanguage.ForeColor = System.Drawing.Color.White;
            this.lbFrenchLanguage.Location = new System.Drawing.Point(88, 147);
            this.lbFrenchLanguage.MinimumSize = new System.Drawing.Size(190, 27);
            this.lbFrenchLanguage.Name = "lbFrenchLanguage";
            this.lbFrenchLanguage.Padding = new System.Windows.Forms.Padding(61, 0, 0, 0);
            this.lbFrenchLanguage.Size = new System.Drawing.Size(190, 27);
            this.lbFrenchLanguage.TabIndex = 3;
            this.lbFrenchLanguage.Text = "Francais";
            this.lbFrenchLanguage.Click += new System.EventHandler(this.lbFrenchLanguage_Click);
            this.lbFrenchLanguage.MouseEnter += new System.EventHandler(this.lbFrenchLanguage_MouseEnter);
            this.lbFrenchLanguage.MouseLeave += new System.EventHandler(this.lbFrenchLanguage_MouseLeave);
            // 
            // lbEnglishLanguage
            // 
            this.lbEnglishLanguage.AutoSize = true;
            this.lbEnglishLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbEnglishLanguage.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnglishLanguage.ForeColor = System.Drawing.Color.White;
            this.lbEnglishLanguage.Location = new System.Drawing.Point(88, 61);
            this.lbEnglishLanguage.MinimumSize = new System.Drawing.Size(190, 27);
            this.lbEnglishLanguage.Name = "lbEnglishLanguage";
            this.lbEnglishLanguage.Padding = new System.Windows.Forms.Padding(61, 0, 0, 0);
            this.lbEnglishLanguage.Size = new System.Drawing.Size(190, 27);
            this.lbEnglishLanguage.TabIndex = 2;
            this.lbEnglishLanguage.Text = "English";
            this.lbEnglishLanguage.Click += new System.EventHandler(this.lbEnglishLanguage_Click);
            this.lbEnglishLanguage.MouseEnter += new System.EventHandler(this.lbEnglishLanguage_MouseEnter);
            this.lbEnglishLanguage.MouseLeave += new System.EventHandler(this.lbEnglishLanguage_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WordWarGame.Properties.Resources.FrenchFlag;
            this.pictureBox2.Location = new System.Drawing.Point(44, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WordWarGame.Properties.Resources.EnglishFlag1;
            this.pictureBox1.Location = new System.Drawing.Point(44, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SelectLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 54);
            this.MaximumSize = new System.Drawing.Size(1366, 714);
            this.MinimumSize = new System.Drawing.Size(1366, 714);
            this.Name = "SelectLanguage";
            this.Size = new System.Drawing.Size(1366, 714);
            this.Load += new System.EventHandler(this.SelectLanguage_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectLanguage_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFrenchLanguage;
        private System.Windows.Forms.Label lbEnglishLanguage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
