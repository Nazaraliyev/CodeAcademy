using ClassTesk.Data;
using ClassTesk.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTesk.ViewComponents
{
    public class Footer : ViewComponent
    {
        private readonly AppDbContext _context;

        public Footer(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {


            VmSetting model = new VmSetting()
            {
                settings = _context.settings.FirstOrDefault(),
                socialMedia = _context.socialMedias.ToList()
            };
            return View(model);
        }
    }
}
