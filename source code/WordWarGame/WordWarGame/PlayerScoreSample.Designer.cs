namespace WordWarGame
{
    partial class PlayerScoreSample
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
            this.pnlMainBox = new System.Windows.Forms.Panel();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbPlayerNum = new System.Windows.Forms.Label();
            this.pnlPlayerColor = new System.Windows.Forms.Panel();
            this.pnlMainBox.SuspendLayout();
            this.pnlPlayerColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainBox
            // 
            this.pnlMainBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainBox.Controls.Add(this.pnlPlayerColor);
            this.pnlMainBox.Controls.Add(this.lbScore);
            this.pnlMainBox.Controls.Add(this.lbPlayerName);
            this.pnlMainBox.Location = new System.Drawing.Point(0, 0);
            this.pnlMainBox.Name = "pnlMainBox";
            this.pnlMainBox.Size = new System.Drawing.Size(410, 49);
            this.pnlMainBox.TabIndex = 0;
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.ForeColor = System.Drawing.Color.White;
            this.lbPlayerName.Location = new System.Drawing.Point(64, 14);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(83, 17);
            this.lbPlayerName.TabIndex = 1;
            this.lbPlayerName.Text = "PlayerName :";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Crimson;
            this.lbScore.Location = new System.Drawing.Point(214, 16);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(22, 17);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "00";
            // 
            // lbPlayerNum
            // 
            this.lbPlayerNum.AutoSize = true;
            this.lbPlayerNum.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerNum.ForeColor = System.Drawing.Color.White;
            this.lbPlayerNum.Location = new System.Drawing.Point(3, 14);
            this.lbPlayerNum.Name = "lbPlayerNum";
            this.lbPlayerNum.Size = new System.Drawing.Size(24, 17);
            this.lbPlayerNum.TabIndex = 3;
            this.lbPlayerNum.Text = "P 1";
            // 
            // pnlPlayerColor
            // 
            this.pnlPlayerColor.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlPlayerColor.Controls.Add(this.lbPlayerNum);
            this.pnlPlayerColor.Location = new System.Drawing.Point(1, 0);
            this.pnlPlayerColor.Name = "pnlPlayerColor";
            this.pnlPlayerColor.Size = new System.Drawing.Size(30, 49);
            this.pnlPlayerColor.TabIndex = 4;
            // 
            // PlayerScoreSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlMainBox);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "PlayerScoreSample";
            this.Size = new System.Drawing.Size(410, 49);
            this.pnlMainBox.ResumeLayout(false);
            this.pnlMainBox.PerformLayout();
            this.pnlPlayerColor.ResumeLayout(false);
            this.pnlPlayerColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainBox;
        public System.Windows.Forms.Panel pnlPlayerColor;
        public System.Windows.Forms.Label lbPlayerNum;
        public System.Windows.Forms.Label lbScore;
        public System.Windows.Forms.Label lbPlayerName;
    }
}
