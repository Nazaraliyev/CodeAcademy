using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oxu.az.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Logo  { get; set; }



        [Column(TypeName = "ntext")]
        public string About { get; set; }




        [Column(TypeName = "ntext")]
        public string Ads { get; set; }



        public int Phone { get; set; }



        [MaxLength(200)]
        public string Adress { get; set; }



        [MaxLength(200)]
        public string Mail { get; set; }

    }
}
