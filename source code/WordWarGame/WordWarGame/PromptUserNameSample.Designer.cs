namespace WordWarGame
{
    partial class PromptUserNameSample
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
            this.lbPlayer = new System.Windows.Forms.Label();
            this.pnlPromptName = new System.Windows.Forms.Panel();
            this.pictCrossFailed = new System.Windows.Forms.PictureBox();
            this.pictElipsesLoading = new System.Windows.Forms.PictureBox();
            this.pictTickSuccess = new System.Windows.Forms.PictureBox();
            this.tbNameOfPlayer = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.btnEditName = new System.Windows.Forms.Button();
            this.pnlPromptName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCrossFailed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictElipsesLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictTickSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPlayer.Location = new System.Drawing.Point(20, 6);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(61, 21);
            this.lbPlayer.TabIndex = 14;
            this.lbPlayer.Text = "Player 1";
            // 
            // pnlPromptName
            // 
            this.pnlPromptName.BackColor = System.Drawing.Color.Transparent;
            this.pnlPromptName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPromptName.Controls.Add(this.pictCrossFailed);
            this.pnlPromptName.Controls.Add(this.pictElipsesLoading);
            this.pnlPromptName.Controls.Add(this.pictTickSuccess);
            this.pnlPromptName.Controls.Add(this.tbNameOfPlayer);
            this.pnlPromptName.Controls.Add(this.lbName);
            this.pnlPromptName.Location = new System.Drawing.Point(0, 19);
            this.pnlPromptName.Name = "pnlPromptName";
            this.pnlPromptName.Size = new System.Drawing.Size(472, 100);
            this.pnlPromptName.TabIndex = 13;
            // 
            // pictCrossFailed
            // 
            this.pictCrossFailed.Image = global::WordWarGame.Properties.Resources.criss_cross;
            this.pictCrossFailed.Location = new System.Drawing.Point(410, 41);
            this.pictCrossFailed.Name = "pictCrossFailed";
            this.pictCrossFailed.Size = new System.Drawing.Size(15, 15);
            this.pictCrossFailed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictCrossFailed.TabIndex = 6;
            this.pictCrossFailed.TabStop = false;
            this.pictCrossFailed.Visible = false;
            // 
            // pictElipsesLoading
            // 
            this.pictElipsesLoading.Image = global::WordWarGame.Properties.Resources.more;
            this.pictElipsesLoading.Location = new System.Drawing.Point(410, 41);
            this.pictElipsesLoading.Name = "pictElipsesLoading";
            this.pictElipsesLoading.Size = new System.Drawing.Size(15, 15);
            this.pictElipsesLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictElipsesLoading.TabIndex = 5;
            this.pictElipsesLoading.TabStop = false;
            this.pictElipsesLoading.Visible = false;
            // 
            // pictTickSuccess
            // 
            this.pictTickSuccess.Image = global::WordWarGame.Properties.Resources.tick;
            this.pictTickSuccess.Location = new System.Drawing.Point(410, 41);
            this.pictTickSuccess.Name = "pictTickSuccess";
            this.pictTickSuccess.Size = new System.Drawing.Size(15, 15);
            this.pictTickSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictTickSuccess.TabIndex = 4;
            this.pictTickSuccess.TabStop = false;
            this.pictTickSuccess.Visible = false;
            // 
            // tbNameOfPlayer
            // 
            this.tbNameOfPlayer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameOfPlayer.Location = new System.Drawing.Point(136, 38);
            this.tbNameOfPlayer.Name = "tbNameOfPlayer";
            this.tbNameOfPlayer.Size = new System.Drawing.Size(242, 23);
            this.tbNameOfPlayer.TabIndex = 3;
            this.tbNameOfPlayer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNameOfPlayer_KeyPress);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbName.Location = new System.Drawing.Point(76, 41);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 15);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // btnSaveName
            // 
            this.btnSaveName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnSaveName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveName.Location = new System.Drawing.Point(397, 125);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(75, 21);
            this.btnSaveName.TabIndex = 15;
            this.btnSaveName.Text = "Save";
            this.btnSaveName.UseVisualStyleBackColor = false;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // btnEditName
            // 
            this.btnEditName.BackColor = System.Drawing.Color.White;
            this.btnEditName.Enabled = false;
            this.btnEditName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnEditName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditName.ForeColor = System.Drawing.Color.Black;
            this.btnEditName.Location = new System.Drawing.Point(304, 125);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(75, 21);
            this.btnEditName.TabIndex = 16;
            this.btnEditName.Text = "Edit";
            this.btnEditName.UseVisualStyleBackColor = false;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // PromptUserNameSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.pnlPromptName);
            this.Controls.Add(this.btnSaveName);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.MaximumSize = new System.Drawing.Size(472, 152);
            this.MinimumSize = new System.Drawing.Size(472, 152);
            this.Name = "PromptUserNameSample";
            this.Size = new System.Drawing.Size(472, 152);
            this.pnlPromptName.ResumeLayout(false);
            this.pnlPromptName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCrossFailed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictElipsesLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictTickSuccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlPromptName;
        public System.Windows.Forms.TextBox tbNameOfPlayer;
        private System.Windows.Forms.Label lbName;
        public System.Windows.Forms.Button btnSaveName;
        public System.Windows.Forms.Label lbPlayer;
        public System.Windows.Forms.Button btnEditName;
        public System.Windows.Forms.PictureBox pictCrossFailed;
        public System.Windows.Forms.PictureBox pictElipsesLoading;
        public System.Windows.Forms.PictureBox pictTickSuccess;
    }
}
