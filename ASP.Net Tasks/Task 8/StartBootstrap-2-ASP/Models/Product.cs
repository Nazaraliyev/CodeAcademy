using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartBootstrap_2_ASP.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(200)]
        public string Image { get; set; }


        [NotMapped]
        public IFormFile ImageFile { get; set; }




        [MaxLength(100)]
        public string Name { get; set; }




        [Column(TypeName = "tinyint")]
        public byte Star { get; set; }



        [Column(TypeName = "money")]
        public decimal Price { get; set; }



        public DateTime CreatedTime { get; set; }




        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
