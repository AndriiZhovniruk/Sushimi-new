namespace Sushimi.Models
{
	
    public class CategoryStatsViewModel
    {
        public string Category { get; set; }
        public List<DishStatViewModel> DishStats { get; set; }
    }

    public class DishStatViewModel
    {
        public string DishName { get; set; }
        public int OrderCount { get; set; }
    }
}
