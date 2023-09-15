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
    public partial class MainSwitcher : UserControl
    {
        public MainSwitcher()
        {
            InitializeComponent();
        }

        private void lbGameRules_MouseEnter(object sender, EventArgs e)
        {
            lbGameRules.ForeColor = Color.MediumSpringGreen;
        }

        private void lbGameRules_MouseLeave(object sender, EventArgs e)
        {
            lbGameRules.ForeColor = Color.Gainsboro;
        }

        private void lbGameRules_Click(object sender, EventArgs e)
        {
            GameRules myGameRules = new GameRules();
            myGameRules.ShowDialog();
        }

        private void pictBtnBackWhite_Click(object sender, EventArgs e)
        {
            if (StaticUserControl.ucSelectOponent.Visible == true)
            {
                StaticUserControl.ucMainSwitcher.Controls.Remove(StaticUserControl.ucSelectOponent);
                StaticUserControl.ucSelectOponent.Visible = false;

                StaticUserControl.ucSelectLanguage.Visible = true;
                StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectLanguage);
            }
            else
            {
                if (StaticUserControl.ucPromptName.Visible == true)
                {
                    StaticUserControl.ucMainSwitcher.Controls.Remove(StaticUserControl.ucPromptName);
                    StaticUserControl.ucPromptName.Visible = false;

                    resetPlayerNames();
                    StaticUserControl.ucSelectOponent.Visible = true;
                    StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectOponent);
                }
            }
        }

        private void pictBtnBackBlack_Click(object sender, EventArgs e)
        {
            if (StaticUserControl.ucSelectOponent.Visible == true)
            {
                StaticUserControl.ucMainSwitcher.Controls.Remove(StaticUserControl.ucSelectOponent);
                StaticUserControl.ucSelectOponent.Visible = false;

                StaticUserControl.ucSelectLanguage.Visible = true;
                StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectLanguage);
            }
            else
            {
                if (StaticUserControl.ucPromptName.Visible == true)
                {
                    StaticUserControl.ucMainSwitcher.Controls.Remove(StaticUserControl.ucPromptName);
                    StaticUserControl.ucPromptName.Visible = false;

                    resetPlayerNames();
                    StaticUserControl.ucSelectOponent.Visible = true;
                    StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectOponent);
                }
            }
        }

        private void pictBtnBackWhite_MouseEnter(object sender, EventArgs e)
        {
            pictBtnBackWhite.Visible = false;
            pictBtnBackBlack.Visible = true;
        }

        private void pictBtnBackBlack_MouseLeave(object sender, EventArgs e)
        {
            pictBtnBackWhite.Visible = true;
            pictBtnBackBlack.Visible = false;
        }

        private void resetPlayerNames()
        {
            StaticUserControl.ucPromptName.promtPlayerUi.Clear();
            StaticUserControl.ucPromptName.pnlSelectPlayer.Controls.Clear();
            StaticUserControl.ucPromptName.playerNames.Clear();
        }
    }
}
