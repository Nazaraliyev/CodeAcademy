using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_API.Model
{
    public class Class
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(20), Required]
        public string ClassNo { get; set; }



        [Required]
        public int Capacity { get; set; }



        [ForeignKey("DegreId"), Required]
        public int DegreId { get; set; }
        public Degre Degre { get; set; }



        [ForeignKey("QualificationId")]
        public int QualificationId { get; set; }
        public Qualification Qualification { get; set; }



        public List<Student> Students { get; set; }
    }
}
