namespace Competition.Web.Migrations
{
    using Competition.Web.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Competition.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Competition.Web.Models.ApplicationDbContext";
        }

        protected override void Seed(Competition.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            
            //var roles = new List<ApplicationRole>
            //{
            //    new ApplicationRole{ Name = "考官"},
            //    new ApplicationRole{ Name = "管理员"}
            //};
            //roles.ForEach(s => context.Roles.AddOrUpdate(s));
            //context.SaveChanges();
            ////var user = new ApplicationUser { UserName = "admin", Email = "1@1.com", StaffId = "admin" };
            ////var result = accountController.UserManager.CreateAsync(user, "123456");
            ////roleController.UserManager.AddToRoleAsync(user.Id, "管理员");

         
            ////context.Users.AddOrUpdate(new ApplicationUser() { RealName = "管理员", UserName = "admin", PasswordHash = "" });
            ////context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "考官" }, new IdentityRole { Name = "管理员" });
            ////context.Roles.AddOrUpdate(new IdentityRole { Name = "考官" }, new IdentityRole { Name = "管理员" });

            //base.Seed(context);
        }
    }
}
