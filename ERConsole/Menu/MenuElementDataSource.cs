using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERConsole
{
    class MenuElementDataSource : IMenuDataSource // My implementation of the source data file
    {
        private int          optionsCount;
        private string[]     optionsDescriptions;
        private Action[]     actions;
        private MenuElementDataSource  parentMenuElement = null;

        public MenuElementDataSource(int optionsCount, string[] optionsDescriptions, Action[] actions, MenuElementDataSource parentMenuElement)
        {
            this.optionsCount        = optionsCount;
            this.optionsDescriptions = optionsDescriptions;
            this.actions             = actions;
            this.parentMenuElement   = parentMenuElement;
        }

        public int getCount()     // what IMenuDataSource.getCount()   does mean ?
        {
            return optionsCount;
        }

        public string getOptionDescription(int position)
        {
            return this.optionsDescriptions[position];
        }

        public void executeAction(int position)
        {
            this.actions[position]();
        }
    }
}
