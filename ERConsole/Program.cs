using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Resources;
using System.Globalization;
using System.Threading;
using System.Reflection;

namespace ERConsole
{
    class Program
    {
        public static ResourceManager language;
        static void Main(string[] args)
        {
            //ResourceManager rm = new ResourceManager("English.resx", Assembly.GetExecutingAssembly()); // learn what this is - reflection

            Console.WriteLine(Language.welcome_message);
            School school = new School();

            string[] mainMenuOptionsDescriptions = {Language.generate_teachers_and_students};
            //Action[] mainMenuActions = {MainMenuBehaviour.generateTeachersAndStudents};


            
            string[] addStudentsAndTeachersOptionDescriptions = { Language.generate_students, Language.generate_teachers, Language.execute };
            Action[] addStudentsAndTeachersActions = { };


            //MenuElementUserInterface mainMenu = new MenuElementUserInterface(new MenuElementDataSource(1, mainMenuOptionsDescriptions, mainMenuActions, null));
            
            //mainMenu.interact();




        }
    }
}
