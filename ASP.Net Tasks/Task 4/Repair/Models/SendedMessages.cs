using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class SendedMessages
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100)]
        public string Name { get; set; }


        [MaxLength(100)]
        public string Mail { get; set; }


        [MaxLength(200)]
        public string Subject { get; set; }


        [MaxLength(500)]
        public string Messages { get; set; }
    }
}
