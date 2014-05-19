namespace _18.ExtractStudentsByGroupName
{
    using System;
    using System.Linq;
    class ExtractStudentsByGroupName
    {
        static void Main()
        {
            var students = new[]
            {
                new {Groupname = "abcd"},
                new {Groupname = "bacd"},
                new {Groupname = "dbcd"},
                new {Groupname = "aacd"},
            };

            var sortedByGroupName = students
                .OrderBy(st => st.Groupname);

            foreach (var student in sortedByGroupName)
            {
                Console.WriteLine(student.Groupname);
            }
        }
    }
}
