using System.ComponentModel.DataAnnotations;

namespace Biziness.View_Model
{
    public class VmUserUpdate
    {
        [MaxLength(50), Required]
        public string Name { get; set; }



        [MaxLength(50), Required]
        public string Surname { get; set; }


        [MaxLength(100), Required, EmailAddress]
        public string Email { get; set; }


        [MaxLength(15), Required, Phone]
        public string Phone { get; set; }


		public string Id { get; set; }
	}
}
