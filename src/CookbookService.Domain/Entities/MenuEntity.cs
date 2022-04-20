using CookbookService.Domain.Abstractions;

namespace CookbookService.Domain
{
	public class MenuEntity : BaseEntity
	{
		public string Name { get; init; }
		public string Description { get; init; }
		public string Owner { get; init; }
		public List<DayEntity> Days { get; init; }
	}
}
