using System.ComponentModel.DataAnnotations;

namespace Sync_OnePage_Template_Asp.Net.Models
{
    public class Counter
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50), Required]
        public string Icon { get; set; }


        [MaxLength(100), Required]
        public string Name { get; set; }


        [Required]
        public int Count { get; set; }
    }
}
