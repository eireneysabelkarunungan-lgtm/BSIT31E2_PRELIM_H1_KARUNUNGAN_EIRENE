using System;
using System.Collections.Generic;

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

    class SelectionMenu
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
 
    class StudentManager
    {
     private static List<Student> students = new List<Student>();

        public static void AddStudent()
        {
            Console.Clear();

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter grade 1: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter grade 2: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter grade 3: ");
            double grade3 = Convert.ToDouble(Console.ReadLine());

            students.Add(new Student(name, grade1, grade2, grade3));

            Console.WriteLine("\nStudent added successfully!");
        }

        public static void ViewAllStudents()
        {
            Console.Clear();

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (Student student in students)
            {
                double average = (student.Grade1 + student.Grade2 + student.Grade3) / 3;

                Console.WriteLine($"\nName: {student.Name}");
                Console.WriteLine($"Grades: {student.Grade1}, {student.Grade2}, {student.Grade3}");
                Console.WriteLine($"Average: {average:F2}");
                Console.WriteLine("-------------------------");
            }
        }

        public static void ComputeAverageGrade()
        {
            Console.Clear();

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            double totalAverage = 0;

            foreach (Student student in students)
            {
                double studentAverage =
                    (student.Grade1 + student.Grade2 + student.Grade3) / 3;

                totalAverage += studentAverage;
            }

            double classAverage = totalAverage / students.Count;

            Console.WriteLine("\n===== CLASS AVERAGE =====");
            Console.WriteLine($"Overall Average Grade: {classAverage:F2}");
        }

        public static void FindHighestGrade()
        {
           

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Student topStudent = students[0];
            double highestGrade = Math.Max(
                topStudent.Grade1,
                Math.Max(topStudent.Grade2, topStudent.Grade3)
            );

            foreach (Student student in students)
            {
                double studentHighest = Math.Max(
                    student.Grade1,
                    Math.Max(student.Grade2, student.Grade3)
                );

                if (studentHighest > highestGrade)
                {
                    highestGrade = studentHighest;
                    topStudent = student;
                }
            }

            Console.WriteLine("\n===== HIGHEST GRADE =====");
            Console.WriteLine($"Top Student: {topStudent.Name}");
            Console.WriteLine($"Highest Grade: {highestGrade}");
        }
    }

    public class Student
    {
        public string Name;
        public double Grade1;
        public double Grade2;
        public double Grade3;

        public Student(string name, double grade1, double grade2, double grade3)
        {
            Name = name;
            Grade1 = grade1;
            Grade2 = grade2;
            Grade3 = grade3;
        }
    }

}