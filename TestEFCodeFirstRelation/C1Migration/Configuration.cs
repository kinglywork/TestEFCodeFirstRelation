namespace TestEFCodeFirstRelation.C1Migration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestEFCodeFirstRelation.OneToMany.C1DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"C1Migration";
            ContextKey = "C1";
        }

        protected override void Seed(TestEFCodeFirstRelation.OneToMany.C1DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
