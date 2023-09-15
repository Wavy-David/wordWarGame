using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordWarGame
{
    public partial class MainForm : Form
    {
        private int count = 0;
        SplashScreen splashScreen = new SplashScreen();
        
        public MainForm()
        {
            InitializeComponent();
            //Set all userControl visibility to false
            StaticUserControl.ucSelectLanguage.Visible = true;
            StaticUserControl.ucSelectOponent.Visible = false;
            StaticUserControl.ucPromptName.Visible = false;
            StaticUserControl.ucGameExhibit.Visible = false;
            StaticUserControl.ucWinnerWindow.Visible = false;

            this.Controls.Add(splashScreen);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count += 1;

            if (count == 500)
            {
                timer1.Stop();
                splashScreen.Hide();
                this.Controls.Remove(splashScreen);
                this.Controls.Add(StaticUserControl.ucMainSwitcher);
                StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectLanguage);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
