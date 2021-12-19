using Microsoft.EntityFrameworkCore;
using SixteenClothing.Models;

namespace SixteenClothing.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Settings> Settings { get; set; }

        public DbSet<HomeBanners> HomeBanners { get; set; }

        public DbSet<ContactUsAccordions> contactUsAccordions { get; set; }

        public DbSet<SosialMedia> SosialMedias { get; set; }

        public DbSet<Partners> Partners { get; set; }

        public DbSet<Quality> Qualities { get; set; }

        public DbSet<Speciality> Specialities { get; set; }

        public DbSet<TeamMembers> TeamMembers { get; set; }

        public DbSet<MemberSosialNetwork> MemberSosialNetworks { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Messages> Messages { get; set; }

    }
}
