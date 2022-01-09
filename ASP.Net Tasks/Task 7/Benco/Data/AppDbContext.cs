using Benco.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Benco.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Banner> banners { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<BlogTag> blogTags { get; set; }
        public DbSet<Brend> brends { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Color> colors { get; set; }
        public DbSet<ColorToProduct> colorToProducts { get; set; }
        public DbSet<ColorToSize> ColorToSizes { get; set; }
        public DbSet<CostumeUser> costumeUsers { get; set; }
        public DbSet<Faq> faqs { get; set; }
        public DbSet<Favourite> favourites { get; set; }
        public DbSet<FeedBack> feedBacks { get; set; }
        public DbSet<Images> images { get; set; }
        public DbSet<Partner> partners { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<ProductTag> productTags { get; set; }
        public DbSet<Reviews> reviews { get; set; }
        public DbSet<SendedMessage> sendedMessages { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Settings> settings { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<SosialMedia> sosialMedias { get; set; }
        public DbSet<Subscribe> subscribes { get; set; }
        public DbSet<TagToBlog> tagToBlogs { get; set; }
        public DbSet<TagToProduct> tagToProducts { get; set; }
    }
}
