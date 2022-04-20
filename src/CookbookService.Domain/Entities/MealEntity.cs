using CookbookService.Domain.Abstractions;

namespace CookbookService.Domain
{
	public class MealEntity : BaseEntity
	{
		public MealType Type { get; init; }
		public List<DishEntity> Dishes { get; init; }
	}
}
