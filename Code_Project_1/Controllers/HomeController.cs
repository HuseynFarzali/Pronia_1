using Code_Project_1.Database;
using Code_Project_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Code_Project_1.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet("", Name = "home-index-page-redirecter")]
        public IActionResult Redirecter()
        {
            return RedirectToRoute("home-index-page");
        }

        [HttpGet("index", Name = "home-index-page")]
        public IActionResult Index()
        {
            var products = ProductDatabase._productList;
            
            // SliderViewModel List 
            var productSliderViewModelList = ProductService.CreateSliderViewModelList(products);
            var productSliderViewModelOrderedList = productSliderViewModelList
                .OrderBy(model => model.OrderNumber)
                .ToList();

            // BaseViewModel List
            var productBaseViewModelList = ProductService.CreateBaseViewModelList(products);
            var productBaseViewModelOrderedList = productBaseViewModelList
                .OrderByDescending(model => model.CreatedDate)
                .ToList();

            // DetailViewModel List
            var productDetailViewModelList = ProductService.CreateDetailViewModelList(products);

            return View((productSliderViewModelOrderedList, productBaseViewModelOrderedList));
        }
    }
}
