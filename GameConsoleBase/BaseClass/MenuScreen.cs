using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.BaseClass
{
    internal class MenuScreen : Screen
    {
        // מילון שמכיל פריטים בתפריט
        // המפתח (Key) הוא שם הפריט, והערך (Value) הוא המסך שייפתח כאשר נבחר בפריט
        protected Dictionary<string, Screen> menuItems = new Dictionary<string, Screen>();

        // בנאי (Constructor) של MenuScreen
        // מקבל כותרת (title) ומעביר אותה לבנאי של המחלקה הבסיסית (Screen)
        public MenuScreen(string title) : base(title)
        {

        }

        // שיטה להוספת פריט לתפריט
        // name - שם הפריט שיוצג בתפריט
        // screen - המסך שייפתח כאשר נבחר בפריט
        protected void AddMenuItem(string name, Screen screen)
        {
            menuItems.Add(name, screen);
        }

        // שיטה שמציגה את התפריט על המסך
        public override void Show()
        {
            // מציג את הכותרת של המסך (מוגדר במחלקת Screen)
            base.Show();

            // משתנה שמאפשר לצאת מהלולאה כאשר המשתמש בוחר באפשרות "יציאה"
            bool exit = false;

            // לולאה שממשיכה עד שהמשתמש בוחר לצאת
            while (!exit)
            {
                int index = 1; // מונה עבור מספרי האפשרויות בתפריט
                int choose = 0; // משתנה לשמירת הבחירה של המשתמש

                // הדפסת רשימת האפשרויות בתפריט
                foreach (var item in menuItems.Keys)
                {
                    Console.WriteLine($"{index}-{item}"); // מציג את מספר האפשרות ואת שמה
                    index++;
                }

                // הוספת אפשרות יציאה לתפריט
                Console.WriteLine($"{index}-Exit");
                Console.Write("Choose an option: "); // בקשה מהמשתמש לבחור אפשרות

                // בדיקה אם המשתמש הזין מספר תקין
                if (int.TryParse(Console.ReadLine(), out choose))
                {
                    // אם המשתמש בחר באפשרות חוקית מתוך התפריט
                    if (choose >= 1 && choose < index)
                    {
                        // מציג את המסך המתאים לאפשרות שנבחרה
                        menuItems.ElementAt(choose - 1).Value.Show();
                    }
                    // אם המשתמש בחר באפשרות "יציאה"
                    else if (choose == index)
                    {
                        exit = true; // יציאה מהלולאה
                    }
                    else
                    {
                        // אם המשתמש הזין מספר לא חוקי
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.ReadKey(); // מחכה שהמשתמש ילחץ על מקש כלשהו
                    }
                }
                else
                {
                    // אם המשתמש הזין ערך שאינו מספר
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadKey(); // מחכה שהמשתמש ילחץ על מקש כלשהו
                }

                // מציג מחדש את הכותרת של המסך
                base.Show();
            }
        }
    }
}
