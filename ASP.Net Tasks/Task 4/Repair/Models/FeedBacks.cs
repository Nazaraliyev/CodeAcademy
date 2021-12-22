using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class FeedBacks
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100)]
        public string Name { get; set; }


        [MaxLength(200)]
        public string Positon { get; set; }



        [MaxLength(50)]
        public string Image { get; set; }


        [MaxLength(500)]
        public string Message { get; set; }
    }
}
