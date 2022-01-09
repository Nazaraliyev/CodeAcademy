using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Favourite
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("CostumeUser")]
        public string CostumeUserId { get; set; }
        public CostumeUser CostumeUser { get; set; }



        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
