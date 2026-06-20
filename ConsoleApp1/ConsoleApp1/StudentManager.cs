
    class StudentManager
    {
     private static List<Student> students = new List<Student>();

        public static void AddStudent(String name, double grade1, double grade2, double grade3)
        {

            students.Add(new Student(name, grade1, grade2, grade3));

            Console.WriteLine("\nStudent added successfully!");
        }


        public static void ViewAllStudents()
        {    

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (Student student in students)
            {
            double average = student.GetAverage();

                Console.WriteLine($"\nName: {student.GetName()}");
                Console.WriteLine($"Grades: {string.Join(",",student.GetGrades())}");
                Console.WriteLine($"Average: {average:F2}");
                Console.WriteLine("-------------------------");
            }
        }

        public static void ComputeAverageGrade()
        {

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

