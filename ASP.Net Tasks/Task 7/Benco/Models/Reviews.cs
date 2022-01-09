using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class Reviews
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100)]
        public string Name { get; set; }


        public List<Product> products { get; set; }
    }
}
