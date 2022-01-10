using System.ComponentModel.DataAnnotations;

namespace StartBootstrap_2_ASP.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Logo { get; set; }



        [MaxLength(20)]
        public string BannerHeader { get; set; }




        [MaxLength(100)]
        public string BannerText { get; set; }

    }

}
