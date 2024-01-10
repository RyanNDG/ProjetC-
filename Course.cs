using System;
using System.Collections.Generic;
using System.IO;

namespace Project
{
class CourseManager
{
    private const string CoursesDirectory = "Cours";

    public void AddCourse(string courseName, string courseDetails)
    {
        string courseFileName = $"{CoursesDirectory}\\{courseName}.txt";

        if (!Directory.Exists(CoursesDirectory))
        {
            Directory.CreateDirectory(CoursesDirectory);
        }

        if (!File.Exists(courseFileName))
        {
            using (StreamWriter sw = File.CreateText(courseFileName))
            {
                sw.Write(courseDetails);
            }

            Console.WriteLine($"Cours de '{courseName}' jouté");
        }
        else
        {
            Console.WriteLine($"Cours de '{courseName}' existe deja");
        }
    }

    public void UpdateCourse(string courseName, string newCourseDetails)
    {
        string courseFileName = $"{CoursesDirectory}\\{courseName}.txt";

        if (File.Exists(courseFileName))
        {
            File.WriteAllText(courseFileName, newCourseDetails);
            Console.WriteLine($"Cours '{courseName}' modifié.");
        }
        else
        {
            Console.WriteLine($"Cours '{courseName}' n'existe pas");
        }
    }

    public void DeleteCourse(string courseName)
    {
        string courseFileName = $"{CoursesDirectory}\\{courseName}.txt";

        if (File.Exists(courseFileName))
        {
            File.Delete(courseFileName);
            Console.WriteLine($"Cours '{courseName}' effacé");
        }
        else
        {
            Console.WriteLine($"Cours '{courseName}' n'existe pas.");
        }
    }
        public void ViewCourseContent(string courseName)
    {
        string courseFileName = $"{CoursesDirectory}\\{courseName}.txt";

        if (File.Exists(courseFileName))
        {
            string content = File.ReadAllText(courseFileName);
            Console.WriteLine($"contenu du cours de '{courseName}':");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine($"Cours '{courseName}' n'existe pas.");
        }
    }
}
}