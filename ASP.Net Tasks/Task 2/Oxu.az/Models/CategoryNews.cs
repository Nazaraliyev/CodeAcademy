using System.ComponentModel.DataAnnotations;

namespace Oxu.az.Models
{
    public class CategoryNews
    {
        [Key]
        public int Id { get; set; }



        public Category Category { get; set; }
        public News News { get; set; }

    }
}
