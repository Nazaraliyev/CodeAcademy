using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_API.Model
{
    public class Qualification
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(100), Required]
        public string Name { get; set; }



        [Range(200,700), Column(TypeName = "money")]
        public  decimal FreeScore { get; set; }



        [Range(200, 700), Column(TypeName = "money")]
        public  decimal PaidScore { get; set; }


        [ForeignKey("FacultyId")]
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }


        public List<Class> Classes { get; set; }
    }
}
