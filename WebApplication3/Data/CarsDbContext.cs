using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;


namespace WebApplication3.Data
{
    public class CarsDbContext : DbContext
    {

        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options) 
        {

        }
        public DbSet<Officer> Officers { get; set; }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Officer>().HasData(

                new Officer
                {
                    OfficerID = 1,
                    Name = "Joe Smith",
                    Address = "121 fort rd",
                    Phone = "412-122-2212",
                    DriversLicenseNum = "121113",
                    DOB = "7-12-1998"
                },

                 new Officer
                 {
                     OfficerID = 2,
                     Name = "Joe nemeth",
                     Address = "121 tunnel rd",
                     Phone = "412-444-2212",
                     DriversLicenseNum = "677689",
                     DOB = "6-30-1998"
                 },

                  new Officer
                  {
                      OfficerID = 3,
                      Name = "addy Smith",
                      Address = "141 first rd",
                      Phone = "412-969-2212",
                      DriversLicenseNum = "909090",
                      DOB = "4-12-1969"
                  }

                );

            modelBuilder.Entity<Car>().HasData(

                 new Car
                 {
                     
                     VIN = 1234567,
                     LicensePlate = "lv7898",
                     Make = "Ford",
                     Model = "Ranger",
                     Mileage = "25000",
                     OfficerID = 3
                 },

                   new Car
                   {

                       VIN = 7654321,
                       LicensePlate = "lv1234",
                       Make = "Ford",
                       Model = "Ranger",
                       Mileage = "25000",
                       OfficerID = 2
                   },

                     new Car
                     {

                         VIN = 9292459,
                         LicensePlate = "lv8989",
                         Make = "Ford",
                         Model = "Ranger",
                         Mileage = "45000",
                         OfficerID = 1
                     }



                );
        }





    }
}
