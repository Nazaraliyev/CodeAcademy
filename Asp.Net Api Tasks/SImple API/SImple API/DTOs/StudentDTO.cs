using Simple_API.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_API.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }



        [MaxLength(50), Required]
        public string Name { get; set; }



        [MaxLength(50), Required]
        public string Lastname { get; set; }



        [MaxLength(100), Required, EmailAddress]
        public string Email { get; set; }



        [MaxLength(15), Required, Phone]
        public string Phone { get; set; }


        public string Photo { get; set; }


        [Required]
        public decimal Score { get; set; }


        [Required]
        public int ClassId { get; set; }


        [Required]
        public int LevelId { get; set; }


        public ClassDTO Class { get; set; }
        public LevelDTO Level { get; set; }
    }
}
