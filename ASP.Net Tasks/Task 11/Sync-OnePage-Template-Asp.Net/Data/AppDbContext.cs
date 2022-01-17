using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sync_OnePage_Template_Asp.Net.Models;

namespace Sync_OnePage_Template_Asp.Net.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }


        public DbSet<Setting> settings { get; set; }
        public DbSet<CostumeUser> costumeUsers { get; set; }
        public DbSet<Counter> counters { get; set; }
        public DbSet<Description> descriptions { get; set; }
        public DbSet<Feature> features { get; set; }
        public DbSet<Partner> partners { get; set; }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<Special> specials { get; set; }
        public DbSet<Testimonal> testimonals { get; set; }
    }
}
