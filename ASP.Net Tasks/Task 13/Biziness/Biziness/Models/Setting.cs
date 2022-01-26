using System.ComponentModel.DataAnnotations;

namespace Biziness.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(300)]
        public string Services { get; set; }



        [MaxLength(300)]
        public string Contact { get; set; }



        [MaxLength(500)]
        public string ContactContent { get; set; }



        [MaxLength(300)]
        public string Address { get; set; }



        [MaxLength(15), Phone]
        public string Phone { get; set; }



        [MaxLength(100), EmailAddress]
        public string Email { get; set; }
    }
}
