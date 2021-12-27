using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repair.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(200), Required]
        public string Tittle { get; set; }


        [Column(TypeName = "ntext"), Required]
        public string Content { get; set; }


        [MaxLength(50)]
        public string CoverImage { get; set; }



        [NotMapped]
        public IFormFile formFile { get; set; }

        public BlogCategory BlogCategory { get; set; }


        public DateTime CreateTime { get; set; }


        public int WatchCount { get; set; }
    }
}
