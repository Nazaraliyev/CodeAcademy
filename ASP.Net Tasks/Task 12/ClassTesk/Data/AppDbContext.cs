using ClassTesk.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTesk.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base (options)
        {

        }

        public  DbSet<Settings> settings { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<CostumeUser> costumeUsers { get; set; }
    }

}
