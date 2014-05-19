//Ctr + E,C comments Ctr + E,U uncomments for easy navigation

namespace _09AndAbove
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            var students = new[] 
            {
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Valkov",
                    Email = "ivan@abv.bg",
                    Tel = "02125467",
                    GroupNumber = 1,
                    FN = 123406,
                    Marks = new List<int>{2,2,6,4,5,6},
                    Group = new Group("Biology")
                },

                new Student
                {
                    FirstName = "Mladen",
                    LastName = "Spasov",
                    Email = "mladen@gmail.com",
                    Tel = "34125467",
                    GroupNumber = 2,
                    FN = 123402,
                    Marks = new List<int>{2,2,3,4,5,6},
                    Group = new Group("Biology")
                },

                new Student
                {
                    FirstName = "Hasinta",
                    LastName = "Vatev",
                    Email = "hasinta@yahoo.com",
                    Tel = "02123467",
                    GroupNumber = 3,
                    FN = 123406,
                    Marks = new List<int>{2,6,3,2,5,4},
                    Group = new Group("Mathematics")
                },

                new Student
                {
                    FirstName = "Bojka",
                    LastName = "Stoimenova",
                    Email = "bojka@abv.bg",
                    Tel = "92125467",
                    GroupNumber = 2,
                    FN = 123403,
                    Marks = new List<int>{2,2,3,4,5,2},
                    Group = new Group("Chemistry")
                },

                new Student
                {
                    FirstName = "Qvor",
                    LastName = "Zlatkov",
                    Email = "qvor@abv.bg",
                    Tel = "55125467",
                    GroupNumber = 5,
                    FN = 123400,
                    Marks = new List<int>{3,3,3,3,3,3},
                    Group = new Group("Sports")
                },

                new Student
                {
                    FirstName = "Zlatomir",
                    LastName = "Buyukliev",
                    Email = "zlatomir@gmail.com",
                    Tel = "02125467",
                    GroupNumber = 5,
                    FN = 123406,
                    Marks = new List<int>{6,6,2,6,6,6},
                    Group = new Group("Mathematics")
                }
            };

            //TASK 09

            //var sortedByGroupAndName =
            //    from st in students
            //    where st.GroupNumber == 2
            //    orderby st.FirstName
            //    select st;

            //foreach (var student in sortedByGroupAndName)
            //{
            //    Console.WriteLine(student.FirstName + " " + student.GroupNumber);
            //}

            //END OF TASK 09


            //TASK 10

            //var sortedByGroupAndName = students
            //    .Where(st => st.GroupNumber == 2)
            //    .OrderBy(st => st.FirstName);

            //foreach (var student in sortedByGroupAndName)
            //{
            //    Console.WriteLine(student.FirstName + " " + student.GroupNumber);
            //}

            //END OF TASK 10

            //TASK 11

            //var sortedByEmail =
            //    from st in students
            //    where st.Email.Contains("@abv.bg")
            //    select st;

            //foreach (var student in sortedByEmail)
            //{
            //    Console.WriteLine(student.FirstName + " " + student.Email);
            //}

            //END OF TASK 11

            //TASK 12

            //var sortedByPhone =
            //    from st in students
            //    where st.Tel.StartsWith("02") == true
            //    select st;

            //foreach (var student in sortedByPhone)
            //{
            //    Console.WriteLine(student.FirstName + " " + student.Tel);
            //}

            //END OF TASK 12

            //TASK 13

            //var sortedBySixMarks =
            //    from st in students
            //    where st.Marks.Contains(6)
            //    select new
            //    {
            //        FullName = string.Format("{0} {1}", st.FirstName, st.LastName),
            //        Marks = st.Marks
            //    };

            //foreach (var student in sortedBySixMarks)
            //{
            //    Console.Write(student.FullName + " ");

            //    foreach (var mark in student.Marks)
            //    {
            //        Console.Write(mark + " ");
            //    }

            //    Console.WriteLine();
            //}

            //END OF TASK 13

            //TASK 14

            //var sortedByTwoMarks = students
            //    .Where(st => st.Marks.Count(m => m.Equals(2)) == 2);

            //foreach (var student in sortedByTwoMarks)
            //{
            //    Console.WriteLine(student.FirstName);
            //}

            //END OF TASK 14

            //TASK 15

            //var sortedByFN = students
            //    .Where(st => st.FN.ToString().EndsWith("06"));

            //foreach (var student in sortedByFN)
            //{
            //    Console.Write(student.FirstName + " ");

            //    foreach (var mark in student.Marks)
            //    {
            //        Console.Write(mark + " ");
            //    }

            //    Console.WriteLine();
            //}

            //END OF TASK 15

            //TASK 16

            //var sortedByDepartment = students
            //    .Where(st => st.Group.DepartmentName == "Mathematics");

            //foreach (var student in sortedByDepartment)
            //{
            //    Console.WriteLine(student.FirstName);
            //}

            //END OF TASK 16
        }
    }
}
