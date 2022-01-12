using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.Areas.admin.Controllers
{
	[Area("admin")]
	public class RollController : Controller
	{
		private readonly AppDbContext _context;
		private readonly RoleManager<IdentityRole> _roleManager;

		public RollController(AppDbContext context, RoleManager<IdentityRole> roleManager)
		{
			_context = context;
			_roleManager = roleManager;
		}




		public ActionResult Index()
		{
			return View(_context.Roles.ToList());
		}




		// GET: RollController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: RollController/Create
		[HttpPost]
		public async Task<ActionResult> Create(IdentityRole model)
		{
			if (ModelState.IsValid)
			{
				if(!_context.Roles.Any(r => r.Name == model.Name))
				{
					try
					{
						await _roleManager.CreateAsync(model);
						return RedirectToAction("Index");

					}
					catch
					{
						return View(model);
					}
				}
				else
				{
					ModelState.AddModelError("", "This role is exist");
					return View(model);
				}
			}
			else
			{
				return View(model);
			}
		}

		// GET: RollController/Edit/5
		public async Task<ActionResult> Update(string Id)
		{
			if(Id != null)
			{
				if(_roleManager.Roles.Any(r => r.Id == Id))
				{
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
		public async Task<ActionResult> Update(IdentityRole model)
		{
			if (ModelState.IsValid)
			{
				await _roleManager.UpdateAsync(model);
				return RedirectToAction("Index");
			}
			else
			{
				return View(model);
			}
		}

		public async Task<ActionResult> Delete(string Id)
		{
			if (Id != null)
			{
				if (_roleManager.Roles.Any(r => r.Id == Id))
				{
					try
					{
						await _roleManager.DeleteAsync(await _roleManager.FindByIdAsync(Id));
						return RedirectToAction(nameof(Index));
					}
					catch
					{
						return RedirectToAction("Index");
					}

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
