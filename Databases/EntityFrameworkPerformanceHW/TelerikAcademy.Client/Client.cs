using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikAcademy.Data;

namespace TelerikAcademy.Client
{

    internal class Client
    {
        private static DbQuery<Employee> GetEmployeesWithInclude(TelerikAcademyEntities db)
        {
            var employees = db.Employees.Include("Address.Town").Include("Department");
            return employees;
        }

        private static DbQuery<Employee> GetEmployeesWithoutInclude(TelerikAcademyEntities db)
        {
            var employees = db.Employees;
            return employees;
        }

        private static IEnumerable<Town> GetTownsWithToList(TelerikAcademyEntities db)
        {
            var towns = db.Employees.ToList().Select(e => e.Address)
                                    .ToList().Select(e => e.Town).ToList().Where(t => t.Name == "Sofia");
            return towns;
        }

        private static IEnumerable<Town> GetTownsWithoutToList(TelerikAcademyEntities db)
        {
            var towns = db.Employees.Select(e => e.Address)
                                    .Select(a => a.Town)
                                    .Where(t => t.Name == "Sofia");

            return towns;
        }

        static void Main(string[] args)
        {
            var db = new TelerikAcademyEntities();
            using (db)
            {
                //task 1
                /*Stopwatch sw = new Stopwatch();
                sw.Start();
                var employees = GetEmployeesWithoutInclude(db);
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.Address.Town.Name);
                }
                var timeWithoutInclude = sw.Elapsed;
                sw.Restart();

                employees = GetEmployeesWithInclude(db);
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.Address.Town.Name);
                }
                Console.WriteLine("Time Without Include: " + timeWithoutInclude);
                Console.WriteLine("Time With Include: " + sw.Elapsed);*/

                //task 2
                /*Stopwatch sw = new Stopwatch();
                sw.Start();
                var towns = GetTownsWithoutToList(db);
                foreach (var town in towns)
                {
                    Console.WriteLine(town.Name);
                }
                var withoutToLIst = sw.Elapsed;

                sw.Restart();
                towns = GetTownsWithToList(db);
                foreach (var town in towns)
                {
                    Console.WriteLine(town.Name);
                }
                Console.WriteLine("Time with ToList: " + sw.Elapsed);
                Console.WriteLine("Time wihtout ToList: " + withoutToLIst);*/
            }




        }
    }
}
