namespace ElectroMVC.Models
{
    public class BestSellerProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<BestSellerProductToTag> BestSellerProductsToTags { get; set; }
    }
}
