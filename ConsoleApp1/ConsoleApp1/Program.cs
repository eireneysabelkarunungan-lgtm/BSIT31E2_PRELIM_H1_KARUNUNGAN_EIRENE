using System;
using System.Collections.Generic;

partial class Program
{
    static void Main()
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
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter student name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter grade 1: ");
                            double grade1 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter grade 2: ");
                            double grade2 = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter grade 3: ");
                            double grade3 = Convert.ToDouble(Console.ReadLine());

                            StudentManager.AddStudent(name, grade1, grade2, grade3);
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
                    
                } else
                {
                  Console.WriteLine("Invalid input. Please enter 1-5 only.");
                }
                    
            }
            
        }
           
     }
 }
    