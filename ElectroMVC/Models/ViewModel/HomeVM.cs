namespace ElectroMVC.Models.ViewModel
{
    public class HomeVM
    {
        public List<Slides> Slides { get; set; }
        public List< Product> Product { get; set; }
        public List< BestSellerProducts> BestSellerProducts { get; set; }   
        public List<BestSellerProductToTag>? BestSellerProductToTag { get; set; }
        
    }
}
