using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERConsole.Menu
{
    
    class MenuItem
    {
        public string description;
        public MenuCollection subMenu;
        public Action action;

        public MenuItem(string description, MenuCollection subMenu, Action action)
        {
            this.description = description;
            this.subMenu = subMenu;
            this.action = action;
        }
        /*
        public void select () {
            
        }
         FIGURE OUT HOW TO MAKE SELECT METHOD*/ 
    }
}
