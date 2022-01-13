using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(200), Required]
        public string Header { get; set; }



        [MaxLength(500), Required]
        public string Content { get; set; }



        [MaxLength(250)]
        public string Image { get; set; }


        [NotMapped, Required]
        public IFormFile ImageFile { get; set; }
    }
}
