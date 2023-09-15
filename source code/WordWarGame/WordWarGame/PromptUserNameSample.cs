using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordWarGame
{
    public partial class PromptUserNameSample : UserControl
    {
        //Allows the AI to know when to save normaly and when to save an edited input
        public bool isEditClick = false;

        //saves the index of this object from the playerNames list --> for updating the player's name with precision through indexes
        public int playerIndex = 0;

        //saves the index of this object from the promptPlayerUi list --> for updating the player's name with precision through indexes
        public int playerIndexUi = 0;
        

        public PromptUserNameSample()
        {
            InitializeComponent();
        }

        private void tbNameOfPlayer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //limiting input to specific character
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnSaveName_Click(object sender, EventArgs e)
        {
            //save edited input
            if(isEditClick == true)
            {
                StaticUserControl.ucPromptName.playerNames[playerIndex] = this.tbNameOfPlayer.Text;//--> updating name of a specific Player
                //MessageBox.Show("Player Saved !\n\n" + "Player " + (this.playerIndex + 1) + ":      " + StaticUserControl.ucPromptName.playerNames[this.playerIndex]);

                this.pictCrossFailed.Visible = false;
                this.pictElipsesLoading.Visible = false;
                this.pictTickSuccess.Visible = true;

                this.btnSaveName.Enabled = false;
                this.tbNameOfPlayer.Enabled = false;
                this.btnEditName.Enabled = true;

                isEditClick = false;
            }
            else
            {
                // validation --> Making sure that user saves player according to numerical order
                if (this.playerIndexUi == StaticUserControl.ucPromptName.playerNames.Count)//--> comparing index playerInput_Ui   and   index list_of_players, before saving the 1st player the playerNames list count must be 0, before saving the second player the playerNames.count must be 1 and so on  
                {
                    //save normal input
                    if (!this.tbNameOfPlayer.Text.Equals(null) && !this.tbNameOfPlayer.Text.Equals(""))//--> validating if the textbox is not empty 
                    {
                        StaticUserControl.ucPromptName.playerNames.Add(this.tbNameOfPlayer.Text);//--> Adding name to the list of PlayerNames
                        playerIndex = StaticUserControl.ucPromptName.playerNames.Count - 1;//--> saving the index of the new added name
                        //MessageBox.Show("Player Saved !\n\n" + "Player " + (StaticUserControl.ucPromptName.playerNames.Count) + ":      " + StaticUserControl.ucPromptName.playerNames[StaticUserControl.ucPromptName.playerNames.Count - 1]);

                        this.pictCrossFailed.Visible = false;
                        this.pictElipsesLoading.Visible = false;
                        this.pictTickSuccess.Visible = true;

                        this.btnSaveName.Enabled = false;
                        this.tbNameOfPlayer.Enabled = false;
                        this.btnEditName.Enabled = true;

                        isEditClick = false;
                    }
                    else
                    {
                        //exception for empty textbox
                        MessageBox.Show("Fill up the texbox before saving");
                        this.pictElipsesLoading.Visible = false;
                        this.pictTickSuccess.Visible = false;
                        this.pictCrossFailed.Visible = true;
                    }
                }
                else
                {
                    //exception when user try to save player in disorder( not in a numerical order)
                    MessageBox.Show("Make sure That All previous Players are Saved");
                    this.pictElipsesLoading.Visible = false;
                    this.pictTickSuccess.Visible = false;
                    this.pictCrossFailed.Visible = true;
                }
            }

            //isEditClick = false;
            //MessageBox.Show("player list count "+StaticUserControl.ucPromptName.playerNames.Count);
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            this.btnSaveName.Enabled = true;
            this.tbNameOfPlayer.Enabled = true;
            this.btnEditName.Enabled = false;

            this.pictTickSuccess.Visible = false;
            this.pictCrossFailed.Visible = false;
            this.pictElipsesLoading.Visible = true;
            //StaticUserControl.ucPromptName.currentPlayer = this.lbPlayer.Text;
            //StaticUserControl.ucPromptName.currentPlayerName = this.tbNameOfPlayer.Text;
            this.isEditClick = true;
        }
    }
}
