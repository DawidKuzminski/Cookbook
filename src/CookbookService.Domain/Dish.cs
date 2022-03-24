namespace CookbookService.Domain
{
	public class Dish
	{
		public int Id { get; }
		public string Name { get; }
		public string Description { get; }
		public List<Ingredient> Ingredients { get; }
	}
}
