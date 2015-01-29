namespace FinancialsTracker.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FinancialsTracker.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FinancialsTracker.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinancialsTracker.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Purchases.AddOrUpdate(p => p.UserId,
                new Purchase
                {
                    UserId = 1,
                    Name = "Mars Bar",
                    Price = 1,
                    Quantity = 1,
                    Latitude = -33.8185242,
                    Longitude = 151.1927715,
                    DateTime = @DateTime.Now,
                    Location = "St. Leonard's",
                });
            
        }
    }
}
