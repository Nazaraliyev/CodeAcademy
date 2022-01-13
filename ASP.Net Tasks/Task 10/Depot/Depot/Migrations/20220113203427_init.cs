using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Depot.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DayOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "blogCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "blogTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "brends",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Info = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brends", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "faqs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    FaqCategory = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faqs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AboutBanner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AboutContent = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AboutService = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AboutHistory = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AboutImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FaqBanner = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "socialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "subscribes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscribes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "testimonals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testimonals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userSocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userSocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Cover = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogCategoryId = table.Column<int>(type: "int", nullable: false),
                    CostumeUserId = table.Column<int>(type: "int", nullable: false),
                    CostumeUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_blogs_AspNetUsers_CostumeUserId1",
                        column: x => x.CostumeUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_blogs_blogCategories_BlogCategoryId",
                        column: x => x.BlogCategoryId,
                        principalTable: "blogCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Info = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    BrendId = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_brends_BrendId",
                        column: x => x.BrendId,
                        principalTable: "brends",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_productCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "productCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userToSocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostumeUserId = table.Column<int>(type: "int", nullable: false),
                    costumeUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SocialMedia = table.Column<int>(type: "int", nullable: false),
                    userSocialMediaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userToSocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userToSocialMedias_AspNetUsers_costumeUserId",
                        column: x => x.costumeUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_userToSocialMedias_userSocialMedias_userSocialMediaId",
                        column: x => x.userSocialMediaId,
                        principalTable: "userSocialMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "blogComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    CostumeUserId = table.Column<int>(type: "int", nullable: false),
                    costumeUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BlogCommentId = table.Column<int>(type: "int", nullable: false),
                    blogCommentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_blogComments_AspNetUsers_costumeUserId",
                        column: x => x.costumeUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_blogComments_blogComments_blogCommentId",
                        column: x => x.blogCommentId,
                        principalTable: "blogComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_blogComments_blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "blogImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_blogImages_blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tagToBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    BlogTagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tagToBlogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tagToBlogs_blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tagToBlogs_blogTags_BlogTagId",
                        column: x => x.BlogTagId,
                        principalTable: "blogTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "colorToProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<decimal>(type: "money", nullable: false),
                    DiscountTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colorToProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_colorToProducts_colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_colorToProducts_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productImages_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tagToProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tagToProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tagToProducts_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tagToProducts_productTags_ProductTagId",
                        column: x => x.ProductTagId,
                        principalTable: "productTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostumeUserId = table.Column<int>(type: "int", nullable: false),
                    CostumeUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ColorToProductId = table.Column<int>(type: "int", nullable: false),
                    Quentity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_carts_AspNetUsers_CostumeUserId1",
                        column: x => x.CostumeUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_carts_colorToProducts_ColorToProductId",
                        column: x => x.ColorToProductId,
                        principalTable: "colorToProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColorToProductMaterial",
                columns: table => new
                {
                    colorToProductsId = table.Column<int>(type: "int", nullable: false),
                    materialsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorToProductMaterial", x => new { x.colorToProductsId, x.materialsId });
                    table.ForeignKey(
                        name: "FK_ColorToProductMaterial_colorToProducts_colorToProductsId",
                        column: x => x.colorToProductsId,
                        principalTable: "colorToProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorToProductMaterial_materials_materialsId",
                        column: x => x.materialsId,
                        principalTable: "materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Star = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ColorToProductId = table.Column<int>(type: "int", nullable: false),
                    CostumeUserId = table.Column<int>(type: "int", nullable: false),
                    costumeUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductCommentId = table.Column<int>(type: "int", nullable: false),
                    productCommentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productComments_AspNetUsers_costumeUserId",
                        column: x => x.costumeUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productComments_colorToProducts_ColorToProductId",
                        column: x => x.ColorToProductId,
                        principalTable: "colorToProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productComments_productComments_productCommentId",
                        column: x => x.productCommentId,
                        principalTable: "productComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostumeUserId = table.Column<int>(type: "int", nullable: false),
                    CostumeUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ColorToProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_wishes_AspNetUsers_CostumeUserId1",
                        column: x => x.CostumeUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wishes_colorToProducts_ColorToProductId",
                        column: x => x.ColorToProductId,
                        principalTable: "colorToProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_blogComments_blogCommentId",
                table: "blogComments",
                column: "blogCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_blogComments_BlogId",
                table: "blogComments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_blogComments_costumeUserId",
                table: "blogComments",
                column: "costumeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_blogImages_BlogId",
                table: "blogImages",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_BlogCategoryId",
                table: "blogs",
                column: "BlogCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_CostumeUserId1",
                table: "blogs",
                column: "CostumeUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_carts_ColorToProductId",
                table: "carts",
                column: "ColorToProductId");

            migrationBuilder.CreateIndex(
                name: "IX_carts_CostumeUserId1",
                table: "carts",
                column: "CostumeUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ColorToProductMaterial_materialsId",
                table: "ColorToProductMaterial",
                column: "materialsId");

            migrationBuilder.CreateIndex(
                name: "IX_colorToProducts_ColorId",
                table: "colorToProducts",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_colorToProducts_ProductId",
                table: "colorToProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_productComments_ColorToProductId",
                table: "productComments",
                column: "ColorToProductId");

            migrationBuilder.CreateIndex(
                name: "IX_productComments_costumeUserId",
                table: "productComments",
                column: "costumeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_productComments_productCommentId",
                table: "productComments",
                column: "productCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_productImages_ProductId",
                table: "productImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_products_BrendId",
                table: "products",
                column: "BrendId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductCategoryId",
                table: "products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tagToBlogs_BlogId",
                table: "tagToBlogs",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_tagToBlogs_BlogTagId",
                table: "tagToBlogs",
                column: "BlogTagId");

            migrationBuilder.CreateIndex(
                name: "IX_tagToProducts_ProductId",
                table: "tagToProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tagToProducts_ProductTagId",
                table: "tagToProducts",
                column: "ProductTagId");

            migrationBuilder.CreateIndex(
                name: "IX_userToSocialMedias_costumeUserId",
                table: "userToSocialMedias",
                column: "costumeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_userToSocialMedias_userSocialMediaId",
                table: "userToSocialMedias",
                column: "userSocialMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_wishes_ColorToProductId",
                table: "wishes",
                column: "ColorToProductId");

            migrationBuilder.CreateIndex(
                name: "IX_wishes_CostumeUserId1",
                table: "wishes",
                column: "CostumeUserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "banners");

            migrationBuilder.DropTable(
                name: "blogComments");

            migrationBuilder.DropTable(
                name: "blogImages");

            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.DropTable(
                name: "ColorToProductMaterial");

            migrationBuilder.DropTable(
                name: "faqs");

            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "productComments");

            migrationBuilder.DropTable(
                name: "productImages");

            migrationBuilder.DropTable(
                name: "settings");

            migrationBuilder.DropTable(
                name: "socialMedias");

            migrationBuilder.DropTable(
                name: "stors");

            migrationBuilder.DropTable(
                name: "subscribes");

            migrationBuilder.DropTable(
                name: "tagToBlogs");

            migrationBuilder.DropTable(
                name: "tagToProducts");

            migrationBuilder.DropTable(
                name: "testimonals");

            migrationBuilder.DropTable(
                name: "userToSocialMedias");

            migrationBuilder.DropTable(
                name: "wishes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "materials");

            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "blogTags");

            migrationBuilder.DropTable(
                name: "productTags");

            migrationBuilder.DropTable(
                name: "userSocialMedias");

            migrationBuilder.DropTable(
                name: "colorToProducts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "blogCategories");

            migrationBuilder.DropTable(
                name: "colors");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "brends");

            migrationBuilder.DropTable(
                name: "productCategories");
        }
    }
}
