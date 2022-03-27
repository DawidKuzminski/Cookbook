using CookbookService.Domain.Abstractions;

namespace CookbookService.Domain
{
	public class MenuEntity : BaseEntity
	{
		public string Name { get; }
		public string Description { get; }
		public string Owner { get; }
		public List<DayEntity> Days { get; }
	}
}
