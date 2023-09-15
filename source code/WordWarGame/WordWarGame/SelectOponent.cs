using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordWarGame
{
    public partial class SelectOponent : UserControl
    {
        public SelectOponent()
        {
            InitializeComponent();
        }

        #region  Human Vs Computer Bloc (FX)

        private void panel1HumanVsCpu_MouseEnter(object sender, EventArgs e)
        {
            panel1HumanVsCpu.BackColor = Color.WhiteSmoke;
            label1.ForeColor = Color.Black;
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox2.BackColor = Color.WhiteSmoke;
        }

        private void panel1HumanVsCpu_MouseLeave(object sender, EventArgs e)
        {
            panel1HumanVsCpu.BackColor = Color.FromArgb(20, 20, 20);
            label1.ForeColor = Color.White;
            pictureBox1.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox2.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panel1HumanVsCpu.BackColor = Color.WhiteSmoke;
            label1.ForeColor = Color.Black;
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox2.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1HumanVsCpu.BackColor = Color.FromArgb(20, 20, 20);
            label1.ForeColor = Color.White;
            pictureBox1.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox2.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            panel1HumanVsCpu.BackColor = Color.WhiteSmoke;
            label1.ForeColor = Color.Black;
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox2.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel1HumanVsCpu.BackColor = Color.FromArgb(20, 20, 20);
            label1.ForeColor = Color.White;
            pictureBox1.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox2.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel1HumanVsCpu.BackColor = Color.WhiteSmoke;
            label1.ForeColor = Color.Black;
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox2.BackColor = Color.WhiteSmoke;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel1HumanVsCpu.BackColor = Color.FromArgb(20, 20, 20);
            label1.ForeColor = Color.White;
            pictureBox1.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox2.BackColor = Color.FromArgb(20, 20, 20);
        }
        #endregion

        #region Human Vs Human Bloc (FX)

        private void panel2HumanVsHuman_MouseEnter(object sender, EventArgs e)
        {
            panel2HumanVsHuman.BackColor = Color.WhiteSmoke;
            label2.ForeColor = Color.Black;
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox4.BackColor = Color.WhiteSmoke;
        }

        private void panel2HumanVsHuman_MouseLeave(object sender, EventArgs e)
        {
            panel2HumanVsHuman.BackColor = Color.FromArgb(20, 20, 20);
            label2.ForeColor = Color.White;
            pictureBox3.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox4.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel2HumanVsHuman.BackColor = Color.WhiteSmoke;
            label2.ForeColor = Color.Black;
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox4.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel2HumanVsHuman.BackColor = Color.FromArgb(20, 20, 20);
            label2.ForeColor = Color.White;
            pictureBox3.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox4.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel2HumanVsHuman.BackColor = Color.WhiteSmoke;
            label2.ForeColor = Color.Black;
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox4.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel2HumanVsHuman.BackColor = Color.FromArgb(20, 20, 20);
            label2.ForeColor = Color.White;
            pictureBox3.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox4.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panel2HumanVsHuman.BackColor = Color.WhiteSmoke;
            label2.ForeColor = Color.Black;
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox4.BackColor = Color.WhiteSmoke;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel2HumanVsHuman.BackColor = Color.FromArgb(20, 20, 20);
            label2.ForeColor = Color.White;
            pictureBox3.BackColor = Color.FromArgb(20, 20, 20);
            pictureBox4.BackColor = Color.FromArgb(20, 20, 20);
        }
        #endregion

        #region Human Vs Human Click Event

        private void label2_Click(object sender, EventArgs e)
        {
            humanVHumanClick();
        }

        private void panel2HumanVsHuman_Click(object sender, EventArgs e)
        {
            humanVHumanClick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            humanVHumanClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            humanVHumanClick();
        }

        private void humanVHumanClick()
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucSelectOponent.Visible = false;

            StaticUserControl.ucPromptName.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucPromptName);

            StaticUserControl.ucPromptName.loadPromptUi();

            StaticUserControl.ucWinnerWindow.pnlScoreTable.Height = 93;
            StaticUserControl.ucWinnerWindow.panel19.Location = new Point(374, 174);
        }
        #endregion

        #region Human Vs Computer Click Event

        private void panel1HumanVsCpu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This feature is not available in the Beta version of the App", "Note", MessageBoxButtons.OK);
            //humanVComputerClick();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This feature is not available in the Beta version of the App", "Note", MessageBoxButtons.OK);
            //humanVComputerClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This feature is not available in the Beta version of the App", "Note", MessageBoxButtons.OK);
            //humanVComputerClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This feature is not available in the Beta version of the App", "Note", MessageBoxButtons.OK);
            //humanVComputerClick();
        }

        private void humanVComputerClick()
        {
            //some Codes here ...
        }
        #endregion
    }
}
