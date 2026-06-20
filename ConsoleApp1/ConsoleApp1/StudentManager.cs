
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
    public Student[] GetHighest()
    {
        var max = students.Max(x => x.GetHighestGrade());

        return students
            .Where(x => x.GetHighestGrade() == max)
            .ToArray();
    }
}