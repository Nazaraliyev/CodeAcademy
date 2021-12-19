using System.ComponentModel.DataAnnotations;

namespace SixteenClothing.Models
{
    public class MemberSosialNetwork
    {
        [Key]
        public int Id { get; set; }



        [MaxLength(50)]
        public string Name { get; set; }




        [MaxLength(50)]
        public string Icon { get; set; }




        [MaxLength(100)]
        public string NLinkame { get; set; }



        public TeamMembers TeamMembers { get; set; }
    }
}
