using System.ComponentModel.DataAnnotations;

namespace Repair.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Logo { get; set; }



        [MaxLength(15)]
        public string Phone { get; set; }



        [MaxLength(50)]
        public string Mail { get; set; }



        [MaxLength(200)]
        public string Address { get; set; }



        [MaxLength(100)]
        public string Street { get; set; }



        [MaxLength(100)]
        public string OpenTime { get; set; }



        [MaxLength(200)]
        public string Location { get; set; }



        [MaxLength(200)]
        public string FooterDescription { get; set; }



        [MaxLength(200)]
        public string HomeSubHeader { get; set; }



        [MaxLength(200)]
        public string HomeHeader { get; set; }



        [MaxLength(1000)]
        public string HomeDescription { get; set; }



        [MaxLength(50)]
        public string HomeImage { get; set; }



        [MaxLength(50)]
        public string HomeBackgroundImage { get; set; }
    }
}
