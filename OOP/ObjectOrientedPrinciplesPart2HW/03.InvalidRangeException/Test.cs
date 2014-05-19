using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;



namespace _03.InvalidRangeException
{
    class Test
    {
        static void Main()
        {
            //int startInt = int.Parse(Console.ReadLine());
            //int endInt = int.Parse(Console.ReadLine());

            //if (startInt < endInt && startInt >= 1 && endInt <= 100)
            //{
            //    throw new InvalidRangeException<int>("Invalid range of Int", startInt, endInt);
            //}

            string usersDateTime = Console.ReadLine();

            string startString = "1/1/1980";
            string endString = "31/12/2013";

            DateTime usersDate = DateTime.Parse(usersDateTime);

            DateTime startDate = DateTime.Parse(startString);
            DateTime endDate = DateTime.Parse(endString);

            if (usersDate > startDate && usersDate < endDate)
            {
                throw new InvalidRangeException<DateTime>("DateTime out of range.", startDate, endDate);
            }
        }
    }
}
