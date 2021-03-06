namespace ManufacturingReporting.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationApplicationDB : DbMigrationsConfiguration<ManufacturingReporting.Models.ApplicationDbContext>
    {
        public ConfigurationApplicationDB()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManufacturingReporting.Models.ApplicationDbContext context)
        {
            RoleStore<IdentityRole> roleStore = new RoleStore<IdentityRole>(context);
            RoleManager<IdentityRole> roleManager = new RoleManager<IdentityRole>(roleStore);
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new ApplicationUserManager(userStore);
            ApplicationUser admin = new ApplicationUser { UserName = "admin@gmail.com" };

            userManager.Create(admin, password: "password");
            roleManager.Create(new IdentityRole { Name = "admin" });
            userManager.AddToRole(admin.Id, "admin");
        }
    }
}
