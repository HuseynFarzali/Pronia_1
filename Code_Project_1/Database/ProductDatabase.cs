using Code_Project_1.Models.DomainModels.Individual;
using Microsoft.VisualBasic;

namespace Code_Project_1.Database
{
    public static class ProductDatabase
    {
        public static List<Product> _productList = new()
        {
            new Product
            {
                Name = "Test_Name_1",
                Description = "Test_Description_1",
                Color = "Test_Color_1",
                Size = "Test_Size_1",
                Value = 120,
                Rating = 5,
                Discount = 15,
                OrderNumber = 7,
                URL = "https://youtube.com",
            },
            new Product
            {
                Name = "Test_Name_2",
                Description = "Test_Description_2",
                Color = "Test_Color_2",
                Size = "Test_Size_2",
                Value = 80,
                Rating = 2,
                Discount = 20,
                OrderNumber = 5,
                URL = "https://youtube.com",
            },
            new Product
            {
                Name = "Test_Name_3",
                Description = "Test_Description_3",
                Color = "Test_Color_3",
                Size = "Test_Size_1",
                Value = 70,
                Rating = 4,
                Discount = 5,
                OrderNumber = 3,
                URL = "https://youtube.com",
            },
            new Product
            {
                Name = "Test_Name_4",
                Description = "Test_Description_4",
                Color = "Test_Color_4",
                Size = "Test_Size_4",
                Value = 50,
                Rating = 3,
                Discount = 25,
                OrderNumber = 2,
                URL = "https://youtube.com",
            },
            new Product
            {
                Name = "Test_Name_5",
                Description = "Test_Description_5",
                Color = "Test_Color_5",
                Size = "Test_Size_5",
                Value = 50,
                Rating = 3,
                Discount = 25,
                OrderNumber = 10,
                URL = "https://youtube.com",
            }
        };
    }
}
