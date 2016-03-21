namespace ManufacturingReporting.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationManufacturingDB : DbMigrationsConfiguration<ManufacturingReporting.Models.ApplicationDbContext>
    {
        public ConfigurationManufacturingDB()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManufacturingReporting.Models.ApplicationDbContext context)
        {

        }
    }
}
