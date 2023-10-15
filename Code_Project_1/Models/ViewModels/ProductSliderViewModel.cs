namespace Code_Project_1.Models.ViewModels
{
    public class ProductSliderViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Offer { get; set; }
        public int OrderNumber { get; set; }
        public string URL { get; set; }

        public ProductSliderViewModel() { }

        public ProductSliderViewModel(string title, string description, int offer, int orderNumber, string url)
        {
            Title = title;
            Description = description;
            Offer = offer;
            OrderNumber = orderNumber;
            URL = url;
        }
    }
}
