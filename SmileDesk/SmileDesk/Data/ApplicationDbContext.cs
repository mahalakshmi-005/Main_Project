using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmileDesk.Models;

namespace SmileDesk.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ApplicationRole admin = new ApplicationRole();
            admin.Id = 1;
            admin.Name = "admin";
            admin.NormalizedName = "Administrator";

            ApplicationRole ngo = new ApplicationRole();
            ngo.Id = 2;
            ngo.Name = "NGO";
            ngo.NormalizedName = "NGO";

            ApplicationRole donor = new ApplicationRole();
            donor.Id = 3;
            donor.Name = "donor";
            donor.NormalizedName = "Donor";

            builder.Entity<ApplicationRole>().HasData(admin, ngo, donor);
        }

    }
}