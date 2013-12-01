using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERConsole
{
    class MenuElementUserInterface
    {
        private MenuElementDataSource menuElementDataSource;
        public MenuElementUserInterface(MenuElementDataSource menuElementDataSource)
        {
            this.menuElementDataSource = menuElementDataSource;
        }

        public void interact () {
            int c = this.menuElementDataSource.getCount();
            for (int i = 1; i <= c; i++)
            {
                Console.WriteLine(String.Format("{0}. {1}", i.ToString(), this.menuElementDataSource.getOptionDescription(i - 1)));
            }

            string s        = Console.ReadLine();
            int    position = int.Parse(s);
            this.menuElementDataSource.executeAction(position-1); // -1 because of shif for user experience.
        }

        public static string getStringFromUser()
        {
            return Console.ReadLine();
        }

        public static void showString (string message)
        {
            Console.WriteLine(message);
        }

    }
}
