using System;
using System.Collections.Generic;

namespace Project
{
class Administration
{

    public void ManageStudents()
    {
        Student student = new Student();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Ajouter un eleve ");
            Console.WriteLine("Modifier un eleve");
            Console.WriteLine("Information sur un eleve");
            Console.WriteLine("Effacer un Eleve");
            
            Console.WriteLine("Retour");
            Console.Write("choissisez un nombre: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        student.Add();
                        break;
                    case 2:
                        student.Edit();
                        break;
                    case 3:
                        student.ViewDetails();
                        break;
                    case 4:
                        student.Delete();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Nombre impossible");
                        break;
                }
            }
            else
            {
                Console.WriteLine("choisis un nombre de 1-5");
            }

            Console.WriteLine(); 
        }
    }

    public void ManageTeachers()
    {
        Teacher teacher = new Teacher();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Ajouter un Prof");
            Console.WriteLine("Modifier un Prof");
            Console.WriteLine("Voir un Prof");
            Console.WriteLine("Effacer un Prof");
            Console.WriteLine("Retour");
            Console.Write("Choissisez un Nombre: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        teacher.Add();
                        break;
                    case 2:
                        teacher.Edit();
                        break;
                    case 3:
                        teacher.ViewDetails();
                        break;
                    case 4:
                        teacher.Delete();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Nombre impossible");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nombre impossible");
            }

            Console.WriteLine(); 
        }
    }
        public void CalendarMenu(Calendar calendar, Administration admin)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine(" gérer le Calendrier");
            Console.WriteLine("changer un date d'examin");
            Console.WriteLine("changer la limite d'un cours");
            Console.WriteLine("retour");
            Console.Write("choisis un nombre: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Entrer le nom Examin: ");
                        string examName = Console.ReadLine();
                        Console.Write("Entrer une nouvelle date (dd/mm/yyyy): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime newExamDate))
                        {
                            calendar.ChangeExamDate(examName, newExamDate, admin);
                        }
                        else
                        {
                            Console.WriteLine("format Invalide");
                        }
                        break;
                    case 2:
                        Console.Write("Nom du cours: ");
                        string courseName = Console.ReadLine();
                        Console.Write("limite cours (dd/mm/yyyy): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime newDeadline))
                        {
                            calendar.ChangeCourseDeadline(courseName, newDeadline, admin);
                        }
                        else
                        {
                            Console.WriteLine("impossible");
                        }
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("impossible");
                        break;
                }
            }
            else
            {
                Console.WriteLine("impossible");
            }

            Console.WriteLine(); 
        }
    }

        public void CoursesMenu(CourseManager courseManager)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("gerer les cours");
            Console.WriteLine("Modifier Cours");
            Console.WriteLine("update des Cours");
            Console.WriteLine("Effacer Cours");
            Console.WriteLine("voir un cours");
            Console.WriteLine("Retour");
            Console.Write("Choix :");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Nom du cours : ");
                        string courseName = Console.ReadLine();
                        Console.Write("details du cours: ");
                        string courseDetails = Console.ReadLine();
                        courseManager.AddCourse(courseName, courseDetails);
                        break;
                    case 2:
                        Console.Write("Nom du cours: ");
                        string updateCourseName = Console.ReadLine();
                        Console.Write("entrer le cours updated: ");
                        string updatedCourseDetails = Console.ReadLine();
                        courseManager.UpdateCourse(updateCourseName, updatedCourseDetails);
                        break;
                    case 3:
                        Console.Write("Nom du cours a effacer: ");
                        string deleteCourseName = Console.ReadLine();
                        courseManager.DeleteCourse(deleteCourseName);
                        break;
                    case 4:
                        Console.Write("choissisez le cours: ");
                        string viewContentCourseName = Console.ReadLine();
                        courseManager.ViewCourseContent(viewContentCourseName);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Impossible");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Impossible.");
            }

            Console.WriteLine(); 
        }
    }


}
}
