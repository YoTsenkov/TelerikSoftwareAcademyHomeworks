namespace SortByName
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var students = new[] 
            {
                new Student
                {
                    FirstName = "Alex",
                    LastName = "Jekov",
                },

                new Student
                {
                    FirstName = "Alex",
                    LastName = "Borisov",
                },

                new Student
                {
                    FirstName = "Stoqn",
                    LastName = "Haralampiev",
                },

                new Student 
                {
                    FirstName = "Chill",
                    LastName = "Bro",
                }
            };

            //LAMBDA
            var sortedStudents = students
                .OrderByDescending(st => st.FirstName)
                .ThenBy(st => st.LastName);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            //LINQ
            var sortedWithLINQ =
                from st in students
                orderby st.FirstName descending, st.LastName descending                
                select st;

            foreach (var student in sortedWithLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
