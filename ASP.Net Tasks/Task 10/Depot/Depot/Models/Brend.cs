using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Depot.Models
{
    public class Brend
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100), Required]
        public string Name { get; set; }




        [MaxLength(2000)]
        public string Info { get; set; }




        [MaxLength(15)]
        public string Phone { get; set; }



        [MaxLength(100)]
        public string Mail { get; set; }




        [MaxLength(200)]
        public string Address { get; set; }



        public List<Product> products{ get; set; }
    }
}
