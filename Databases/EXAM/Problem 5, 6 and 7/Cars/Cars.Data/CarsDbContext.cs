namespace Cars.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cars.Models;

    public class CarsDbContext : DbContext
    {
        public CarsDbContext()
            : base ("Cars")
        {
        }

        public IDbSet<Car> Cars { get; set; }
        public IDbSet<City> Cities { get; set; }
        public IDbSet<Dealer> Dealers { get; set; }
        public IDbSet<Manufacturer> Manufacturers { get; set; }
    }
}
