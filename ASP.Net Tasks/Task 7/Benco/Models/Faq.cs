using System;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class Faq
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(500)]
        public string Question { get; set; }



        [MaxLength(2000)]
        public string Description { get; set; }
    }
}
