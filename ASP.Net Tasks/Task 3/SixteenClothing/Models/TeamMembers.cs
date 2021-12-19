using System.ComponentModel.DataAnnotations;

namespace SixteenClothing.Models
{
    public class TeamMembers
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Name { get; set; }




        [MaxLength(50)]
        public string Surname { get; set; }




        [MaxLength(50)]
        public string Img { get; set; }




        [MaxLength(200)]
        public string Text { get; set; }




        public Speciality Speciality { get; set; }
    }
}
