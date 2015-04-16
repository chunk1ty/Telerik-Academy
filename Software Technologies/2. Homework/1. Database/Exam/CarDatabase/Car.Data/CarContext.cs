namespace Car.Data
{
    using System.Data.Entity;

    using Car.Data.Migrations;
    using Car.Models;


    public class CarContext : DbContext
    {
        public CarContext()
            : base("CarConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarContext, Configuration>());
        }

        public IDbSet<CarClass> Cars { get; set; }

        public IDbSet<City> Cities { get; set; }

        public IDbSet<Dealer> Dealers { get; set; }

        public IDbSet<Manufacturer> Manufacturers { get; set; }
    }
}
