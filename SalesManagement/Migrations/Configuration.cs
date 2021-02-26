namespace SalesManagement.Migrations
{
    using SalesManagement.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesManagement.Models.CafeDatabase>
    {
        public Configuration()
        {
	    Database.SetInitializer(new CreateDatabaseIfNotExists<CafeDatabase>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CafeDatabase>());
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SalesManagement.Models.CafeDatabase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if (context.Users.Count() <= 0)
            {
                Cafe cafe = new Cafe();
                User user = new User()
                {
                    Password = cafe.Hash("admin@123", "012345678"),
                    Username = "admin"
                };
                context.Users.Add(user);
            }

            base.Seed(context);

        }
    }
}
