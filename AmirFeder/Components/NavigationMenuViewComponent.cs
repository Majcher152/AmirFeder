using AmirFeder.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmirFeder.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IRepository repository;

        public NavigationMenuViewComponent(IRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Products.Select(x => x.Category)
                .Distinct().OrderBy(x => x));
        }
    }
}
