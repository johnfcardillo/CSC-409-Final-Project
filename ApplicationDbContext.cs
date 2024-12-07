using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CSC409_Final.Models;
using Microsoft.AspNetCore.Identity;

namespace CSC409_Final.Data
{

    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";
            var client = new IdentityRole("client");
            client.NormalizedName = "client";
            builder.Entity<IdentityRole>().HasData(admin, client);
        }
    }
}
