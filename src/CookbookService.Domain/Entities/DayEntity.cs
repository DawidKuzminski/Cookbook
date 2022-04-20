using CookbookService.Domain.Abstractions;

namespace CookbookService.Domain
{
	public class DayEntity : BaseEntity
	{
		public DayOfWeek DayOfWeek { get; init; }
		public List<MealEntity> Meals { get; init; }
	}
}
