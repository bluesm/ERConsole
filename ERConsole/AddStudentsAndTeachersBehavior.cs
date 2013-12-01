using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERConsole
{
    class AddStudentsAndTeachersBehavior
    {
        public void generateStudents(School school)
        {
            MenuElementUserInterface.showString(Language.pass_amount_of_students);
            int amount = int.Parse(MenuElementUserInterface.getStringFromUser());
            school.toDoQueue.Add(delegate() { school.generateStudents(amount); });
        }

        public void generateTeachers(School school)
        {
            MenuElementUserInterface.showString(Language.pass_amount_of_teachers);
            int amount = int.Parse(MenuElementUserInterface.getStringFromUser());
            school.toDoQueue.Add(delegate() { school.generateTeachers(amount); });
        }
    }
}
