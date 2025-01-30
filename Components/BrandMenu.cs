using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EzeCarVentures.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Components
{
    public class BrandMenu : ViewComponent
    {
        private readonly IBrand _brandRepo;
        public BrandMenu(IBrand brandRepo)
        {
            _brandRepo = brandRepo;
        }

        public IViewComponentResult Invoke()
        {
            var brands = _brandRepo.AllBrand.OrderBy(c => c.BrandName);
            return View(brands);
        }
    }
}
