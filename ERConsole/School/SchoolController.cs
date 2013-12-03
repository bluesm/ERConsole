using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERConsole.School;
 // using System.Text.RegularExpressions.Regex; only applied to namespaces ?

namespace ERConsole.School
{
    class SchoolController
    {
        SchoolModel school;
        public SchoolController(SchoolModel school)
        {
            this.school = school;
        }

        private int getInt () {
           
            int intNumber;
            while(true) {
                try {
                    string number = Console.ReadLine();
                    intNumber = int.Parse(number);
                    
                    break;
                } catch {
                    Console.WriteLine(Language.not_int);
                }
            }
            return intNumber;
        }

        public void generateTeachersToQueue() {
            Console.WriteLine(Language.pass_amount_of_teachers);
            this.school.generateTeachersToQueue(getInt());
        }

        public void generateStudentsToQueue()
        {
            Console.WriteLine(Language.pass_amount_of_teachers);
            this.school.generateStudentsToQueue(getInt());
        }

        public void execute()
        {
            this.school.executeQue();
        }

        /* Visual */ 

        public void showStudent (Student p) {
            Console.WriteLine(string.Format(" {0} : {1} - {2} {3} ", Language.students_id , p.ID, p.firstName, p.secondName));
        }
        public void showTeacher (Teacher t) {
            Console.WriteLine(string.Format(" {0} : {1} - {2} {3} ", Language.teachers_id , t.ID, t.firstName, t.secondName));
        }
        public void showClass(Class c) {
            Console.WriteLine(string.Format("{0} : {1}",Language.classs_id ,c.ID));
            Console.Write("\t");
            this.showTeacher(c.mainTeacher);

            foreach(Student s in c.studentList) {
                Console.Write("\t\t");
                this.showStudent(s);  // WHAT IS STUB ?
            }
        }

        public void showAllStudentsSortedByFirstName () {
            List<Teacher> tList = this.school.teachersList.OrderBy(t => t.firstName).ToList();
            foreach (Teacher t in tList)
            {
                this.showTeacher(t);
            }
        }

        public void searchThroughTeachersRegex()
        {
            Console.WriteLine(Language.pass_regex);
            string reg = Console.ReadLine();
            //s, sPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase
            foreach (Teacher t in this.school.teachersList) {

                if (System.Text.RegularExpressions.Regex.IsMatch(t.firstName, reg, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                 || System.Text.RegularExpressions.Regex.IsMatch(t.ID.ToString(), reg, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                 || System.Text.RegularExpressions.Regex.IsMatch(t.secondName, reg, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    this.showTeacher(t);
                }
            }
        }

        public void showAllClasses () {
            foreach(Class c in this.school.classList) {
                showClass(c);
            }
        }
        public void showAllTeachers()
        {
            foreach (Teacher t in this.school.teachersList)
            {
                Console.Write("\t");
                showTeacher(t);
            }
        }

        public void showAllStudents()
        {
            foreach (Student s in this.school.studentsList)
            {
                Console.Write("\t");
                showStudent(s);
            }
        }


        public void hireTeacher()
        {
            Console.WriteLine(Language.pass_the_name_of_teacher);
            string name = Console.ReadLine();
            Console.WriteLine(Language.pass_the_secondname_of_teacher);
            string secondName = Console.ReadLine();
            Teacher t = new Teacher(name, secondName);
            this.school.hireTeacher(t);
        }

        public void laOffTeacher()
        {
            Console.WriteLine(Language.pass_the_id_of_teacher_you_want_to_lay_off);
            int id = this.getInt();

        }

    }
}
