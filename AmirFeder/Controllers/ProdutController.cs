using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmirFeder.Models;
using AmirFeder.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AmirFeder.Controllers
{
    public class ProductController : Controller
    {
        private IRepository repository;

        public ProductController(IRepository repo) //contrutor
        {
            repository = repo;
        }

        public ViewResult List(string category) => // Generate a view for showing full list of products
            View(new ProductsListViewModel
            {
                Products = repository.Products
                     .Where(p => category == null || p.Category == category)
                     .OrderBy(p => p.ProductID),
                CurrentCategory = category
            });
    }
}