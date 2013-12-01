using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERConsole
{
    class School
    {
        public List<Student> studendsList;
        public List<Teacher> teachersList;
        public List<Class>   classList;


        private string namesPath    = "names.txt";
        private string surnamesPath = "surnames.txt";

        private string[] namesArray = null;
        private string[] surnamesArray = null;

        public School()
        {
            this.namesArray    = System.IO.File.ReadAllLines(this.namesPath);
            this.surnamesArray = System.IO.File.ReadAllLines(this.surnamesPath);
        }



        public List<Action> toDoQueue;  // just the exercise
        public void executeQue()
        {
            int c = this.toDoQueue.Count();
            for (int i = 0; i < c; i++)
            {
                this.toDoQueue[i]();
            }
        }

        public void generateStudents(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Random r = new Random();
                string firstName = this.namesArray[r.Next(0, this.namesArray.Length)];
                string surname = this.namesArray[r.Next(0, this.surnamesArray.Length)];
                this.studendsList.Add(new Student(firstName, surname));
            }
        }

        public void generateTeachers(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Random r = new Random();
                string firstName = this.namesArray[r.Next(0, this.namesArray.Length)];
                string surname = this.namesArray[r.Next(0, this.surnamesArray.Length)];
                this.teachersList.Add(new Teacher(firstName, surname)); // Make it work better ? Without this method ?
            }
        }
    }
}
