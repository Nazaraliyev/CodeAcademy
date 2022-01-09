using System;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class SendedMessage
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name { get; set; }


        [MaxLength(50)]
        public string Lastname { get; set; }


        [MaxLength(100)]
        public string Email { get; set; }


        [MaxLength(200)]
        public string Subject { get; set; }


        [MaxLength(2000)]
        public string Message { get; set; } 
        

        public DateTime CreatedTime { get; set; }
    }
}
