using Microsoft.EntityFrameworkCore;
using Repair.Models;

namespace Repair.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Settings> settings { get; set; }
        public DbSet<SendedMessages> sendedMessages { get; set; }
        public DbSet<WorksCount> worksCounts { get; set; }
        public DbSet<SosialMedias> sosialMedias { get; set; }
        public DbSet<Partners> partners { get; set; }
        public DbSet<Subscribes> subscribes { get; set; }
        public DbSet<EstimateList> estimateLists { get; set; }
        public DbSet<Services> services { get; set; }
        public DbSet<FeedBacks> feedBacks { get; set; }
        public DbSet<Accordion> accordions { get; set; }
        public DbSet<WorkingProsesStep> workingProses { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<AuthorSosialMedias> authorSosialMedias { get; set; }
        public DbSet<BlogCategory> blogCategories { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<tagToBlog> tagToBlogs { get; set; }
        public DbSet<AuthorToBlog> authorToBlogs { get; set; }
        public DbSet<Blogimage> blogimages { get; set; }
        public DbSet<BlogComment> blogComments { get; set; }
    }
}
