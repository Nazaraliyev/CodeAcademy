using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Starx.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(200)]
        public string Tittle { get; set; }



        [Column(TypeName = "ntext")]
        public string Content { get; set; }



        [MaxLength(500)]
        public string CoverImg { get; set; }


        [NotMapped]
        public IFormFile ImageFile{ get; set; }


        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }



        public DateTime CreateTime { get; set; }





    }
}
