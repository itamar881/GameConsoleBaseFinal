using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace GameConsoleBase.Pages
{
    internal class GameHistoryScreen: MenuScreen
    {
     

        public GameHistoryScreen() : base("Game History")
        {
            AddMenuItem("list of Games", new listOfGames());
            AddMenuItem("high scores",new highScore());

        }

    }
}
