using System.Collections.Generic;

namespace Lab11
{
    internal static class Extension
    {
        public static List<Student> FindStudents(this List<Student> students,
            Student.StudentPredicateDelegate findPredicate)
        {
            var result = new List<Student>();

            foreach (var student in students)
                if (findPredicate(student))
                    result.Add(student);

            return result;
        }
    }
}