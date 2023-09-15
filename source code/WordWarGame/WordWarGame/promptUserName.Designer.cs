namespace WordWarGame
{
    partial class promptUserName
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
            this.btStartGame = new System.Windows.Forms.Button();
            this.pnlSelectPlayerMainBox = new System.Windows.Forms.Panel();
            this.btAddPlayer = new System.Windows.Forms.Button();
            this.btDelPlayer = new System.Windows.Forms.Button();
            this.pnlFoot = new System.Windows.Forms.Panel();
            this.pnlSelectPlayer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDecorGauche = new System.Windows.Forms.Panel();
            this.panelDessusDecor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSelectPlayerMainBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStartGame
            // 
            this.btStartGame.BackColor = System.Drawing.Color.Gainsboro;
            this.btStartGame.FlatAppearance.BorderSize = 0;
            this.btStartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStartGame.Location = new System.Drawing.Point(614, 542);
            this.btStartGame.Name = "btStartGame";
            this.btStartGame.Size = new System.Drawing.Size(75, 23);
            this.btStartGame.TabIndex = 14;
            this.btStartGame.Text = "Start";
            this.btStartGame.UseVisualStyleBackColor = false;
            this.btStartGame.Click += new System.EventHandler(this.btStartGame_Click);
            // 
            // pnlSelectPlayerMainBox
            // 
            this.pnlSelectPlayerMainBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSelectPlayerMainBox.AutoScroll = true;
            this.pnlSelectPlayerMainBox.BackColor = System.Drawing.Color.Indigo;
            this.pnlSelectPlayerMainBox.Controls.Add(this.btAddPlayer);
            this.pnlSelectPlayerMainBox.Controls.Add(this.btDelPlayer);
            this.pnlSelectPlayerMainBox.Controls.Add(this.btStartGame);
            this.pnlSelectPlayerMainBox.Controls.Add(this.pnlFoot);
            this.pnlSelectPlayerMainBox.Location = new System.Drawing.Point(336, 31);
            this.pnlSelectPlayerMainBox.Name = "pnlSelectPlayerMainBox";
            this.pnlSelectPlayerMainBox.Size = new System.Drawing.Size(699, 573);
            this.pnlSelectPlayerMainBox.TabIndex = 15;
            // 
            // btAddPlayer
            // 
            this.btAddPlayer.BackColor = System.Drawing.Color.Gainsboro;
            this.btAddPlayer.FlatAppearance.BorderSize = 0;
            this.btAddPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPlayer.Location = new System.Drawing.Point(448, 542);
            this.btAddPlayer.Name = "btAddPlayer";
            this.btAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btAddPlayer.TabIndex = 16;
            this.btAddPlayer.Text = "Add";
            this.btAddPlayer.UseVisualStyleBackColor = false;
            this.btAddPlayer.Click += new System.EventHandler(this.btAddPlayer_Click);
            // 
            // btDelPlayer
            // 
            this.btDelPlayer.BackColor = System.Drawing.Color.Gainsboro;
            this.btDelPlayer.FlatAppearance.BorderSize = 0;
            this.btDelPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btDelPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelPlayer.Location = new System.Drawing.Point(531, 542);
            this.btDelPlayer.Name = "btDelPlayer";
            this.btDelPlayer.Size = new System.Drawing.Size(75, 23);
            this.btDelPlayer.TabIndex = 15;
            this.btDelPlayer.Text = "Delete";
            this.btDelPlayer.UseVisualStyleBackColor = false;
            this.btDelPlayer.Click += new System.EventHandler(this.btDelPlayer_Click);
            // 
            // pnlFoot
            // 
            this.pnlFoot.BackColor = System.Drawing.Color.DarkViolet;
            this.pnlFoot.Location = new System.Drawing.Point(0, 534);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(699, 39);
            this.pnlFoot.TabIndex = 17;
            // 
            // pnlSelectPlayer
            // 
            this.pnlSelectPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectPlayer.AutoScroll = true;
            this.pnlSelectPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlSelectPlayer.Location = new System.Drawing.Point(336, 31);
            this.pnlSelectPlayer.Name = "pnlSelectPlayer";
            this.pnlSelectPlayer.Padding = new System.Windows.Forms.Padding(106, 0, 0, 0);
            this.pnlSelectPlayer.Size = new System.Drawing.Size(699, 536);
            this.pnlSelectPlayer.TabIndex = 0;
            // 
            // panelDecorGauche
            // 
            this.panelDecorGauche.BackColor = System.Drawing.Color.DarkViolet;
            this.panelDecorGauche.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelDecorGauche.Location = new System.Drawing.Point(336, 31);
            this.panelDecorGauche.Name = "panelDecorGauche";
            this.panelDecorGauche.Size = new System.Drawing.Size(2, 536);
            this.panelDecorGauche.TabIndex = 0;
            // 
            // panelDessusDecor
            // 
            this.panelDessusDecor.BackColor = System.Drawing.Color.DarkViolet;
            this.panelDessusDecor.Location = new System.Drawing.Point(336, 31);
            this.panelDessusDecor.Name = "panelDessusDecor";
            this.panelDessusDecor.Size = new System.Drawing.Size(699, 2);
            this.panelDessusDecor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1033, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 536);
            this.panel1.TabIndex = 1;
            // 
            // promptUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDessusDecor);
            this.Controls.Add(this.panelDecorGauche);
            this.Controls.Add(this.pnlSelectPlayer);
            this.Controls.Add(this.pnlSelectPlayerMainBox);
            this.Location = new System.Drawing.Point(0, 54);
            this.MaximumSize = new System.Drawing.Size(1366, 714);
            this.MinimumSize = new System.Drawing.Size(1366, 714);
            this.Name = "promptUserName";
            this.Size = new System.Drawing.Size(1366, 714);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.promptUserName_Paint);
            this.pnlSelectPlayerMainBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btStartGame;
        private System.Windows.Forms.Panel pnlSelectPlayerMainBox;
        private System.Windows.Forms.Button btAddPlayer;
        private System.Windows.Forms.Button btDelPlayer;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.Panel panelDecorGauche;
        private System.Windows.Forms.Panel panelDessusDecor;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel pnlSelectPlayer;
    }
}
