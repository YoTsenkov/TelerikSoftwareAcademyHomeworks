namespace Cars.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cars.Models;
    using Cars.Data;
    using Cars.Data.Migrations;
    using System.Data.Entity;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
using System.Xml.Linq;

    internal class Client
    {
        static void Main()
        {
            Database.SetInitializer
                   (new MigrateDatabaseToLatestVersion<CarsDbContext, Configuration>());
            var db = new CarsDbContext();

            //PROBLEM 6 (Populating from json)..i have disabled some configs to speed up the process
            /*db.Configuration.AutoDetectChangesEnabled = false;            
            for (int i = 0; i < 5; i++)
            {
                DbPopulator.PopulateFromJsonFile(db, "../../data." + i + ".json");
            }

            db.Configuration.AutoDetectChangesEnabled = true;*/
                        

            //PROBLEM 7 (it saves the files in Cars.Client/bin/debug folder)
            //CarQueriesProccessor.ProccessQueriesFromXml(db, "../../Queries.xml");
        }
    }
}
