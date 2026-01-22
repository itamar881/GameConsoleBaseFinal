using GameConsoleBase.BaseClass;
using GameConsoleBase.Models;
using GameConsoleBase.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.App
{
    internal class GameApp
    {
        // מסך ראשי של האפליקציה
        private Screen MainPage;

        // משתמש מחובר - נשמר כמשתנה סטטי כדי שנוכל לגשת אליו מכל מקום בתוכנית
        public static User LoggedUser;

        // בנאי (Constructor) של GameApp
        // כאן אנחנו מגדירים את המסך הראשי של האפליקציה כ- WelcomeScreen
        public GameApp() {
            MainPage = new WelcomeScreen();
        }

        // שיטה שמתחילה את האפליקציה
        // היא מציגה את המסך הראשי (MainPage)
        public void StartApp()
        {
            MainPage.Show();
        }
    }
}
