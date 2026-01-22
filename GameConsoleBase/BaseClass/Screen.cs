using GameConsoleBase.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.BaseClass
{
    internal class Screen
    {
        // משתנה פרטי שמחזיק את הכותרת של המסך
        private string title;

        // בנאי (Constructor) של המחלקה Screen
        // מקבל כותרת (title) ושומר אותה במשתנה הפרטי
        public Screen(string title)
        {
            this.title = title;
        }

        // שיטה שמציגה את המסך
        // מנקה את המסך, מציגה את הכותרת במרכז המסך בצבע מג'נטה, ואז מאפסת את הצבעים
        public virtual void Show()
        {
            Console.Clear(); // מנקה את המסך
            Console.ForegroundColor = ConsoleColor.Magenta; // משנה את צבע הטקסט למג'נטה
            CenterText(title); // מציג את הכותרת במרכז המסך
            Console.ResetColor(); // מאפס את הצבעים לברירת המחדל
        }

        // שיטה שמציגה טקסט במרכז השורה הנוכחית
        // text - הטקסט שברצוננו להציג
        public void CenterText(string text)
        {
            // מחשבת את המיקום האופקי כך שהטקסט יוצג במרכז השורה
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.CursorTop);
            Console.WriteLine(text); // מציגה את הטקסט
        }

        // שיטה שמציגה טקסט במרכז המסך (אופקית ואנכית)
        // text - הטקסט שברצוננו להציג
        public void HorizontalCenter(string text)
        {
            // מחשבת את המיקום האופקי והאנכי כך שהטקסט יוצג במרכז המסך
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2 - Console.CursorTop / 2);
            Console.WriteLine(text); // מציגה את הטקסט
        }
    }
}
