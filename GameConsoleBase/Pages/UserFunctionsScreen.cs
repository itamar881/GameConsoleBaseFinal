using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class UserFunctionsScreen : MenuScreen
    {
        public UserFunctionsScreen() : base("User Functions")
        {
            AddMenuItem("View game history", new GameHistoryScreen());
            AddMenuItem("View user details", new ViewUserScreen());
            AddMenuItem("Update password", new UpdatePasswordScreen());
            AddMenuItem("Update username", new UpdateUsernameScreen());
            

        }
    }
}
