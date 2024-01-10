using System;
using System.Collections.Generic;

namespace Project
{
class Teacher
{
    private static int lastAssignedId = 2000; 
    public int TeacherID { get; set; }
    public string Password { get; set; } 
    public string Name { get; set; }
    public string Prenom { get; set; }
    public string Prof { get; set; }

    public static List<Teacher> TeachersList = new List<Teacher>();

    public void Add()
    {
        Console.WriteLine("Enter teacher details:");
        Console.Write("Name: ");
        Name = Console.ReadLine();
        Console.Write("Prenom: ");
        Prenom = Console.ReadLine();
        Console.Write("Prof de: ");
        Prof = Console.ReadLine();
        TeacherID = ++lastAssignedId;
        Console.WriteLine($"ID: {TeacherID}");
        Console.Write("mot de passe: ");
        Password = Console.ReadLine(); 


        TeachersList.Add(this);

        Console.WriteLine("proffeseur ajouté");
    }

    public void Edit()
    {
        Console.Write("ID du Prof: ");
        int teacherIdToEdit = int.Parse(Console.ReadLine());

        Console.Write("Entrer mot de passe: ");
        string passwordToEdit = Console.ReadLine();

        Teacher teacherToEdit = TeachersList.Find(t => t.TeacherID == teacherIdToEdit && t.Password == passwordToEdit);

        if (teacherToEdit != null)
        {
            Console.WriteLine("nouvelle info:");
            Console.Write("Nom: ");
            teacherToEdit.Name = Console.ReadLine();
            Console.Write("Prof de: ");
            teacherToEdit.Prof = Console.ReadLine();


            Console.WriteLine("Prof modifié");
        }
        else
        {
            Console.WriteLine("Introuvable");
        }
    }

    public void Delete()
    {
        Console.Write("ID: ");
        int teacherIdToDelete = int.Parse(Console.ReadLine());

        Teacher teacherToDelete = TeachersList.Find(t => t.TeacherID == teacherIdToDelete);

        if (teacherToDelete != null)
        {
            TeachersList.Remove(teacherToDelete);
            Console.WriteLine("effacé !");
        }
        else
        {
            Console.WriteLine("Introuvable");
        }
    }

    public void ViewDetails()
    {
        Console.Write("ID: ");
        int teacherIdToView = int.Parse(Console.ReadLine());

        Teacher teacherToView = TeachersList.Find(t => t.TeacherID == teacherIdToView);

        if (teacherToView != null)
        {
            Console.WriteLine("Info du prof:");
            Console.WriteLine($"ID: {teacherToView.TeacherID}");
            Console.WriteLine($"Nom: {teacherToView.Name}");
            Console.WriteLine($"Prof de: {teacherToView.Prof}");
        }
        else
        {
            Console.WriteLine("Introuvable");
        }
    }

}
}