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
    public partial class SelectLanguage : UserControl
    {
        public SelectLanguage()
        {
            InitializeComponent();
        }

        private void lbEnglishLanguage_MouseEnter(object sender, EventArgs e)
        {
            lbEnglishLanguage.ForeColor = Color.Magenta;
        }

        private void lbEnglishLanguage_MouseLeave(object sender, EventArgs e)
        {
            lbEnglishLanguage.ForeColor = Color.White;
        }

        private void lbFrenchLanguage_MouseEnter(object sender, EventArgs e)
        {
            lbFrenchLanguage.ForeColor = Color.Magenta;
        }

        private void lbFrenchLanguage_MouseLeave(object sender, EventArgs e)
        {
            lbFrenchLanguage.ForeColor = Color.White;
        }

        private void lbEnglishLanguage_Click(object sender, EventArgs e)
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucSelectLanguage.Visible = false;

            StaticUserControl.ucMainSwitcher.pictBtnBackWhite.Visible = true;

            StaticUserControl.ucSelectOponent.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectOponent);
        }

        private void SelectLanguage_Load(object sender, EventArgs e)
        {
            
        }

        private void SelectLanguage_Paint(object sender, PaintEventArgs e)
        {
            StaticUserControl.ucMainSwitcher.pictBtnBackBlack.Visible = false;
            StaticUserControl.ucMainSwitcher.pictBtnBackWhite.Visible = false;
        }

        private void lbFrenchLanguage_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Cette option n'est pas disponible dans la version Beta de l'application","Note", MessageBoxButtons.OK);
        }
    }
}
