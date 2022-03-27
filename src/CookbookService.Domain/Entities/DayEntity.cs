using CookbookService.Domain.Abstractions;

namespace CookbookService.Domain
{
	public class DayEntity : BaseEntity
	{
		public DayOfWeek DayOfWeek { get; }
		public List<MealEntity> Meals { get; }
	}
}
