using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERConsole
{
    interface IMenuDataSource
    {
        int    getCount               ();
        string getOptionDescription   (int position);
        void   executeAction          (int position);
    }
}
