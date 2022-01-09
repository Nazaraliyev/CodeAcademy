using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Benco.Models
{
    public class Brend
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string Name{ get; set; }


        [MaxLength(200)]
        public string Address{ get; set; }


        [MaxLength(100)]
        public string Email{ get; set; }


        [MaxLength(15)]
        public string Phone{ get; set; }


        [MaxLength(30)]
        public string Cart{ get; set; }


        public List<Product> products { get; set; }
    }
}
