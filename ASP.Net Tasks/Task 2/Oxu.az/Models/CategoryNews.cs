using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oxu.az.Models
{
    public class CategoryNews
    {
        [Key]
        public int Id { get; set; }



        public News News { get; set; }


        public Category Category { get; set; }

    }
}
