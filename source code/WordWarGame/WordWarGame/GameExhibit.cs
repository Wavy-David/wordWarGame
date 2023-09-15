using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSpell;
using Microsoft.ProjectOxford;


namespace WordWarGame
{
    public partial class GameExhibit : UserControl
    {
        //keeping track of the clicks of the submit button--> allows the cpu rotate(switch) from player 1 to the last Player
        public int paintLoaderCount = 0;
        public int clickLimit = 0;
        public int clickCount = 0;
        public int score = 0;
        public bool isWordValid = false;

        //Stores the number/ count of all the letters of the input word that are in the alphabet
        public int numOfValidLetters = 0;

        public int gameplayRotation = 0;//keeping count of the rotation between player-->   it will allow an accurate calculation for the score

        public int wordLength = 0;
        public string wordTocheck = null;
        public string wordChar = null;
        //this list will store all the letters of the alphabet
        public List<Label> alphaLetters = new List<Label>();

        public List<string> players = new List<string>();
        public List<PlayerScoreSample> scoreUis = new List<PlayerScoreSample>();

        //get the number of the player that is currently playing
        public int currentPlayerNum = 0;

        //List of player and their Scores for the Rankin in the Table
        public List<PlayerRecordSample> playerRecordUi = new List<PlayerRecordSample>();

        //IEnumerable to Sort Record by Score
        public IEnumerable<PlayerRecordSample> orderPlayerRecord;

        public GameExhibit()
        {
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (tbWord.Text.Equals(null) || tbWord.Text.Equals(""))
            {
                MessageBox.Show("Exception!\n\nthe Text box is empty\n\nFill up the text box");
            }
            else
            {
                clickCount += 1;

                if (clickCount <= clickLimit)//--> as long as the click count is less than the click limit, run the if-Statement
                {
                    currentPlayerNum = clickCount;

                    if (clickCount == clickLimit)
                    {
                        //reseting clickCount and returning to player 1
                        clickCount = 0;
                        lbPlayerNum.Text = "Player " + (clickCount + 1);
                        lbPlayerName.Text = players[clickCount];
                    }
                    else
                    {
                        //rotating(switching) players one after another
                        lbPlayerNum.Text = "Player " + (clickCount + 1);
                        lbPlayerName.Text = players[clickCount];
                    }
                }

                gamePlay();
                tbWord.Text = null;
                numOfValidLetters = 0;
            }
            
        }

        #region Load Alphabet Letters
        public void loadAlphabet()
        {
            alphaLetters.Add(lb_A);
            alphaLetters.Add(lb_B);
            alphaLetters.Add(lb_C);
            alphaLetters.Add(lb_D);
            alphaLetters.Add(lb_E);
            alphaLetters.Add(lb_F);
            alphaLetters.Add(lb_G);
            alphaLetters.Add(lb_H);
            alphaLetters.Add(lb_i);
            alphaLetters.Add(lb_J);
            alphaLetters.Add(lb_K);
            alphaLetters.Add(lb_L);
            alphaLetters.Add(lb_M);
            alphaLetters.Add(lb_N);
            alphaLetters.Add(lb_O);
            alphaLetters.Add(lb_P);
            alphaLetters.Add(lb_Q);
            alphaLetters.Add(lb_R);
            alphaLetters.Add(lb_S);
            alphaLetters.Add(lb_T);
            alphaLetters.Add(lb_U);
            alphaLetters.Add(lb_V);
            alphaLetters.Add(lb_W);
            alphaLetters.Add(lb_X);
            alphaLetters.Add(lb_Y);
            alphaLetters.Add(lb_Z);
        }
        #endregion

        //check is a Char is not a Vowell
        private bool scanVowells(char myChar)
        {
            bool validation = false;

            //scanning for vowels
            if (!myChar.ToString().Equals("a", StringComparison.OrdinalIgnoreCase) && !myChar.ToString().Equals("e", StringComparison.OrdinalIgnoreCase) &&
                !myChar.ToString().Equals("i", StringComparison.OrdinalIgnoreCase) && !myChar.ToString().Equals("o", StringComparison.OrdinalIgnoreCase) &&
                !myChar.ToString().Equals("u", StringComparison.OrdinalIgnoreCase) && !myChar.ToString().Equals("y", StringComparison.OrdinalIgnoreCase)
                )
            {
                validation = true;
            }
            return validation;
        }

