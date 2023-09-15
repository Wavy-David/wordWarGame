using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWarGame
{
    static public class StaticUserControl
    {
        //-->MainSwitcher
        static public MainSwitcher ucMainSwitcher = new MainSwitcher();

        //--> Select language
        static public SelectLanguage ucSelectLanguage = new SelectLanguage();

        //--> Select Opponent
        static public SelectOponent ucSelectOponent = new SelectOponent();

        //--> Prompt user Name
        static public promptUserName ucPromptName = new promptUserName();

        //--> Game Exhibition UserControl
        static public GameExhibit ucGameExhibit = new GameExhibit();

        //--> Winner Window
        static public WinnerWindow ucWinnerWindow = new WinnerWindow();
        
    }
}
