using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class listOfGames :Screen
    {
        public listOfGames() : base("listOfGames")
        {

        }





        public override void Show()
        {
            base.Show();
            Console.WriteLine("Fluffy bird");
            Console.WriteLine("Pac Man");
            Console.WriteLine("Tetris");
            Console.ReadKey();
        }

    }
}
