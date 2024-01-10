using System;
using System.Collections.Generic;

namespace Project
{
class Student
{
    private static int lastAssignedId = 1000; 
    public int StudentID { get; set; }
    public string Password { get; set; } 
    public string Name { get; set; }
    public string Prenom { get; set; }
    public string CurrentClass { get; set; }

    public string Niveau { get; set; }

    public string Special { get; set; }


    public static List<Student> StudentsList = new List<Student>();

    public void Add()
    {
        Console.WriteLine("Enter student details:");
        Console.Write("Nom : ");
        Name = Console.ReadLine();
        Console.Write("Prenom: ");
        Prenom = Console.ReadLine();
        Console.Write("ckasse: ");
        CurrentClass = Console.ReadLine();
        Console.Write("niveau d'etude: ");
        Niveau = Console.ReadLine();
        Console.Write("etude: ");
        Special = Console.ReadLine();
        StudentID = ++lastAssignedId;
        Console.WriteLine($"ID: {StudentID}");
        Console.Write("Mot de passe: ");
        Password = Console.ReadLine(); 


        StudentsList.Add(this);

        Console.WriteLine("etudiant ajouté");
    }

    public void Edit()
    {
        Console.Write("entrer l'ID: ");
        int studentIdToEdit = int.Parse(Console.ReadLine());

        Console.Write("le mot de passse: ");
        string passwordToEdit = Console.ReadLine();

        Student studentToEdit = StudentsList.Find(s => s.StudentID == studentIdToEdit && s.Password == passwordToEdit);

        if (studentToEdit != null)
        {
            Console.WriteLine("Entrer les nouvelles information:");
            Console.Write("Nom : ");
            Name = Console.ReadLine();
            Console.Write("Prenom: ");
            Prenom = Console.ReadLine();
            Console.Write("ckasse: ");
            CurrentClass = Console.ReadLine();
            Console.Write("niveau d'etude: ");
            Niveau = Console.ReadLine();
            Console.Write("etude: ");

            Console.WriteLine("etudiant modifié");
        }
        else
        {
            Console.WriteLine("Impossible");
        }
    }

    public void Delete()
    {
        Console.Write("entrer ID: ");
        int studentIdToDelete = int.Parse(Console.ReadLine());

        Console.Write("Entrer mot de passe : ");
        string passwordToDelete = Console.ReadLine();

        Student studentToDelete = StudentsList.Find(s => s.StudentID == studentIdToDelete && s.Password == passwordToDelete);

        if (studentToDelete != null)
        {
            StudentsList.Remove(studentToDelete);
            Console.WriteLine("etudiant effacé");
        }
        else
        {
            Console.WriteLine("Impossible");
        }
    }

    public void ViewDetails()
    {
        Console.Write("Entrer ID: ");
        int studentIdToView = int.Parse(Console.ReadLine());

        Console.Write("Mot de passe : ");
        string passwordToView = Console.ReadLine();

        Student studentToView = StudentsList.Find(s => s.StudentID == studentIdToView && s.Password == passwordToView);

        if (studentToView != null)
        {
            Console.WriteLine("Info Etudiant:");
            Console.WriteLine($"ID: {studentToView.StudentID}");
            Console.WriteLine($"Nom: {studentToView.Name}");
            Console.WriteLine($"Prenom: {studentToView.Prenom}");
            Console.WriteLine($"Classe: {studentToView.CurrentClass}");
            Console.WriteLine($"Niveau d'etude: {studentToView.Niveau}");
            Console.WriteLine($"etude : {studentToView.Special}");
        }
        else
        {
            Console.WriteLine("Impossible");
        }
    }

}

}