using Microsoft.AspNetCore.Mvc;
using ProductCatalogMvc.Domain.Interfaces;
using ProductCatalogMvc.WebUI.Models;
using System.Diagnostics;

namespace ProductCatalogMvc.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepository _categoryRepository;
        public HomeController(ILogger<HomeController> logger, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> Index(string active)
        {
            try
            {
                IndexViewModel res = new IndexViewModel()
                {
                    //Result = await _categoryRepository.GetActivetedInjectable(active)
                    Result = await _categoryRepository.GetActivatedUninjectable(active)

                };
                return View(res);

            }
            catch (Exception ex)
            {

                throw;
            }
          

        }


        //public async Task<IActionResult> Index(bool isActive)
        //{
        //    try
        //    {
        //        IndexViewModel res = new IndexViewModel()
        //        {
        //            Result = await _categoryRepository.GetByFilterUninjectable(isActive)

        //        };
        //        return View(res);

        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }


        //}

        public IActionResult Category()
        {
            return View();
        }
  
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}