using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_API.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50), Required]
        public string Name { get; set; }


        [MaxLength(50), Required]
        public string Lastname { get; set; }



        [MaxLength(100), Required]
        public string Email { get; set; }



        [MaxLength(15),Required]
        public string Phone { get; set; }



        [MaxLength(250)]
        public string Photo { get; set; }

        [NotMapped]
        public IFormFile PhotoFile { get; set; }



        [Range(0,700), Required, Column(TypeName = "money")]
        public decimal Score { get; set; }



        [ForeignKey("ClassId"), Required]
        public int ClassId { get; set; }
        public Class Class { get; set; }



        [ForeignKey("LevelId"), Required]
        public int LevelId { get; set; }
        public Level Level { get; set; }

    }
}
