using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Depot.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }



        [ForeignKey("CostumeUserId")]
        public int CostumeUserId { get; set; }
        public CostumeUser CostumeUser { get; set; }




        [ForeignKey("ColorToProductId")]
        public int ColorToProductId { get; set; }
        public ColorToProduct colorToProduct { get; set; }



        public int Quentity { get; set; }

    }
}
