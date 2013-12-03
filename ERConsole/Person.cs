using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERConsole
{
    abstract class Person
    {
        static int IDCount = 0;
        public int    ID;
        public String firstName;
        public String secondName;

        String fullName
        {
            get
            {
                return String.Format("{0} {1}", this.firstName, this.secondName);
            }
        }

        public Person(String firstName, String secondName)
        {
            this.ID = Person.IDCount;
            Person.IDCount += 1;
            this.firstName = firstName;
            this.secondName = secondName;
        }
    }
}
