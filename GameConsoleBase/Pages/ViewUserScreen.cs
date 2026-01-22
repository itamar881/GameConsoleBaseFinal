using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class ViewUserScreen : Screen
    {
        public ViewUserScreen() : base("View User Screen")
        {
        }
        public override void Show()
        {
            base.Show();

            string userDetails = $"current user details are {GameApp.LoggedUser.UserName}\n{GameApp.LoggedUser.Password}";
            HorizontalCenter(userDetails);
            Console.ReadKey();
            
        }
    }
}
