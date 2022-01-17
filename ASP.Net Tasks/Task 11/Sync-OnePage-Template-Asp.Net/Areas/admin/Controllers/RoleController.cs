using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sync_OnePage_Template_Asp.Net.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Sync_OnePage_Template_Asp.Net.Areas.admin.Controllers
{
    [Area("admin")]
    public class RoleController : Controller
    {
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleController(AppDbContext context, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }


        public IActionResult Index()
        {
            return View(_roleManager.Roles.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole model)
        {
            if (model.Name != null)
            {
                if (!await _roleManager.RoleExistsAsync(model.Name))
                {
                    await _roleManager.CreateAsync(model);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("", "This Role exist in Roles List");
                    return View(model);
                }

            }
            else
            {
                ModelState.AddModelError("", "Role Name is required");
                return View(model);
            }
        }



        
        public async Task<IActionResult> Update(string Id)
        {
            if (Id != null)
            {
                if (await _roleManager.FindByIdAsync(Id) != null)
                {
                    //IdentityRole role = await _roleManager.FindByIdAsync(Id);
                    return View(await _roleManager.FindByIdAsync(Id));
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(IdentityRole model)
        {
            if (model.Name != null)
            {
                if(_context.Roles.Any(r => r.Name == model.Name))
                {
                    if(_context.Roles.FirstOrDefault(r => r.Name == model.Name).Id == model.Id)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError("", "This Role exist in Roles List");
                        return View(model);
                    }
                }
                else
                {
                    await _roleManager.UpdateAsync(model);
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                ModelState.AddModelError("", "Role Name is required");
                return View(model);
            }
        }



        public async Task<IActionResult> Delete(string Id)
        {
            if (Id != null)
            {
                if (await _roleManager.FindByIdAsync(Id) != null)
                {
                    await _roleManager.DeleteAsync(await _roleManager.FindByIdAsync(Id));
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
