using System;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100)]
        public string Email { get; set; }


        public DateTime CreatedTime { get; set; }
    }
}
