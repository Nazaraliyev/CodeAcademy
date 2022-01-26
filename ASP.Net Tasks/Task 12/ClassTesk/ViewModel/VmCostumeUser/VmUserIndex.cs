using ClassTesk.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ClassTesk.ViewModel.VmCostumeUser
{
    public class VmUserIndex
    {
        public List<CostumeUser> CostumeUsers { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public List<IdentityUserRole<string>> UserRoles { get; set; }
    }
}
