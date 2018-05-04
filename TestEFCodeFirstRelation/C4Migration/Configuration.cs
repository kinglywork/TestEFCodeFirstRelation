namespace TestEFCodeFirstRelation.C4Migration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestEFCodeFirstRelation.OneToMany.C4DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"C4Migration";
            ContextKey = "C4";
        }

        protected override void Seed(TestEFCodeFirstRelation.OneToMany.C4DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
