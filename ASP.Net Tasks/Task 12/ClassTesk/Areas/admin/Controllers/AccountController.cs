using ClassTesk.Data;
using ClassTesk.ViewModel.VmCostumeUser;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTesk.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(AppDbContext context, 
                                 UserManager<IdentityUser> userManager, 
                                 SignInManager<IdentityUser> signInManager, 
                                 IWebHostEnvironment webHostEnvironment, 
                                 RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
            _roleManager = roleManager;
        }



        public async Task<IActionResult> Index()
        {
            VmUserIndex model = new VmUserIndex()
            {
                CostumeUsers = await _context.costumeUsers.ToListAsync(),
                Roles = await _context.Roles.ToListAsync(),
                UserRoles = await _context.UserRoles.ToListAsync()
            };
            return View(model);
        }
    }
}
