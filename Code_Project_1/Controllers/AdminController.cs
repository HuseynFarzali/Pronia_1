using Code_Project_1.Database;
using Code_Project_1.Models.DomainModels.Individual;
using Code_Project_1.Models.ViewModels;
using Code_Project_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Code_Project_1.Controllers
{
    [Route("admin/")]
    public class AdminController : Controller
    {
        [HttpGet("", Name = "admin-product-list-redirecter")]
        public IActionResult Redirecter() 
        {
            return RedirectToRoute("admin-product-list-page");
        }

        [HttpGet("productlist", Name = "admin-product-list-page")]
        public IActionResult ProductList()
        {
            var products = ProductDatabase._productList;
            var productDetailViewModelList = ProductService.CreateDetailViewModelList(products);

            return View(productDetailViewModelList);
        }

        [HttpGet("productadd", Name = "admin-product-add-page")]
        public IActionResult ProductAdd()
        {
            return View();
        }

        [HttpPost("productaddsubmit", Name = "admin-product-add-redirecter")]
        public IActionResult ProductAddSubmit(ProductDetailViewModel detailViewModel)
        {
            var newProduct = new Product();
            newProduct.PutDataFromDetailViewModel(detailViewModel);

            ProductDatabase._productList.Add(newProduct);

            return RedirectToRoute("admin-product-list-page");
        }

        [HttpGet("productedit/{id?}", Name = "admin-product-edit-page")]
        public IActionResult ProductEdit(int id)
        {
            var product = ProductDatabase._productList.FirstOrDefault(p => p.ID == id) ?? throw new ArgumentException("No any product found by the given ID.");
            var productDetailViewModel = ProductService.CreateDetailViewModel(product);

            return View(productDetailViewModel);
        }

        [HttpPost("producteditsubmit/{id?}", Name = "admin-product-edit-redirecter")]
        public IActionResult ProductEditSubmit(ProductDetailViewModel detailViewModel)
        {
            var product = ProductDatabase._productList.FirstOrDefault(p => p.ID == detailViewModel.ID) ?? throw new ArgumentException("No any product found by the given ID.");

            product.PutDataFromDetailViewModel(detailViewModel);

            return RedirectToRoute("admin-product-list-page");
        }

        [HttpGet("productdelete/{id?}", Name = "admin-product-delete-redirecter")]
        public IActionResult ProductDelete(int id)
        {
            var product = ProductDatabase._productList.FirstOrDefault(p => p.ID == id) ?? throw new ArgumentException("No any product found by the given ID.");
            ProductDatabase._productList.Remove(product);

            return RedirectToRoute("admin-product-list-page");
        }
    }
}
