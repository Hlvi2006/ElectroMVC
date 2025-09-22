namespace ElectroMVC.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BestSellerProductToTag> BestSellerProductsToTags { get; set; }

    }
}
