using System;
using System.Collections.Generic;


namespace Project
{
class Calendar
{
    private Dictionary<string, DateTime> examDates;
    private Dictionary<string, DateTime> courseDeadlines;

    public Calendar()
    {
        examDates = new Dictionary<string, DateTime>();
        courseDeadlines = new Dictionary<string, DateTime>();
    }


    public void DisplayExamDates()
    {
        Console.WriteLine("dates d'examins:");
        foreach (var exam in examDates)
        {
            Console.WriteLine($"{exam.Key}: {exam.Value.ToShortDateString()}");
        }
    }

    public void DisplayCourseDeadlines()
    {
        Console.WriteLine("limite du cours:");
        foreach (var deadline in courseDeadlines)
        {
            Console.WriteLine($"{deadline.Key}: {deadline.Value.ToShortDateString()}");
        }
    }


    public void ChangeExamDate(string examName, DateTime newDate, Administration admin)
    {
        if (admin != null)
        {
            examDates[examName] = newDate;
            Console.WriteLine($" dates Examin pour {examName} modifié.");
        }
        else
        {
            Console.WriteLine("seuls les admins peuvent modifié.");
        }
    }

    public void ChangeCourseDeadline(string courseName, DateTime newDeadline, Administration admin)
    {
        if (admin != null)
        {
            courseDeadlines[courseName] = newDeadline;
            Console.WriteLine($"date limite de {courseName} modifié");
        }
        else
        {
            Console.WriteLine("Seul les admins peuvent.");
        }
    }
    
}
}