using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.DB;
using GameConsoleBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class UpdatePasswordScreen : Screen
    {
        public UpdatePasswordScreen() : base("Update Password Screen")
        {
        }
        private bool IsValidPassword(string? password)
        {
            // סיסמה חייבת להיות לפחות 6 תווים, להכיל את הסימן '@', ואינה יכולה להיות ריקה
            if (password == null || password.Length < 6 || password.Contains("@") || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Password must be at least 6 characters long and contain '@' symbol.");
                return false;
            }
            return true;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Enter your new Password");
            string NewPassword = Console.ReadLine();
            while (!IsValidPassword(NewPassword))
            {
                Console.WriteLine("Enter your new Password");
                NewPassword = Console.ReadLine();
            }
            GameApp.LoggedUser.Password = NewPassword;

        }

    }
}