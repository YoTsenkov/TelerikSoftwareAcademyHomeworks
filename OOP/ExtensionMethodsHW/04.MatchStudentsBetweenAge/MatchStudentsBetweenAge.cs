namespace MatchStudentsBetweenAge
{
    using System;
    using System.Linq;
    class MatchStudentsBetweenAge
    {
        static void Main()
        {
            var students = new[] 
            {
                new Student
                {
                    FirstName = "Alex",
                    LastName = "Jekov",
                    Age = 15
                },

                new Student
                {
                    FirstName = "Hasinta",
                    LastName = "Ivanova",
                    Age = 53
                },

                new Student
                {
                    FirstName = "Stoqn",
                    LastName = "Haralampiev",
                    Age = 20
                },

                new Student 
                {
                    FirstName = "Chill",
                    LastName = "Bro",
                    Age = 23
                }
            };

            //with LINQ
            var resultStudentsLINQ =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select st;

            foreach (var student in resultStudentsLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }


           //// with LAMBDA
           //var resultStudents = students.Where(st => st.Age >= 18 && st.Age <= 24);
           //
           //foreach (var student in resultStudents)
           //{
           //    Console.WriteLine(student.FirstName + " " + student.LastName);
           //}
        }
    }
}
