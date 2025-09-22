namespace ElectroMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Slides> Slides { get; set; }
    }
}
