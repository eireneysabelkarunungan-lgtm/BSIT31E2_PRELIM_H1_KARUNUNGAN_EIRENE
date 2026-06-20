
    public class Student
    {
        string Name;
        double Grade1;
        double Grade2;
        double Grade3;

        public Student(string name, double grade1, double grade2, double  )
        {
            Name = name;
            Grade1 = grade1;
            Grade2 = grade2;
            Grade3 = grade3;    
        }

    public string GetName()
    {

        return Name;
    }

    public double[] GetGrades()
    {


        return [Grade1, Grade2, Grade3];
    }

    public double GetAverage()
    {
        return Grade1 + Grade2 + Grade3 / 3;
    }
}

