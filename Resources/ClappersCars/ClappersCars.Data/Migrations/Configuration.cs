using ClappersCars.Models;

namespace ClappersCars.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClappersCars.Models.ClappersCarsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ClappersCars.Models.ClappersCarsContext context)
        {
            //  This method will be called after migrating to the latest version.
            //context.Vehicles.AddOrUpdate(v => new { v.Make,v.Model,v.Year}, new Vehicle
            //{
            //};
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
        }
    }
}