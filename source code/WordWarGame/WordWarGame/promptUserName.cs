using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using GlobalConnectionString;


namespace WordWarGame
{
    public partial class promptUserName : UserControl
    {
        //public string[,] playerNames = new string[0, 1];
        public List<PromptUserNameSample> promtPlayerUi = new List<PromptUserNameSample>();
        public List<string> playerNames = new List<string>();
        //public string currentPlayer = null;
        //public string currentPlayerName = null;


        public promptUserName()
        {
            InitializeComponent();
            //loadPromptUi();
        }

        private void btnSubmitName1_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection();
                //con = GlobalConnectionString.DynamicString.DbConnection("WordWarGameDb");

                //con.Open();
                //String sqlInsert = "insert into USER_INFO(Name) " +
                //    "Values" +
                //    "(@Name)";

                //SqlCommand commad = new SqlCommand(sqlInsert, con);

                //commad.Parameters.AddWithValue("@Name", tbNameP1.Text);
                //commad.ExecuteNonQuery();
                //con.Close();

                //playerNames[0, 0] = tbNameP1.Text;
                //MessageBox.Show("saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbNameP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbNameP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnSubmitName2_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection();
                //con = GlobalConnectionString.DynamicString.DbConnection("WordWarGameDb");

                //con.Open();
                //String sqlInsert = "insert into USER_INFO(Name) " +
                //    "Values" +
                //    "(@Name)";

                //SqlCommand commad = new SqlCommand(sqlInsert, con);

                //commad.Parameters.AddWithValue("@Name", tbNameP2.Text);
                //commad.ExecuteNonQuery();
                //con.Close();

                //playerNames[0, 1] = tbNameP2.Text;
                //MessageBox.Show("saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAddPlayer_Click(object sender, EventArgs e)
        {
            addPlayerUi();
        }

        private void addPlayerUi()
        {
            promtPlayerUi.Add(new PromptUserNameSample());
            promtPlayerUi[promtPlayerUi.Count - 1].lbPlayer.Text = "Player " + promtPlayerUi.Count;
            pnlSelectPlayer.Controls.Add(promtPlayerUi[promtPlayerUi.Count - 1]);

            //Saving index of each Ui
            promtPlayerUi[promtPlayerUi.Count - 1].playerIndexUi = promtPlayerUi.Count - 1;

            //Toggle the delete button
            toggleButton();
            //MessageBox.Show(promtPlayerUi.Count.ToString());
        }

        private void toggleButton()
        {
            //Toggle delete button
            if (promtPlayerUi.Count > 2)
            {
                btDelPlayer.Enabled = true;
            }
            else
            {
                btDelPlayer.Enabled = false;
            }
        }

        private void removePlayerUi()
        {
            //the delete button should not delete the first 2 Players
            if (promtPlayerUi.Count > 2)
            {
                pnlSelectPlayer.Controls.Remove(promtPlayerUi[promtPlayerUi.Count - 1]);
                promtPlayerUi.Remove(promtPlayerUi[promtPlayerUi.Count - 1]);
            }
            //Toggle the delete button
            toggleButton();
        }

        private void btDelPlayer_Click(object sender, EventArgs e)
        {
            //making sure that the player name of the playerUi get removed from the list of playerNames
            if (this.promtPlayerUi.Count == this.playerNames.Count)
            {
                this.playerNames.Remove(this.playerNames[this.playerNames.Count - 1]);
            }
            removePlayerUi();
        }

        private void btStartGame_Click(object sender, EventArgs e)
        {
            if(this.playerNames.Count == 0 || this.playerNames.Count == 1)
            {
                MessageBox.Show("Make sure to have at least 2 players");
            }
            else
            {
                StaticUserControl.ucMainSwitcher.Controls.Remove(this);
                StaticUserControl.ucPromptName.Visible = false;

                StaticUserControl.ucMainSwitcher.pictBtnBackWhite.Visible = false;

                StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucGameExhibit);
                StaticUserControl.ucGameExhibit.Visible = true;

                StaticUserControl.ucGameExhibit.loadGameExhibitField();
            }
        }

        private void promptUserName_Paint(object sender, PaintEventArgs e)
        {
            ////create new UI
            //promtPlayerUi.Add(new PromptUserNameSample());
            //promtPlayerUi.Add(new PromptUserNameSample());
            //promtPlayerUi[1].lbPlayer.Text = "Player 2";


            ////Add UI to the panel
            //pnlSelectPlayer.Controls.Add(promtPlayerUi[0]);
            ////saving index of each Ui
            //promtPlayerUi[promtPlayerUi.Count - 1].playerIndexUi = promtPlayerUi.Count - 1;

            //pnlSelectPlayer.Controls.Add(promtPlayerUi[1]);
            ////Saving index of each Ui
            //promtPlayerUi[promtPlayerUi.Count - 1].playerIndexUi = promtPlayerUi.Count - 1;

            ////Toggle the delete button
            //toggleButton();
        }

        public void loadPromptUi()
        {
            //create new UI
            promtPlayerUi.Add(new PromptUserNameSample());
            promtPlayerUi.Add(new PromptUserNameSample());
            promtPlayerUi[1].lbPlayer.Text = "Player 2";


            //Add UI to the panel
            pnlSelectPlayer.Controls.Add(promtPlayerUi[0]);
            //saving index of each Ui
            promtPlayerUi[promtPlayerUi.Count - 1].playerIndexUi = promtPlayerUi.Count - 1;

            pnlSelectPlayer.Controls.Add(promtPlayerUi[1]);
            //Saving index of each Ui
            promtPlayerUi[promtPlayerUi.Count - 1].playerIndexUi = promtPlayerUi.Count - 1;

            //Toggle the delete button
            toggleButton();
        }
    }
}
