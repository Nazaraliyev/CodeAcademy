using System.ComponentModel.DataAnnotations;

namespace Sync_OnePage_Template_Asp.Net.Models
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100)]
        public string Name { get; set; }



        [MaxLength(500), Required]
        public string Content { get; set; }



        [MaxLength(50)]
        public string Icon { get; set; }



        [MaxLength(10)]
        public string Color { get; set; }




    }
}
