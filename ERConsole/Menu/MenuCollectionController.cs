using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERConsole.Menu
{
    class MenuCollectionController
    {
        MenuCollection root;
        public MenuCollectionController (MenuCollection root) {
            this.root = root;
        }

        public void generateMenu () {
            int count = root.getCount() + 1;
            for (int i = 1; i < count; i++)
            {
                Console.WriteLine(String.Format("{0}. {1}",i,this.root.getOptionDescription(i-1)));
            }
        }


        private void wrongInput () {
            Console.WriteLine(Language.wrong_input_message);
        }
        private bool newMenu(MenuCollection root)
        {
            this.root = root;
            return !(this.root == null);
        }
        private void selectItem(int i)
        {
            MenuItem selectedItem = this.root.getMenuItem(i);
            if (selectedItem.subMenu == null)  // How can I overcome this by encapsulation ?
            {
                //Console.WriteLine("sub is null");
                selectedItem.action();
                //this.interact();  // What happend where when it wasn't commented out
            }
            else
            {
                //Console.WriteLine("sub is NOT null");
                this.root = selectedItem.subMenu;
            }
        }
        public void interact()
        {
            while (true) {
                this.generateMenu();
                Console.Write("--->");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    if (!this.newMenu(this.root.parent))
                    {
                        //Console.WriteLine("I breaked");
                        return;
                    }
                    continue;
                }

                int itemNumber = 0;
                try
                {
                    itemNumber = int.Parse(input);
                }
                catch
                {
                    this.wrongInput();
                    continue;
                }

                itemNumber -= 1; // because interface
                if (itemNumber >= this.root.getCount() || itemNumber < 0)
                {
                    this.wrongInput(); // MAKE INTERACTION WITH USER... SO IT WILL STILL BE IN THE CALL STACK
                    continue;
                }

                this.selectItem(itemNumber);
            }
            
            
        }

        
    }
}
