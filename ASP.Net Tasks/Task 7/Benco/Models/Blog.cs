using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(200)]
        public string Name { get; set; }


        [Column(TypeName = "ntext")]
        public string Content { get; set; }


        [MaxLength(200)]
        public string Cover { get; set; }


        [NotMapped]
        public IFormFile CoverFile { get; set; }



        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int CategoryId { get; set; }



        [ForeignKey("CostumeUserId")]
        public string CostumeUserId { get; set; }
        public CostumeUser CostumeUser { get; set; }


        public DateTime CreatedTime { get; set; }


        public bool CoverIsVideo  { get; set; }


        public List<TagToBlog> tagToBlogs { get; set; }
    }
}
