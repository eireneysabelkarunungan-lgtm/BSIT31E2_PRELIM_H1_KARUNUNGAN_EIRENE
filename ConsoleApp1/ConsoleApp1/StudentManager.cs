using System;

internal static class StudentManager
{
    private static List<Student> students = new List<Student>();

    public static void AddStudent()
    {
        Console.Clear();

        Console.Write("Enter student name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter grade 1: ");
        double grade1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter grade 2: ");
        double grade2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter grade 3: ");
        double grade3 = Convert.ToDouble(Console.ReadLine());

        students.Add(new Student
        {
            Name = name,
            Grade1 = grade1,
            Grade2 = grade2,
            Grade3 = grade3
        });


        Console.WriteLine("Student added successfully!");
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
        Console.Clear();

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
    public string? Name { get; set; }
    public double Grade1 { get; set; }
    public double Grade2 { get; set; }
    public double Grade3 { get; set; }
}