using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Name { get; set; }


        public List<ColorToProduct> colorToProducts { get; set; }
    }
}
