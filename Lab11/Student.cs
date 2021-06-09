namespace Lab11
{
    public class Student
    {
        public delegate bool StudentPredicateDelegate(Student student);

        public Student(string fname, string lname, int age)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static bool IsAdult(Student student)
        {
            return student.Age >= 18;
        }

        public static bool FNameStartsWithA(Student student)
        {
            return student.FirstName?[0] == 'A';
        }

        public static bool LNameLongerThanThree(Student student)
        {
            return student.LastName?.Length > 3;
        }

        public override string ToString()
        {
            return $" | First name: {FirstName} | " +
                   $" | Last Name: {LastName} | " +
                   $" | Age: {Age} | ";
        }
    }
}