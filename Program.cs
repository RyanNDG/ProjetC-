using System;

namespace Project
{
    class Program
    {
        static CourseManager courseManager = new CourseManager();

        static void PrintColoredMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void StudentMenu(Student student)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                PrintColoredMessage(" GESTION DES ELEVES", ConsoleColor.Cyan);
                Console.WriteLine("-1 Ajouter");
                Console.WriteLine("-2 Modifier");
                Console.WriteLine("-3 Information sur un eleve");
                Console.WriteLine("-4 Effacé");
                Console.WriteLine("-5 retour");
                Console.Write("Choix : ");

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
                            Console.WriteLine("Invalide");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalide");
                }

                Console.WriteLine();
                Console.WriteLine("-");
            }
        }

        static void TeacherMenu(Teacher teacher)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                PrintColoredMessage("GESTION DES PROFFESSEUR", ConsoleColor.Magenta);
                Console.WriteLine("-1 Ajouter");
                Console.WriteLine("2. Modifier");
                Console.WriteLine("-3 Informartions sur un Proffesseur");
                Console.WriteLine("-4 Effacé");
                Console.WriteLine("-5 Retour");
                Console.Write("Choix : ");

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
                            Console.WriteLine("Invalide");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalide");
                }

                Console.WriteLine();
                Console.WriteLine("-");
            }
        }

        static void AdminMenu(Administration admin, Calendar calendar)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                PrintColoredMessage("ADMIN", ConsoleColor.Yellow);
                Console.WriteLine("-1 Gerer Etudiants");
                Console.WriteLine("-2 Gerer Profffesseur");
                Console.WriteLine("-3 Clendrier");
                Console.WriteLine("-4 Gerer les Cours");
                Console.WriteLine("-5 Back to Main Menu");
                Console.Write("Choix: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            admin.ManageStudents();
                            break;
                        case 2:
                            admin.ManageTeachers();
                            break;
                        case 3:
                            admin.CalendarMenu(calendar, admin);
                            break;
                        case 4:
                            admin.CoursesMenu(courseManager);
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalide");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalide");
                }

                Console.WriteLine();
                Console.WriteLine("-");
            }
        }

        static void Main()
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            Calendar calendar = new Calendar();
            Administration admin = new Administration();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                PrintColoredMessage("GESTION DE L'ETABLISSEMENT", ConsoleColor.Green);
                Console.WriteLine("-1 Gerer Etudiants");
                Console.WriteLine("-2 Gerer Profffesseur");
                Console.WriteLine("-3 Menu Admin");
                Console.WriteLine("-4 Retour");
                Console.Write("Choix : ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            StudentMenu(student);
                            break;
                        case 2:
                            TeacherMenu(teacher);
                            break;
                        case 3:
                            AdminMenu(admin, calendar);
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalide");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalide");
                }

                Console.WriteLine();
                Console.WriteLine("-");
            }
        }
    }
}
