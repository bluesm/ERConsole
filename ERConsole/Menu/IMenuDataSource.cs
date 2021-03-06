﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERConsole.Menu;

namespace ERConsole
{
    interface IMenuDataSource
    {
        int    getCount               ();
        string getOptionDescription   (int position);
        MenuItem getMenuItem(int position);
    }
}
