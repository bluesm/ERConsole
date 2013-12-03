using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERConsole
{
    class Teacher : Person
    {
        public Class mainClass = null;
        public Teacher(string firstName, string surname)
            : base(firstName, surname)
        {

        }

        public void setMainClass(Class mainClass)
        {
            this.mainClass = mainClass;
        }


        
    }
}
