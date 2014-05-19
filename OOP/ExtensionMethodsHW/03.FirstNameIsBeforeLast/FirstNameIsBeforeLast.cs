namespace FirstNameIsBeforeLast
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
                    LastName = "Bojkov"
                },
                new Student
                { 
                    FirstName = "Bojko",
                    LastName = "Angelov"
                }
            };

            //with LINQ
            var resultStudentsWithLINQ =
                from st in students
                where st.FirstName.CompareTo(st.LastName) == -1
                select st;

            foreach (var student in resultStudentsWithLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }




           // //with lambda
           // var resultStudentsWithLambda = students
           //     .Where(st => st.FirstName.CompareTo(st.LastName) == -1);
           //
           //
           //foreach (var student in resultStudentsWithLambda)
           //{
           //    Console.WriteLine(student.FirstName + " " + student.LastName);
           //}
        }
    }
}
