

class Program
{
    
    static void Main()
    {
        StudentManager manager = new StudentManager();
        var students = manager.GetStudents();
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

                            students.Add(new Student(name, grade1, grade2, grade3));

                            Console.WriteLine("\nStudent added successfully!");

                            break;

                        case 2:
<
                            StudentManager.ViewAllStudents();
                            Console.WriteLine($"\nName: {student.GetName()}");
                            Console.WriteLine($"Grades: {string.Join(",", student.GetGrades())}");
                            Console.WriteLine($"Average: {average:F2}");
                            Console.WriteLine("-------------------------");


                            if (students.Count == 0)
                            {
                                Console.WriteLine("No students found.");
                                return;
                            }

                            foreach (Student student in students)
                            {
                                double average = student.GetAverage();

                                Console.WriteLine($"\nName: {student.GetName()}");
                                Console.WriteLine($"Grades: {string.Join(",", student.GetGrades())}");
                                Console.WriteLine($"Average: {average:F2}");
                                Console.WriteLine("-------------------------");
                            }
>>>>>>> 9fcb5b220ebab67115a4ac95b611309acba11a73
                            break;
                        case 3:
                            Console.WriteLine("\n===== CLASS AVERAGE =====");
                            Console.WriteLine($"Overall Average Grade: {manager.ComputeAverage():F2}");

                            break;
                        case 4:
                            Console.Write("Top Student(s): ");
                            Console.WriteLine(string.Join(", ",
                                manager.GetHighest().Select(s => s.GetName())));
                            foreach (var s in manager.GetStudents())
                            {
                                Console.WriteLine(
                                    $"{s.GetName()} | G1={s.GetGrades()[0]} | G2={s.GetGrades()[1]} | G3={s.GetGrades()[2]} | Highest={s.GetHighestGrade()}");
                            }
                            Console.Write("Highest Grade: ");
                            Console.WriteLine(manager.GetHighest()[0].GetHighestGrade());
                            //Console.WriteLine("\n===== HIGHEST GRADE =====");
                            //Console.Write("Top Student: ");
                            //foreach (var s in manager.GetHighest())
                            //{
                            //    Console.WriteLine(string.Join(",", s.GetName()));
                            //}

                            //Console.Write("Highest Grade: ");
                            //foreach (var s in manager.GetHighest())
                            //{
                            //    Console.WriteLine(s.GetAverage());
                            //}

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
    