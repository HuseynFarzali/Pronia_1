namespace Code_Project_1.Models.ViewModels
{
    public class ProductBaseViewModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }

        public ProductBaseViewModel() { }

        public ProductBaseViewModel(string name, decimal value, int rating, DateTime createdDate)
        {
            Name = name;
            Value = value;
            Rating = rating;
            CreatedDate = createdDate;
        }
    }
}