        //Check is a word is made up of vowel only such as "You"--> if so, the word is invalid
        private bool isWordVowelOnly(string word)
        {
            bool isVowelOnly = false;
            int invalidChar = 0;

            for (int i = 0; i < word.Length; ++i)
            {
                if (word[i].ToString().Equals("a", StringComparison.OrdinalIgnoreCase) || word[i].ToString().Equals("e", StringComparison.OrdinalIgnoreCase) ||
                word[i].ToString().Equals("i", StringComparison.OrdinalIgnoreCase) || word[i].ToString().Equals("o", StringComparison.OrdinalIgnoreCase) ||
                word[i].ToString().Equals("u", StringComparison.OrdinalIgnoreCase) || word[i].ToString().Equals("y", StringComparison.OrdinalIgnoreCase)
                )
                {
                    invalidChar += 1;
                }
            }

            if (invalidChar == wordLength)
            {
                isVowelOnly = true;
            }

            return isVowelOnly;
        }

        private void gamePlay()
        {
            gameplayRotation += 1;

            //Creating Dictionary Object
            NetSpell.SpellChecker.Dictionary.WordDictionary dictionaryEn = new NetSpell.SpellChecker.Dictionary.WordDictionary();

            //Assigning dictionary version/language -->         you can only use the dictionary once they're in the debug folder
            dictionaryEn.DictionaryFile = "en-US.dic";

            //Initializing dictionary -->       the dictionary is now usable
            dictionaryEn.Initialize();

            //Assigning the word that will be checked to a string var
            wordTocheck = tbWord.Text;

            //creating a spelling object-->     spelling class encapsulate all necessary propreties & functions to check spelling
            NetSpell.SpellChecker.Spelling wordSpelling = new NetSpell.SpellChecker.Spelling();

            //Assigning a dictionary to the spelling Object
            wordSpelling.Dictionary = dictionaryEn;

            //check if the word is in the dictionary
            if (wordSpelling.TestWord(wordTocheck) == true)
            {
                isWordValid = true;

                wordLength = wordTocheck.Length;

                for (int a = 0; a < wordLength; ++a)//-->   iterate through each and every character from the string
                {
                    for(int b = 0; b < alphaLetters.Count; ++b)
                    {
                        if (wordTocheck[a].ToString().Equals(alphaLetters[b].Text, StringComparison.OrdinalIgnoreCase))//--> Check if consonants are equal, if the word is valid--> the number of valid characters must be equal to the string.count of the word
                        {
                            //count all valid Chars
                            numOfValidLetters += 1;
                        }
                    }
                }


                //Hidding used letters
                for (int a = 0; a < wordLength; ++a)//-->   iterate through each and every character from the string
                {
                    for (int b = 0; b < alphaLetters.Count; ++b)
                    {
                        if (wordTocheck[a].ToString().Equals(alphaLetters[b].Text, StringComparison.OrdinalIgnoreCase))//--> Check if consonants are equal
                        {
                            if (scanVowells(wordTocheck[a]) && numOfValidLetters == wordLength)//-->   Check if the char is not a vowel--> if the char is not a vowel run the code... Allow to keep all vowel in the alphabet
                            {
                                alphaLetters[b].Visible = false;
                            }
                        }
                    }
                }

                //Removing all the letters of the Word from the Alphabet(AlphaLetters)
                for (int a = 0; a < wordLength; ++a)
                {
                    for (int b = 0; b < alphaLetters.Count; ++b)
                    {
                        if (scanVowells(wordTocheck[a]))//-->   Check if the char is a vowel
                        {
                            if (wordTocheck[a].ToString().Equals(alphaLetters[b].Text, StringComparison.OrdinalIgnoreCase) && numOfValidLetters == wordLength)//--> Check if consonants are equal 
                            {
                                alphaLetters.Remove(alphaLetters[b]);
                            }
                        }
                    }
                }

            }
            else
            {
                lbInputStatusValue.Text = "Wrong";
                lbInputStatusValue.ForeColor = Color.Crimson;
                lbInputStatusValue.Visible = true;
                isWordValid = false;
            }
            
            //Scoring =====================================================================================================================
            if (isWordValid == true && numOfValidLetters == wordLength && isWordVowelOnly(wordTocheck) != true)
            {
                if (gameplayRotation == 1)
                {
                    score = 0;
                }
                else
                {
                    score = Convert.ToInt32(scoreUis[currentPlayerNum - 1].lbScore.Text);
                }
                score += 1;

                //update score
                if (score < 10)
                {
                    scoreUis[currentPlayerNum - 1].lbScore.Text = "0" + score.ToString();
                }
                else
                {
                    scoreUis[currentPlayerNum - 1].lbScore.Text = score.ToString();
                }

                lbInputStatusValue.Text = "Correct";
                lbInputStatusValue.ForeColor = Color.MediumSpringGreen;
                lbInputStatusValue.Visible = true;
            }
            else
            {
                if (isWordVowelOnly(wordTocheck) == true)
                {
                    //lbInputStatusValue.Text = "Word Should not Contain Vowels Only";
                    lbInputStatusValue.Text = "Wrong";
                }
                else
                {
                    lbInputStatusValue.Text = "Wrong";
                }
                lbInputStatusValue.ForeColor = Color.Crimson;
                lbInputStatusValue.Visible = true;
            }
        }

