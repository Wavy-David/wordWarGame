namespace WordWarGame
{
    partial class SelectOponent
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1HumanVsCpu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2HumanVsHuman = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1HumanVsCpu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2HumanVsHuman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "VS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // panel1HumanVsCpu
            // 
            this.panel1HumanVsCpu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1HumanVsCpu.Controls.Add(this.label1);
            this.panel1HumanVsCpu.Controls.Add(this.pictureBox1);
            this.panel1HumanVsCpu.Controls.Add(this.pictureBox2);
            this.panel1HumanVsCpu.Location = new System.Drawing.Point(419, 129);
            this.panel1HumanVsCpu.Name = "panel1HumanVsCpu";
            this.panel1HumanVsCpu.Size = new System.Drawing.Size(543, 98);
            this.panel1HumanVsCpu.TabIndex = 2;
            this.panel1HumanVsCpu.Click += new System.EventHandler(this.panel1HumanVsCpu_Click);
            this.panel1HumanVsCpu.MouseEnter += new System.EventHandler(this.panel1HumanVsCpu_MouseEnter);
            this.panel1HumanVsCpu.MouseLeave += new System.EventHandler(this.panel1HumanVsCpu_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WordWarGame.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(40, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WordWarGame.Properties.Resources.monitor;
            this.pictureBox2.Location = new System.Drawing.Point(417, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 61);
            this.label2.TabIndex = 5;
            this.label2.Text = "VS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panel2HumanVsHuman
            // 
            this.panel2HumanVsHuman.Controls.Add(this.pictureBox4);
            this.panel2HumanVsHuman.Controls.Add(this.pictureBox3);
            this.panel2HumanVsHuman.Controls.Add(this.label2);
            this.panel2HumanVsHuman.Location = new System.Drawing.Point(419, 375);
            this.panel2HumanVsHuman.Name = "panel2HumanVsHuman";
            this.panel2HumanVsHuman.Size = new System.Drawing.Size(543, 100);
            this.panel2HumanVsHuman.TabIndex = 6;
            this.panel2HumanVsHuman.Click += new System.EventHandler(this.panel2HumanVsHuman_Click);
            this.panel2HumanVsHuman.MouseEnter += new System.EventHandler(this.panel2HumanVsHuman_MouseEnter);
            this.panel2HumanVsHuman.MouseLeave += new System.EventHandler(this.panel2HumanVsHuman_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WordWarGame.Properties.Resources.user;
            this.pictureBox4.Location = new System.Drawing.Point(39, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WordWarGame.Properties.Resources.user_1_;
            this.pictureBox3.Location = new System.Drawing.Point(417, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // SelectOponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.panel2HumanVsHuman);
            this.Controls.Add(this.panel1HumanVsCpu);
            this.Location = new System.Drawing.Point(0, 54);
            this.MaximumSize = new System.Drawing.Size(1366, 714);
            this.MinimumSize = new System.Drawing.Size(1366, 714);
            this.Name = "SelectOponent";
            this.Size = new System.Drawing.Size(1366, 714);
            this.panel1HumanVsCpu.ResumeLayout(false);
            this.panel1HumanVsCpu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2HumanVsHuman.ResumeLayout(false);
            this.panel2HumanVsHuman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1HumanVsCpu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2HumanVsHuman;
    }
}
