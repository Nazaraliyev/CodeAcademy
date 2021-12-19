using System.ComponentModel.DataAnnotations;

namespace SixteenClothing.Models
{
    public class Partners
    {
        [Key]
        public int Id { get; set; }




        [MaxLength(50)]
        public string Name { get; set; }



        [MaxLength(200)]
        public string Logo { get; set; }
    }
}
