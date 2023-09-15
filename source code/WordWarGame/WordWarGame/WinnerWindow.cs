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
    public partial class WinnerWindow : UserControl
    {
        public WinnerWindow()
        {
            InitializeComponent();
        }

        #region GUIs FX
        private void pnlBtLanguageSelect_MouseEnter(object sender, EventArgs e)
        {
            pnlBtLanguageSelect.BackColor = Color.Indigo;
            pictLanguageWhite.Visible = false;
            pictLanguageBlack.Visible = true;
        }

        private void pnlBtLanguageSelect_MouseLeave(object sender, EventArgs e)
        {
            pnlBtLanguageSelect.BackColor = Color.Gainsboro;
            pictLanguageWhite.Visible = true;
            pictLanguageBlack.Visible = false;
        }

        private void pnlBtPlayerVPlayer_MouseEnter(object sender, EventArgs e)
        {
            pnlBtPlayerVPlayer.BackColor = Color.Indigo;
            pictVsWhite.Visible = false;
            pictVsBlack.Visible = true;
        }

        private void pnlBtPlayerVPlayer_MouseLeave(object sender, EventArgs e)
        {
            pnlBtPlayerVPlayer.BackColor = Color.Gainsboro;
            pictVsWhite.Visible = true;
            pictVsBlack.Visible = false;
        }

        private void pnlBtRetry_MouseEnter(object sender, EventArgs e)
        {
            pnlBtRetry.BackColor = Color.Indigo;
            pictRetartWhite.Visible = false;
            pictRetartBlack.Visible = true;
        }

        private void pnlBtRetry_MouseLeave(object sender, EventArgs e)
        {
            pnlBtRetry.BackColor = Color.Gainsboro;
            pictRetartWhite.Visible = true;
            pictRetartBlack.Visible = false;
        }

        private void pnlBtExitApp_MouseEnter(object sender, EventArgs e)
        {
            pnlBtExitApp.BackColor = Color.Crimson;
            pictExitWhite.Visible = false;
            pictExitBlack.Visible = true;
        }

        private void pnlBtExitApp_MouseLeave(object sender, EventArgs e)
        {
            pnlBtExitApp.BackColor = Color.Gainsboro;
            pictExitWhite.Visible = true;
            pictExitBlack.Visible = false;
        }
        




        private void pictLanguageWhite_MouseEnter(object sender, EventArgs e)
        {
            pnlBtLanguageSelect.BackColor = Color.Indigo;
            pictLanguageWhite.Visible = false;
            pictLanguageBlack.Visible = true;
        }

        private void pictLanguageWhite_MouseLeave(object sender, EventArgs e)
        {
            pnlBtLanguageSelect.BackColor = Color.Gainsboro;
            pictLanguageWhite.Visible = true;
            pictLanguageBlack.Visible = false;
        }

        private void pictVsWhite_MouseEnter(object sender, EventArgs e)
        {
            pnlBtPlayerVPlayer.BackColor = Color.Indigo;
            pictVsWhite.Visible = false;
            pictVsBlack.Visible = true;
        }

        private void pictVsWhite_MouseLeave(object sender, EventArgs e)
        {
            pnlBtPlayerVPlayer.BackColor = Color.Gainsboro;
            pictVsWhite.Visible = true;
            pictVsBlack.Visible = false;
        }

        private void pictRetartWhite_MouseEnter(object sender, EventArgs e)
        {
            pnlBtRetry.BackColor = Color.Indigo;
            pictRetartWhite.Visible = false;
            pictRetartBlack.Visible = true;
        }

        private void pictRetartWhite_MouseLeave(object sender, EventArgs e)
        {
            pnlBtRetry.BackColor = Color.Gainsboro;
            pictRetartWhite.Visible = true;
            pictRetartBlack.Visible = false;
        }

        private void pictExitWhite_MouseEnter(object sender, EventArgs e)
        {
            pnlBtExitApp.BackColor = Color.Crimson;
            pictExitWhite.Visible = false;
            pictExitBlack.Visible = true;
        }

        private void pictExitWhite_MouseLeave(object sender, EventArgs e)
        {
            pnlBtExitApp.BackColor = Color.Gainsboro;
            pictExitWhite.Visible = true;
            pictExitBlack.Visible = false;
        }

        #endregion




        public void resetGameFieldsToDefault()
        {
           
            //RESET-->       UcWinningWindows Fields to default ==========================================================================================================================

            //Removing all players record on the Record Table
            for (int i = 0; i < StaticUserControl.ucGameExhibit.playerRecordUi.Count; ++i)
            {
                StaticUserControl.ucWinnerWindow.pnlScoreTable.Controls.Remove(StaticUserControl.ucGameExhibit.orderPlayerRecord.ElementAt(i));
                //StaticUserControl.ucGameExhibit.orderPlayerRecord.
            }

            StaticUserControl.ucGameExhibit.playerRecordUi.Clear();


            #region RESET ExhibitionGame
            //RESET-->       UcExhibitGame Fields to default ==============================================================================================================================
            StaticUserControl.ucGameExhibit.clickCount = 0;
            StaticUserControl.ucGameExhibit.score = 0;
            StaticUserControl.ucGameExhibit.isWordValid = false;

            StaticUserControl.ucGameExhibit.numOfValidLetters = 0;
            StaticUserControl.ucGameExhibit.gameplayRotation = 0;//keeping count of the rotation between player-->   it will allow an accurate calculation for the score
            StaticUserControl.ucGameExhibit.wordLength = 0;
            StaticUserControl.ucGameExhibit.wordTocheck = null;
            StaticUserControl.ucGameExhibit.wordChar = null;

            StaticUserControl.ucGameExhibit.alphaLetters.Clear();
            StaticUserControl.ucGameExhibit.loadAlphabet();

            //Reset Score
            for (int i = 0; i < StaticUserControl.ucGameExhibit.scoreUis.Count; ++i)
            {
                StaticUserControl.ucGameExhibit.scoreUis[i].lbScore.Text = "00";
            }

            StaticUserControl.ucGameExhibit.currentPlayerNum = 0;
            StaticUserControl.ucGameExhibit.lbPlayerNum.Text = "Player 1";
            StaticUserControl.ucGameExhibit.lbPlayerName.Text = StaticUserControl.ucGameExhibit.players[0];

            for (int i = 0; i < StaticUserControl.ucGameExhibit.alphaLetters.Count; ++i)
            {
                StaticUserControl.ucGameExhibit.alphaLetters[i].Visible = true;
            }

            StaticUserControl.ucGameExhibit.lbInputStatusValue.Visible = false;

            StaticUserControl.ucGameExhibit.pnlScoreTable.Controls.Clear();
            StaticUserControl.ucGameExhibit.scoreUis.Clear();
            StaticUserControl.ucGameExhibit.playerRecordUi.Clear();
            StaticUserControl.ucGameExhibit.players.Clear();
            #endregion


            //RESET-->      ucPromptUsername to default ==================================================================================================================================
            StaticUserControl.ucPromptName.promtPlayerUi.Clear();
            StaticUserControl.ucPromptName.pnlSelectPlayer.Controls.Clear();
            StaticUserControl.ucPromptName.playerNames.Clear();
        }



        #region Click Events Handler

        #region Return To ucSelectLanguage
        //Return to ucSelectLanguage =========================================================================================================================
        private void pnlBtLanguageSelect_Click(object sender, EventArgs e)
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucWinnerWindow.Visible = false;

            StaticUserControl.ucSelectLanguage.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectLanguage);
            resetGameFieldsToDefault();

            //StaticUserControl.ucPromptName.loadPromptUi();
        }

        private void pictLanguageBlack_Click(object sender, EventArgs e)
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucWinnerWindow.Visible = false;

            StaticUserControl.ucSelectLanguage.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectLanguage);
            resetGameFieldsToDefault();

            //StaticUserControl.ucPromptName.loadPromptUi();
        }
        
        private void pictLanguageWhite_Click(object sender, EventArgs e)
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucWinnerWindow.Visible = false;

            StaticUserControl.ucSelectLanguage.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectLanguage);
            resetGameFieldsToDefault();

            //StaticUserControl.ucPromptName.loadPromptUi();
        }
        #endregion


        #region Return To ucSelectOpponent
        //Return To ucSelectOpponent =========================================================================================================================
        private void pnlBtPlayerVPlayer_Click(object sender, EventArgs e)
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucWinnerWindow.Visible = false;

            StaticUserControl.ucSelectOponent.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectOponent);
            resetGameFieldsToDefault();

            StaticUserControl.ucMainSwitcher.pictBtnBackBlack.Visible = true;
            StaticUserControl.ucMainSwitcher.pictBtnBackWhite.Visible = true;

            //StaticUserControl.ucPromptName.loadPromptUi();
        }

        private void pictVsBlack_Click(object sender, EventArgs e)
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucWinnerWindow.Visible = false;

            StaticUserControl.ucSelectOponent.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectOponent);
            resetGameFieldsToDefault();

            StaticUserControl.ucMainSwitcher.pictBtnBackBlack.Visible = true;
            StaticUserControl.ucMainSwitcher.pictBtnBackWhite.Visible = true;

            //StaticUserControl.ucPromptName.loadPromptUi();
        }

        private void pictVsWhite_Click(object sender, EventArgs e)
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucWinnerWindow.Visible = false;

            StaticUserControl.ucSelectOponent.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucSelectOponent);
            resetGameFieldsToDefault();

            StaticUserControl.ucMainSwitcher.pictBtnBackBlack.Visible = true;
            StaticUserControl.ucMainSwitcher.pictBtnBackWhite.Visible = true;

            //StaticUserControl.ucPromptName.loadPromptUi();
        }

        #endregion


        #region Restart the Previous Game
        //Restart the Previous Game =========================================================================================================================
        private void pnlBtRetry_Click(object sender, EventArgs e)
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucWinnerWindow.Visible = false;

            StaticUserControl.ucGameExhibit.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucGameExhibit);

            #region RESET ExhibitionGame
            //RESET-->       UcExhibitGame Fields to default ==============================================================================================================================
            StaticUserControl.ucGameExhibit.clickCount = 0;
            StaticUserControl.ucGameExhibit.score = 0;
            StaticUserControl.ucGameExhibit.isWordValid = false;

            StaticUserControl.ucGameExhibit.numOfValidLetters = 0;
            StaticUserControl.ucGameExhibit.gameplayRotation = 0;//keeping count of the rotation between player-->   it will allow an accurate calculation for the score
            StaticUserControl.ucGameExhibit.wordLength = 0;
            StaticUserControl.ucGameExhibit.wordTocheck = null;
            StaticUserControl.ucGameExhibit.wordChar = null;

            StaticUserControl.ucGameExhibit.alphaLetters.Clear();
            StaticUserControl.ucGameExhibit.loadAlphabet();

            //Reset Score
            for (int i = 0; i < StaticUserControl.ucGameExhibit.scoreUis.Count; ++i)
            {
                StaticUserControl.ucGameExhibit.scoreUis[i].lbScore.Text = "00";
            }

            StaticUserControl.ucGameExhibit.currentPlayerNum = 0;
            StaticUserControl.ucGameExhibit.lbPlayerNum.Text = "Player 1";
            StaticUserControl.ucGameExhibit.lbPlayerName.Text = StaticUserControl.ucGameExhibit.players[0];

            for (int i = 0; i < StaticUserControl.ucGameExhibit.alphaLetters.Count; ++i)
            {
                StaticUserControl.ucGameExhibit.alphaLetters[i].Visible = true;
            }

            pnlScoreTable.Controls.Clear();

            StaticUserControl.ucGameExhibit.lbInputStatusValue.Visible = false;
            #endregion
        }

        private void pictRetartBlack_Click(object sender, EventArgs e)
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucWinnerWindow.Visible = false;

            StaticUserControl.ucGameExhibit.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucGameExhibit);

            #region RESET ExhibitionGame
            //RESET-->       UcExhibitGame Fields to default ==============================================================================================================================
            StaticUserControl.ucGameExhibit.clickCount = 0;
            StaticUserControl.ucGameExhibit.score = 0;
            StaticUserControl.ucGameExhibit.isWordValid = false;

            StaticUserControl.ucGameExhibit.numOfValidLetters = 0;
            StaticUserControl.ucGameExhibit.gameplayRotation = 0;//keeping count of the rotation between player-->   it will allow an accurate calculation for the score
            StaticUserControl.ucGameExhibit.wordLength = 0;
            StaticUserControl.ucGameExhibit.wordTocheck = null;
            StaticUserControl.ucGameExhibit.wordChar = null;

            StaticUserControl.ucGameExhibit.alphaLetters.Clear();
            StaticUserControl.ucGameExhibit.loadAlphabet();

            //Reset Score
            for (int i = 0; i < StaticUserControl.ucGameExhibit.scoreUis.Count; ++i)
            {
                StaticUserControl.ucGameExhibit.scoreUis[i].lbScore.Text = "00";
            }

            StaticUserControl.ucGameExhibit.currentPlayerNum = 0;
            StaticUserControl.ucGameExhibit.lbPlayerNum.Text = "Player 1";
            StaticUserControl.ucGameExhibit.lbPlayerName.Text = StaticUserControl.ucGameExhibit.players[0];

            for (int i = 0; i < StaticUserControl.ucGameExhibit.alphaLetters.Count; ++i)
            {
                StaticUserControl.ucGameExhibit.alphaLetters[i].Visible = true;
            }

            pnlScoreTable.Controls.Clear();

            StaticUserControl.ucGameExhibit.lbInputStatusValue.Visible = false;
            #endregion
        }

        private void pictRetartWhite_Click(object sender, EventArgs e)
        {
            StaticUserControl.ucMainSwitcher.Controls.Remove(this);
            StaticUserControl.ucWinnerWindow.Visible = false;

            StaticUserControl.ucGameExhibit.Visible = true;
            StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucGameExhibit);

            #region RESET ExhibitionGame
            //RESET-->       UcExhibitGame Fields to default ==============================================================================================================================
            StaticUserControl.ucGameExhibit.clickCount = 0;
            StaticUserControl.ucGameExhibit.score = 0;
            StaticUserControl.ucGameExhibit.isWordValid = false;

            StaticUserControl.ucGameExhibit.numOfValidLetters = 0;
            StaticUserControl.ucGameExhibit.gameplayRotation = 0;//keeping count of the rotation between player-->   it will allow an accurate calculation for the score
            StaticUserControl.ucGameExhibit.wordLength = 0;
            StaticUserControl.ucGameExhibit.wordTocheck = null;
            StaticUserControl.ucGameExhibit.wordChar = null;

            StaticUserControl.ucGameExhibit.alphaLetters.Clear();
            StaticUserControl.ucGameExhibit.loadAlphabet();

            //Reset Score
            for (int i = 0; i < StaticUserControl.ucGameExhibit.scoreUis.Count; ++i)
            {
                StaticUserControl.ucGameExhibit.scoreUis[i].lbScore.Text = "00";
            }

            StaticUserControl.ucGameExhibit.currentPlayerNum = 0;
            StaticUserControl.ucGameExhibit.lbPlayerNum.Text = "Player 1";
            StaticUserControl.ucGameExhibit.lbPlayerName.Text = StaticUserControl.ucGameExhibit.players[0];

            for (int i = 0; i < StaticUserControl.ucGameExhibit.alphaLetters.Count; ++i)
            {
                StaticUserControl.ucGameExhibit.alphaLetters[i].Visible = true;
            }

            pnlScoreTable.Controls.Clear();

            StaticUserControl.ucGameExhibit.lbInputStatusValue.Visible = false;
            #endregion
        }
        #endregion


        #region Exit The App
        //Exit The App =========================================================================================================================
        private void pnlBtExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictExitBlack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictExitWhite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #endregion
    }
}
