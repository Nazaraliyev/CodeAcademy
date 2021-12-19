using System.ComponentModel.DataAnnotations;

namespace SixteenClothing.Models
{
    public class HomeBanners
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string SubHeader { get; set; }




        [MaxLength(50)]
        public string Header { get; set; }



        [MaxLength(50)]
        public string Img { get; set; }
    }
}
