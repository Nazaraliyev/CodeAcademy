using System.ComponentModel.DataAnnotations;

namespace Biziness.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100), Required]
        public string Header { get; set; }



        [MaxLength(100), Required]
        public string Text { get; set; }



        [MaxLength(300), Required]
        public string Link { get; set; }


        [Required]
        public string Image { get; set; }
    }
}
