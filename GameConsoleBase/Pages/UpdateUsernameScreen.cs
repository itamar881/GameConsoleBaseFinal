using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
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
    internal class UpdateUsernameScreen : Screen
    {
        public UpdateUsernameScreen() : base("Username update page")
        {
        }

        private bool IsValidUserName(string? userName)
        {
            // שם משתמש חייב להיות לפחות 4 תווים ואינו יכול להיות ריק
            if (string.IsNullOrWhiteSpace(userName) || userName.Length < 4)
            {
                Console.WriteLine("UserName must be at least 4 characters long and cannot be empty.");
                return false;
            }
            return true;
        }


        public override void Show()
        {
            base.Show();
            Console.WriteLine("Enter your new username:");
            string newUsername = Console.ReadLine();
            while (!IsValidUserName(newUsername))
            {
                Console.WriteLine("Enter new username:");
                newUsername = Console.ReadLine();
            }
            GameApp.LoggedUser.UserName = newUsername;
        }
    }
}