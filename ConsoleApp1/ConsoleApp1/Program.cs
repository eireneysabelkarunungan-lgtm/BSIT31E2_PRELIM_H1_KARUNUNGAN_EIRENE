using System;

class Program
{
    static void Main()
    {

        while (true)
        {
            int choice = SelectionMenu.MainMenu();

            switch (choice)
            {
                case 1:
                    StudentManager.AddStudent();
                    break;
                case 2:
                    StudentManager.ViewAllStudents();
                    break;
                case 3:
                    StudentManager.ComputeAverageGrade();
                    break;
                case 4:
                    StudentManager.FindHighestGrade();
                    break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}