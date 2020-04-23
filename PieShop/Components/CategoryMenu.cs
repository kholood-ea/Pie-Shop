using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Components
{
    public class CategoryMenu: ViewComponent
    {
        private readonly ICategoryRepo _categoryRepository;
        public CategoryMenu(ICategoryRepo categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCat.OrderBy(c => c.CatName);
            return View(categories);
        }
    }
}
