using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SixteenClothing.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Logo { get; set; }




        [Column(TypeName = "ntext")]
        public string HomeContent { get; set; }




        [MaxLength(50)]
        public string HomeContentImg { get; set; }




        [MaxLength(50)]
        public string OurProductSubHeader { get; set; }



        [MaxLength(50)]
        public string OurProductHeader { get; set; }



        [MaxLength(50)]
        public string OurProductImg { get; set; }




        [MaxLength(50)]
        public string AboutUsSubHeader { get; set; }



        [MaxLength(50)]
        public string AboutUsHeader { get; set; }



        [MaxLength(50)]
        public string AboutUsImg { get; set; }



        [MaxLength(50)]
        public string AboutUsContent { get; set; }




        [MaxLength(50)]
        public string AboutUsContentImg { get; set; }



        [MaxLength(50)]
        public string ContactUsSubHeader { get; set; }



        [MaxLength(50)]
        public string ContactUsHeader { get; set; }



        [MaxLength(50)]
        public string ContactUsImg { get; set; }



        [MaxLength(50)]
        public string ContactUsContent { get; set; }




        [MaxLength(50)]
        public string ContactUsLocation { get; set; }
    }
}
