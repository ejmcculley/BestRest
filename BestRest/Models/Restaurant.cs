namespace BestRest.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Description { get; set; }
    public int Ratings { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}