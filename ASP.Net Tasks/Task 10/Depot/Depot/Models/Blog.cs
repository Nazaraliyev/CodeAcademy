using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(200), Required]
        public string Tittle { get; set; }



        [MaxLength(2000),Required ]
        public string Content { get; set; }




        [MaxLength(250)]
        public string Cover { get; set; }


        [NotMapped]
        public IFormFile CoverFile { get; set; }



        public DateTime CreatedTime { get; set; }




        [ForeignKey("BlogCategoryId")]
        public int BlogCategoryId { get; set; }
        public BlogCategory blogCategory { get; set; }




        [ForeignKey("CostumeUserId")]
        public int CostumeUserId { get; set; }
        public CostumeUser CostumeUser { get; set; }


        public List<BlogImage> blogImages { get; set; }
        public List<TagToBlog> tagToBlogs { get; set; }
        public List<BlogComment> blogComments { get; set; }
    }
}
