namespace WordWarGame
{
    partial class MainSwitcher
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbGameRules = new System.Windows.Forms.Label();
            this.pictBtnBackWhite = new System.Windows.Forms.PictureBox();
            this.pictBtnBackBlack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBtnBackWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBtnBackBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.pictBtnBackWhite);
            this.panel1.Controls.Add(this.lbGameRules);
            this.panel1.Controls.Add(this.pictBtnBackBlack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 27);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // lbGameRules
            // 
            this.lbGameRules.AutoSize = true;
            this.lbGameRules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameRules.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbGameRules.Location = new System.Drawing.Point(1299, 8);
            this.lbGameRules.Name = "lbGameRules";
            this.lbGameRules.Size = new System.Drawing.Size(35, 15);
            this.lbGameRules.TabIndex = 0;
            this.lbGameRules.Text = "Rules";
            this.lbGameRules.Click += new System.EventHandler(this.lbGameRules_Click);
            this.lbGameRules.MouseEnter += new System.EventHandler(this.lbGameRules_MouseEnter);
            this.lbGameRules.MouseLeave += new System.EventHandler(this.lbGameRules_MouseLeave);
            // 
            // pictBtnBackWhite
            // 
            this.pictBtnBackWhite.Image = global::WordWarGame.Properties.Resources.arrows;
            this.pictBtnBackWhite.Location = new System.Drawing.Point(12, 3);
            this.pictBtnBackWhite.Name = "pictBtnBackWhite";
            this.pictBtnBackWhite.Size = new System.Drawing.Size(21, 21);
            this.pictBtnBackWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBtnBackWhite.TabIndex = 3;
            this.pictBtnBackWhite.TabStop = false;
            this.pictBtnBackWhite.Visible = false;
            this.pictBtnBackWhite.Click += new System.EventHandler(this.pictBtnBackWhite_Click);
            this.pictBtnBackWhite.MouseEnter += new System.EventHandler(this.pictBtnBackWhite_MouseEnter);
            // 
            // pictBtnBackBlack
            // 
            this.pictBtnBackBlack.Image = global::WordWarGame.Properties.Resources.left;
            this.pictBtnBackBlack.Location = new System.Drawing.Point(12, 3);
            this.pictBtnBackBlack.Name = "pictBtnBackBlack";
            this.pictBtnBackBlack.Size = new System.Drawing.Size(21, 21);
            this.pictBtnBackBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBtnBackBlack.TabIndex = 2;
            this.pictBtnBackBlack.TabStop = false;
            this.pictBtnBackBlack.Visible = false;
            this.pictBtnBackBlack.Click += new System.EventHandler(this.pictBtnBackBlack_Click);
            this.pictBtnBackBlack.MouseLeave += new System.EventHandler(this.pictBtnBackBlack_MouseLeave);
            // 
            // MainSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "MainSwitcher";
            this.Size = new System.Drawing.Size(1366, 768);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBtnBackWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBtnBackBlack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbGameRules;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictBtnBackWhite;
        public System.Windows.Forms.PictureBox pictBtnBackBlack;
    }
}
