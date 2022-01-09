using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class Size
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(5)]
        public string Name { get; set; }



        public List<ColorToSize> colorToSizes { get; set; }
    }
}
