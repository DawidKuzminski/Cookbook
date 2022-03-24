namespace CookbookService.Domain
{
	public class Meal
	{
		public int Id { get; }
		public MealType Type { get; }
		public List<Dish> Dishes { get; }
	}
}
