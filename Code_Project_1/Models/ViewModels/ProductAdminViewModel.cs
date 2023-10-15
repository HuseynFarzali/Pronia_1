namespace Code_Project_1.Models.ViewModels
{
    public class ProductAdminViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Value { get; set; }
        public int Rating { get; set; }

        public ProductAdminViewModel() { }

        public ProductAdminViewModel(int id, string name, string description, string color, string size, decimal value, int rating)
        {
            Id = id;
            Name = name;
            Description = description;
            Color = color;
            Size = size;
            Value = value;
            Rating = rating;
        }
    }
}
