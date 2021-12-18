using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oxu.az.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }



        [Column(TypeName = "ntext")]
        public string About { get; set; }



        public int Phone { get; set; }



        [MaxLength(200)]
        public string Adress { get; set; }



        [MaxLength(200)]
        public string Mail { get; set; }



        [MaxLength(200)]
        public string Facebook { get; set; }



        [MaxLength(200)]
        public string Twitter { get; set; }



        [MaxLength(200)]
        public string Telegram { get; set; }



        [MaxLength(200)]
        public string Android { get; set; }



        [MaxLength(200)]
        public string Aplle { get; set; }
    }
}
