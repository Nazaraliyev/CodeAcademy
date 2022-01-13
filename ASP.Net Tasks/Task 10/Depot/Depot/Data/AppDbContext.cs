using Depot.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Depot.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }


        public DbSet<Banner> banners { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<BlogCategory> blogCategories { get; set; }
        public DbSet<BlogComment> blogComments { get; set; }
        public DbSet<BlogTag> blogTags { get; set; }
        public DbSet<BlogImage> blogImages { get; set; }
        public DbSet<Brend> brends { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Color> colors { get; set; }
        public DbSet<ColorToProduct> colorToProducts { get; set; }
        public DbSet<CostumeUser> costumeUsers { get; set; }
        public DbSet<Faq> faqs { get; set; }
        public DbSet<Material> materials { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<ProductImage> productImages { get; set; }
        public DbSet<ProductComment> productComments { get; set; }
        public DbSet<ProductTag> productTags { get; set; }
        public DbSet<Setting> settings { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<Stor> stors { get; set; }
        public DbSet<Subscribe> subscribes { get; set; }
        public DbSet<TagToBlog> tagToBlogs { get; set; }
        public DbSet<TagToProduct> tagToProducts { get; set; }
        public DbSet<Testimonal> testimonals { get; set; }
        public DbSet<UserSocialMedia> userSocialMedias { get; set; }
        public DbSet<UserToSocialMedia> userToSocialMedias { get; set; }
        public DbSet<Wish> wishes { get; set; }


    }
}
