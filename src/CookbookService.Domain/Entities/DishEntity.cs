using CookbookService.Domain.Abstractions;

namespace CookbookService.Domain
{
	public class DishEntity : BaseEntity
	{
		public string Name { get; init; }
		public string Description { get; init; }
		public List<IngredientEntity> Ingredients { get; init; }
	}
}
