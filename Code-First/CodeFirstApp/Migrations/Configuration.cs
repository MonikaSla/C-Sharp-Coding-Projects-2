namespace CodeFirstApp.Migrations
{
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstApp.Models.CodeFirstAppContext>
    {
    public Configuration()
    {
    AutomaticMigrationsEnabled = false;
    ContextKey = "CodeFirstApp.Models.CodeFirstAppContext";
    }

    protected override void Seed(CodeFirstApp.Models.CodeFirstAppContext context)
    {
    //  This method will be called after migrating to the latest version.

    //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}