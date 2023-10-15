using Code_Project_1.Models.DomainModels.Common;
using Code_Project_1.Models.ViewModels;
using System.Drawing;

namespace Code_Project_1.Models.DomainModels.Individual
{
    public class Product : BaseEntity
    {
        private decimal _value;
        private int _rating;
        private int _discount;
        private int _orderNumber;

        public DateTime CreatedDate = DateTime.Now;
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Value
        {
            get
            {
                return _value;
            }

            set
            {
                if (value < 0 || value > Decimal.MaxValue)
                {
                    throw new ArgumentException("Value property of a product should be within the logical range of decimal.");
                }

                _value = value;
            }
        }
        public int Rating
        {
            get
            {
                return _rating;
            }

            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Product rating cannot be less than 0 of greater than 5.");
                }

                _rating = value;
            }
        }
        public int Discount
        {
            get
            {
                return _discount;
            }
            
            set
            {
                if (value > 100)
                {
                    throw new ArgumentException("Discount property of a product cannot be more than 100.");
                }

                _discount = value;
            }
        }
        public int OrderNumber
        {
            get
            {
                return _orderNumber;
            }
            set
            {
                _orderNumber = value;
            }
        }

        public Product() { }

        public Product(string name, string description, string color, string size, decimal value, int rating, int discount, int orderNumber)
        {
            Name = name;
            Description = description;
            Color = color;
            Size = size;
            Value = value;
            Rating = rating;
            Discount = discount;
            OrderNumber = orderNumber;
        }

        public void PutDataFromDetailViewModel(ProductDetailViewModel model)
        {
            Name = model.Name;
            Description = model.Description;
            Color = model.Color;
            Discount = model.Discount;
            OrderNumber = model.OrderNumber;
            Rating = model.Rating;
            Size = model.Size;
            Value = model.Value;
            URL = model.URL;
        }
    }
}
