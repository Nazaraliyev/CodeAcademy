using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(20)]
        public string Name { get; set; }


        public List<ColorToProduct> colorToProducts { get; set; }
    }
}
