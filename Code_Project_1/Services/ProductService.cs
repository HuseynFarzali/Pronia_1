using Code_Project_1.Models.DomainModels.Individual;
using Code_Project_1.Models.ViewModels;

namespace Code_Project_1.Services
{
    public static class ProductService
    {
        // BaseViewModel Generation from Product
        public static ProductBaseViewModel CreateBaseViewModel(Product product)
        {
            var baseViewModel = new ProductBaseViewModel()
            {
                Name = product.Name,
                Value = product.Value,
                Rating = product.Rating,
                CreatedDate = product.CreatedDate,
            };

            return baseViewModel;
        }

        public static List<ProductBaseViewModel> CreateBaseViewModelList(List<Product> products)
        {
            var baseViewModelList = new List<ProductBaseViewModel>();

            foreach (var product in products)
            {
                baseViewModelList.Add(CreateBaseViewModel(product));
            }

            return baseViewModelList;
        }

        // DetailViewModel Generation from Product
        public static ProductDetailViewModel CreateDetailViewModel(Product product)
        {
            var detailViewModel = new ProductDetailViewModel()
            {
                ID = product.ID,
                Name = product.Name,
                Description = product.Description,
                URL = product.URL,
                Color = product.Color,
                Size = product.Size,
                Value = product.Value,
                Rating = product.Rating,
                CreatedDate = product.CreatedDate,
                Discount = product.Discount,
                OrderNumber = product.OrderNumber,
            };

            return detailViewModel;
        }

        public static List<ProductDetailViewModel> CreateDetailViewModelList(List<Product> products)
        {
            var detailViewModelList = new List<ProductDetailViewModel>();

            foreach (var product in products)
            {
                detailViewModelList.Add(CreateDetailViewModel(product));
            }

            return detailViewModelList;
        }

        // SliderViewModel Generation from Product
        public static ProductSliderViewModel CreateSliderViewModel(Product product)
        {
            var sliderViewModel = new ProductSliderViewModel()
            {
                Title = product.Name,
                Description = product.Description,
                Offer = product.Discount,
                OrderNumber = product.OrderNumber,
                URL = product.URL,
            };

            return sliderViewModel;
        }

        public static List<ProductSliderViewModel> CreateSliderViewModelList(List<Product> products)
        {
            var sliderViewModelList = new List<ProductSliderViewModel>();

            foreach (var product in products)
            {
                sliderViewModelList.Add(CreateSliderViewModel(product));
            }

            return sliderViewModelList;
        }

        // AdminViewModel Generation from Product
        public static ProductAdminViewModel CreateAdminViewModel(Product product)
        {
            var adminViewModel = new ProductAdminViewModel()
            {
                Id = product.ID,
                Name = product.Name,
                Description = product.Description,
                Color = product.Color,
                Size = product.Size,
                Value = product.Value,
                Rating = product.Rating,
            };

            return adminViewModel;
        }

        public static List<ProductAdminViewModel> CreateAdminViewModelList(List<Product> products)
        {
            var adminViewModelList = new List<ProductAdminViewModel>();

            foreach (var product in products)
            {
                adminViewModelList.Add(CreateAdminViewModel(product));
            }

            return adminViewModelList;
        }
    }
}
