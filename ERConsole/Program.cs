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
using ERConsole.Menu;
using ERConsole.School;

namespace ERConsole
{
    class Program
    {
        //public static ResourceManager language;
        static void Main(string[] args)
        {
            //ResourceManager rm = new ResourceManager("English.resx", Assembly.GetExecutingAssembly()); // learn what this is - reflection

            Console.WriteLine(Language.welcome_message);

            SchoolModel school = new SchoolModel();
            SchoolController schoolController = new SchoolController(school);

            /* ROOT OF ALL MENU */
            MenuItem generate = new MenuItem(Language.generate_students_teachers_and_classes, null, null);
            MenuItem show     = new MenuItem(Language.show, null, null);
            MenuItem actions = new MenuItem(Language.actions, null, null);
            MenuItem[] rootItems = { generate,show, actions };
            MenuCollection root = new MenuCollection(rootItems, null);

            /* Generate Methods for generate */
            MenuItem generateTeachers = new MenuItem(Language.generate_teachers,null, () => { schoolController.generateTeachersToQueue();});
            MenuItem generateStudents = new MenuItem(Language.generate_students, null, () => { schoolController.generateStudentsToQueue(); });
            MenuItem execute = new MenuItem(Language.execute,null, () => { schoolController.execute();}); 
            MenuItem[] generateMenuItems = {generateTeachers, generateStudents, execute};
            MenuCollection generateStudentTeachersAndClasses = new MenuCollection(generateMenuItems,root); // yet null, we need construct it

            /* Generate Methods for show */ 
            MenuItem showAllClasses = new MenuItem(Language._class, null, schoolController.showAllClasses);
            MenuItem showAllTeachers = new MenuItem(Language.teachers , null, schoolController.showAllTeachers);
            MenuItem showAllStudents = new MenuItem(Language.students, null, schoolController.showAllStudents);
            MenuItem showAllStudentsSortedByName = new MenuItem(Language.all_teachers_by_name, null, schoolController.showAllStudentsSortedByFirstName);
            MenuItem showAllTeachersRegex = new MenuItem(Language.show_all_teachers_matching_regex, null, schoolController.searchThroughTeachersRegex);


            MenuItem[] presentation = { showAllClasses, showAllTeachers, showAllStudents, showAllStudentsSortedByName, showAllTeachersRegex };
            MenuCollection showMenuCollection = new MenuCollection(presentation, root);

            /* Generate Methods for action */


            /*MenuItem addClass = new MenuItem(Language,addClass, null, schoolController.hireTEacher);
            MenuItem removeClass = new MenuItem(Language.remove_class, null, schoolController.hireTEacher);
            */

            MenuItem addTeacher = new MenuItem(Language.hire_teacher, null, schoolController.hireTeacher);
            MenuItem layOffTeacher = new MenuItem(Language.lay_off_teacher, null, schoolController.laOffTeacher);

            /*
            MenuItem addStudent = new MenuItem(Language.admit_student, null, schoolController.deleteTeacher);
            MenuItem layOffStudent = new MenuItem(Language.lay_off_student, null, schoolController.deleteTeacher);
            */
            MenuItem[] actionsMenuItems = { addTeacher, layOffTeacher };
            MenuCollection actionsMenuCollection = new MenuCollection(actionsMenuItems, root);  // ASK ABOUT STYLE   mainMenu actions  --or-- mainMenu actionsMainMenu
            
            

            generate.subMenu = generateStudentTeachersAndClasses;  // link rootITEM to the sub menu...
            show.subMenu = showMenuCollection;
            actions.subMenu = actionsMenuCollection;

            

            MenuCollectionController mCC = new MenuCollectionController(root);
            mCC.interact();
          



        }
    }
}
