using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Simple_API.Model
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100), Required]
        public string Name { get; set; }



        [MaxLength(10)]
        public string SmaaName { get; set; }


        public List<Qualification> qualifications { get; set; }
    }
}
