using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERConsole
{
    class Class
    {
        private static int IDCounter = 0;

        public List<Student> studentList;
        public Teacher mainTeacher;
        public int ID;

        public Class(List<Student> studentList, Teacher mainTeacher)
        {
            this.ID = Class.IDCounter;
            Class.IDCounter += 1;
            
            this.studentList = studentList;
            this.mainTeacher = mainTeacher;
            mainTeacher.setMainClass(this);
        }
        
    }
}
