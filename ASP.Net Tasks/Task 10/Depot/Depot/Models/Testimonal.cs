using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class Testimonal
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100), Required]
        public string Name { get; set; }



        [MaxLength(1000), Required]
        public string Content { get; set; }



        [MaxLength(100), Required]
        public string Position { get; set; }



        [MaxLength(250)]
        public string Image { get; set; }


        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
