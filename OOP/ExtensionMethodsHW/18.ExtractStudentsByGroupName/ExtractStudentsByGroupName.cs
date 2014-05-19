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

            var sortedByGroupName =
                from st in students
                orderby st.Groupname
                select st;

            foreach (var student in sortedByGroupName)
            {
                Console.WriteLine(student.Groupname);
            }
        }
    }
}
