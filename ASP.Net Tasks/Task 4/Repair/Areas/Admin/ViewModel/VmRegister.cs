using System.ComponentModel.DataAnnotations;

namespace Repair.Areas.Admin.ViewModel
{
    public class VmRegister
    {
        [MaxLength(50)]
        public string Name { get; set; }


        [MaxLength(50)]
        public string Surname { get; set; }


        [MaxLength(500)]
        public string Address { get; set; }


        [MaxLength(15)]
        public string Phone { get; set; }



        [MaxLength(50)]
        public string Mail  { get; set; }



        [MaxLength(30), MinLength(8)]
        public string Password { get; set; } 
    }
}
