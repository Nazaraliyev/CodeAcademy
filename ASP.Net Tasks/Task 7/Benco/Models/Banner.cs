using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(200)]
        public string BackgroundImage { get; set; }


        [MaxLength(1000)]
        public string Content{ get; set; }
    }
}
