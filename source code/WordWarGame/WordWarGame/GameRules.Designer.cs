namespace WordWarGame
{
    partial class GameRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRules));
            this.TextBoxGameRules = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextBoxGameRules
            // 
            this.TextBoxGameRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TextBoxGameRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxGameRules.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxGameRules.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.TextBoxGameRules.ForeColor = System.Drawing.Color.Gainsboro;
            this.TextBoxGameRules.Location = new System.Drawing.Point(63, 40);
            this.TextBoxGameRules.MaximumSize = new System.Drawing.Size(673, 415);
            this.TextBoxGameRules.MinimumSize = new System.Drawing.Size(673, 415);
            this.TextBoxGameRules.Name = "TextBoxGameRules";
            this.TextBoxGameRules.ReadOnly = true;
            this.TextBoxGameRules.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextBoxGameRules.Size = new System.Drawing.Size(673, 415);
            this.TextBoxGameRules.TabIndex = 1;
            this.TextBoxGameRules.Text = resources.GetString("TextBoxGameRules.Text");
            // 
            // GameRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.TextBoxGameRules);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 538);
            this.MinimumSize = new System.Drawing.Size(816, 538);
            this.Name = "GameRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameRules";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.RichTextBox TextBoxGameRules;
    }
}