using CookbookService.Domain.Abstractions;

namespace CookbookService.Domain
{
	public class DishEntity : BaseEntity
	{
		public string Name { get; }
		public string Description { get; }
		public List<IngredientEntity> Ingredients { get; }
	}
}
