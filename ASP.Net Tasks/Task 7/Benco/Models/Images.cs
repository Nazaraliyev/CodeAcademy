using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Benco.Models
{
    public class Images
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(200)]
        public string Mame { get; set; }


        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
