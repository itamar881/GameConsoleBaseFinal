using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class OptionMenuScreen : MenuScreen
    {
        public OptionMenuScreen() : base("Choose action")
        {
            AddMenuItem("Games", new GameMenuScreen());
            AddMenuItem("User function", new UserFunctionsScreen());
            AddMenuItem("Game History", new GameHistoryScreen());

        }
    }
}
