using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }


        [MaxLength(200)]
        public string Description { get; set; }


        [MaxLength(50)]
        public string Icon { get; set; }
    }
}