        private void btRetry_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to restart ?", "Restart Game !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //clickLimit = 0;
                clickCount = 0;
                score = 0;
                isWordValid = false;

                numOfValidLetters = 0;
                gameplayRotation = 0;//keeping count of the rotation between player-->   it will allow an accurate calculation for the score
                wordLength = 0;
                wordTocheck = null;
                wordChar = null;

                alphaLetters.Clear();
                loadAlphabet();

                //Reset Score
                for (int i = 0; i < scoreUis.Count; ++i)
                {
                    scoreUis[i].lbScore.Text = "00";
                }

                currentPlayerNum = 0;
                lbPlayerNum.Text = "Player 1";
                lbPlayerName.Text = players[0];

                tbWord.Text = "";

                for (int i = 0; i < alphaLetters.Count; ++i)
                {
                    alphaLetters[i].Visible = true;
                }

                lbInputStatusValue.Visible = false;
            }

        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to end the Game ?", "End Game !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                #region End Game Codes

                StaticUserControl.ucMainSwitcher.Controls.Remove(this);
                StaticUserControl.ucGameExhibit.Visible = false;

                StaticUserControl.ucMainSwitcher.Controls.Add(StaticUserControl.ucWinnerWindow);
                StaticUserControl.ucWinnerWindow.Visible = true;

                playerRecordUi.Clear();

                if (players.Count > 2)
                {
                    StaticUserControl.ucWinnerWindow.pnlScoreTable.Height = 141;
                    StaticUserControl.ucWinnerWindow.panel19.Location = new Point(374, 220);
                }

                for (int i = 0; i < players.Count; ++i)
                {
                    playerRecordUi.Add(new PlayerRecordSample());

                    //allocating the correct num to the correct player 
                    playerRecordUi[i].lbPlayerNum.Text = "Player " + scoreUis[i].lbPlayerNum.Text[2];
                    //allocating the correct name to the correct player
                    playerRecordUi[i].lbPlayerName.Text = scoreUis[i].lbPlayerName.Text;
                    //allocating the correct score to the correct player
                    playerRecordUi[i].lbPlayerScore.Text = scoreUis[i].lbScore.Text;
                }

                //sorting player according to Score
                //playerRecordUi.Sort((a, b) => (a.lbPlayerScore.Text.CompareTo(b.lbPlayerScore.Text)));//--> this lambda expression did not sort in a descending order

                //Using IEnumerable to Sort Record by Score
                orderPlayerRecord = from PlayerRecord in playerRecordUi
                                    orderby PlayerRecord.lbPlayerScore.Text descending
                                    select PlayerRecord;


                //Adding all players record on the Record Table
                for (int i = 0; i < playerRecordUi.Count; ++i)
                {
                    //playerRecordUi[i].lbRank.Text = (i + 1).ToString();
                    //StaticUserControl.ucWinnerWindow.pnlScoreTable.Controls.Add(playerRecordUi[i]);

                    orderPlayerRecord.ElementAt(i).lbRank.Text = (i + 1).ToString();
                    StaticUserControl.ucWinnerWindow.pnlScoreTable.Controls.Add(orderPlayerRecord.ElementAt(i));
                }

                #endregion

                #region Winner Presentation

                int tally = 0;
                double result = 0;

                for (int i = 0; i < playerRecordUi.Count; ++i)
                {
                    tally += Convert.ToInt32(playerRecordUi[i].lbPlayerScore.Text);
                }

                result = tally / playerRecordUi.Count;

                //MessageBox.Show("Tally: " + tally + "\n\n" + "Num of Players: " + playerRecordUi.Count + "\n\n" +
                //    "player1 Score: " + orderPlayerRecord.ElementAt(0).lbPlayerScore.Text + "\n\n" + "Result: " + result.ToString());

