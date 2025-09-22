namespace ElectroMVC.Models
{
    public class BestSellerProductToTag
    {
        public int Id { get; set; }
        public int BestSellerProductId { get; set; }
        public BestSellerProducts BestSellerProduct { get; set; }
        public int TagId { get; set; }
        public Tags Tag { get; set; }
    }
}
