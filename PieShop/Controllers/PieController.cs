using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        // GET: /<controller>/

        private readonly IPieRepo _pieRepo;
        private readonly ICategoryRepo _categoryRepo;

        public PieController(IPieRepo pieRepo, ICategoryRepo categoryRepo)
        {
            _pieRepo = pieRepo;
            _categoryRepo = categoryRepo;
        }

        //public ViewResult List()
        //{
        //    PiesListViewModel piesListViewModel = new PiesListViewModel();
        //    piesListViewModel.Pies = _pieRepo.AllPies;
        //    piesListViewModel.CurrentCat = "Cheese Cakes";
        //    return View(piesListViewModel);
        //}

        //==========================================
        public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;

            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepo.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All pies";
            }
            else
            {

                pies = _pieRepo.AllPies.Where(p => p.Category.CatName == category)
                .OrderBy(p => p.PieId);
                currentCategory = _categoryRepo.AllCat.FirstOrDefault(c => c.CatName == category)?.CatName;
            }

            return View(new PiesListViewModel
            {
                Pies = pies,
                CurrentCat = currentCategory
            });
        }


        public IActionResult Details (int id)
        {
            var pie = _pieRepo.GetPieById(id);
            if(pie==null)
                return NotFound();
            return View(pie);
        }
       
        
    }
}