                //if the result equals to one of the players score, it means that all the players had the same Score, Hence the game was equal
                if (result == Convert.ToInt32(orderPlayerRecord.ElementAt(0).lbPlayerScore.Text))//--> Checking if the game was a draw
                {
                    StaticUserControl.ucWinnerWindow.lbWinner.Visible = false;
                    StaticUserControl.ucWinnerWindow.lbPlayerName.Visible = false;
                    StaticUserControl.ucWinnerWindow.lbDraw.Visible = true;

                    StaticUserControl.ucWinnerWindow.pictWinner.Visible = false;
                    StaticUserControl.ucWinnerWindow.pictDrawTie.Visible = true;
                }
                else
                {
                    StaticUserControl.ucWinnerWindow.lbWinner.Visible = true;
                    StaticUserControl.ucWinnerWindow.lbPlayerName.Visible = true;
                    StaticUserControl.ucWinnerWindow.lbDraw.Visible = false;

                    StaticUserControl.ucWinnerWindow.pictWinner.Visible = true;
                    StaticUserControl.ucWinnerWindow.pictDrawTie.Visible = false;

                    StaticUserControl.ucWinnerWindow.lbPlayerName.Text = orderPlayerRecord.ElementAt(0).lbPlayerName.Text;
                }
                #endregion
            }

        }

        private void GameExhibit_Paint(object sender, PaintEventArgs e)
        {
            //paintLoaderCount += 1;

            ////the paint method runs everytime the user clicks on the Restart button.
            ////everytime the GameExhibit_Paint event runs, the loadAlphabet() method runs, causing the alphabet count to increase to 52
            ////hence affecting the scoring process(makes word invalid for scoring).
            ////this if statement will allow the loadAlphabet() method to run once while the paint method will keep on runing many time
            //if (paintLoaderCount == 1)
            //{
            //    //load the alphaLetters
            //    loadAlphabet();
            //}
            

            ////loading all names into players
            //players = StaticUserControl.ucPromptName.playerNames;

            //clickLimit = StaticUserControl.ucPromptName.playerNames.Count;
            //lbPlayerNum.Text = "Player 1";
            //lbPlayerName.Text = players[0];

            //for (int i = 0; i < StaticUserControl.ucPromptName.playerNames.Count; ++i)
            //{
            //    scoreUis.Add(new PlayerScoreSample());

            //    scoreUis[i].lbPlayerNum.Text = "P " + (i + 1);
            //    scoreUis[i].lbPlayerName.Text = players[i];

            //    pnlScoreTable.Controls.Add(scoreUis[i]);
            //}
        }

        private void GameExhibit_Load(object sender, EventArgs e)
        {
            //paintLoaderCount += 1;

            ////the paint method runs everytime the user clicks on the Restart button.
            ////everytime the GameExhibit_Paint event runs, the loadAlphabet() method runs, causing the alphabet count to increase to 52
            ////hence affecting the scoring process(makes word invalid for scoring).
            ////this if statement will allow the loadAlphabet() method to run once while the paint method will keep on runing many time
            //if (paintLoaderCount == 1)
            //{
            //    //load the alphaLetters
            //    loadAlphabet();
            //}


            ////loading all names into players
            //players = StaticUserControl.ucPromptName.playerNames;

            //clickLimit = StaticUserControl.ucPromptName.playerNames.Count;
            //lbPlayerNum.Text = "Player 1";
            //lbPlayerName.Text = players[0];

            //for (int i = 0; i < StaticUserControl.ucPromptName.playerNames.Count; ++i)
            //{
            //    scoreUis.Add(new PlayerScoreSample());

            //    scoreUis[i].lbPlayerNum.Text = "P " + (i + 1);
            //    scoreUis[i].lbPlayerName.Text = players[i];

            //    pnlScoreTable.Controls.Add(scoreUis[i]);
            //}


            //loadGameExhibitField();
        }

        public void loadGameExhibitField()
        {
            paintLoaderCount += 1;

            //the paint method runs everytime the user clicks on the Restart button.
            //everytime the GameExhibit_Paint event runs, the loadAlphabet() method runs, causing the alphabet count to increase to 52
            //hence affecting the scoring process(makes word invalid for scoring).
            //this if statement will allow the loadAlphabet() method to run once while the paint method will keep on runing many time
            if (paintLoaderCount == 1)
            {
                //load the alphaLetters
                loadAlphabet();
            }


            //loading all names into players
            players = StaticUserControl.ucPromptName.playerNames;

            clickLimit = StaticUserControl.ucPromptName.playerNames.Count;
            lbPlayerNum.Text = "Player 1";
            lbPlayerName.Text = players[0];

            for (int i = 0; i < StaticUserControl.ucPromptName.playerNames.Count; ++i)
            {
                scoreUis.Add(new PlayerScoreSample());

                scoreUis[i].lbPlayerNum.Text = "P " + (i + 1);
                scoreUis[i].lbPlayerName.Text = players[i];

                pnlScoreTable.Controls.Add(scoreUis[i]);
            }
        }
    }
}
