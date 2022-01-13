using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50), Required]
        public string Name { get; set; }


        public List<ColorToProduct> colorToProducts { get; set; }
    }
}
