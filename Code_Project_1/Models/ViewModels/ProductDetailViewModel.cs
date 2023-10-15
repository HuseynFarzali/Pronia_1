namespace Code_Project_1.Models.ViewModels
{
    public class ProductDetailViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Value { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Discount { get; set; }
        public int OrderNumber { get; set; }

        public ProductDetailViewModel() { }

        public ProductDetailViewModel(int iD, string name, string description, string uRL, string color, string size, decimal value, int rating, DateTime createdDate, int discount, int orderNumber)
        {
            ID = iD;
            Name = name;
            Description = description;
            URL = uRL;
            Color = color;
            Size = size;
            Value = value;
            Rating = rating;
            CreatedDate = createdDate;
            Discount = discount;
            OrderNumber = orderNumber;
        }
    }
}
