using System;

internal static class SelectionMenu
{
    public static int MainMenu()
    {
        while (true)
        {
            Console.WriteLine("\n===== STUDENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Compute Average Grade");
            Console.WriteLine("4. Find Highest Grade");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                if (choice >= 1 && choice <= 5)
                {
                    return choice;
                }
            }

            Console.WriteLine("Invalid input. Please enter 1-5 only.");
        }
    }
}