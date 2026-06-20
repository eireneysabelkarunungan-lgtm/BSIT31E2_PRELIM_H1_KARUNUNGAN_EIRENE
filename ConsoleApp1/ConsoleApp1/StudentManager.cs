
class StudentManager
{
    List<Student> students = new List<Student>();

    public List<Student> GetStudents() => students;

    public double ComputeAverage()
    {
        double totalAverage = 0;

        foreach (Student student in students)
        {

            totalAverage += student.GetAverage();
        }

        double classAverage = totalAverage / students.Count;

        return classAverage;
    }

    //public static void ComputeAverageGrade()
    //{

    //    if (students.Count == 0)
    //    {
    //        Console.WriteLine("No students found.");
    //        return;
    //    }

    //    double totalAverage = 0;

    //    foreach (Student student in students)
    //    {
    //        double studentAverage =
    //            (student.Grade1 + student.Grade2 + student.Grade3) / 3;

    //        totalAverage += studentAverage;
    //    }

    //    double classAverage = totalAverage / students.Count;

    //    Console.WriteLine("\n===== CLASS AVERAGE =====");
    //    Console.WriteLine($"Overall Average Grade: {classAverage:F2}");
    //}

    public Student[] GetHighest()
    {
       
        var max = students.Max(x => x.GetAverage());
        return students.Where(x => x.GetAverage() == max).ToArray();
    }

    //public double HighestGrade()
    //{

    //    return students.Max(c => c.GetAverage());
    //}
}
    //public static void FindHighestGrade()
    //    {


//        if (students.Count == 0)
//        {
//            Console.WriteLine("No students found.");
//            return;
//        }

//        Student topStudent = students[0];
//        double highestGrade = Math.Max(
//            topStudent.Grade1,
//            Math.Max(topStudent.Grade2, topStudent.Grade3)
//        );

//        foreach (Student student in students)
//        {
//            double studentHighest = Math.Max(
//                student.Grade1,
//                Math.Max(student.Grade2, student.Grade3)
//            );

//            if (studentHighest > highestGrade)
//            {
//                highestGrade = studentHighest;
//                topStudent = student;
//            }
//        }

//        Console.WriteLine("\n===== HIGHEST GRADE =====");
//        Console.WriteLine($"Top Student: {topStudent.Name}");
//        Console.WriteLine($"Highest Grade: {highestGrade}");
//    }
//}

