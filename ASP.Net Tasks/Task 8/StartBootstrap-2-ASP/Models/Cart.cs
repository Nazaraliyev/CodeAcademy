using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartBootstrap_2_ASP.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }



        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
