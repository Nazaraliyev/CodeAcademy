using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }


        public int Rate { get; set; }
    }
}
