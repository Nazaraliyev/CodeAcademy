using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class Faq
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(200), Required]
        public string Question { get; set; }



        [MaxLength(2000),Required]
        public string Answer { get; set; }


        [MaxLength(20)]
        public string FaqCategory { get; set; }
    }
}
