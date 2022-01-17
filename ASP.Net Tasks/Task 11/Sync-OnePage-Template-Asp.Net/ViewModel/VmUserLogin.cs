using System.ComponentModel.DataAnnotations;

namespace Sync_OnePage_Template_Asp.Net.ViewModel
{
    public class VmUserLogin
    {
        [MaxLength(100), Required]
        public string UserName { get; set; }

        [MaxLength(100),MinLength(5), Required]
        public string Password { get; set; }
    }
}
