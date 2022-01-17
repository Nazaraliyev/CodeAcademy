using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sync_OnePage_Template_Asp.Net.Models
{
    public class Partner
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(250)]
        public string Image { get; set; }


        [NotMapped, Required]
        public IFormFile ImageFile { get; set; }
    }
}
