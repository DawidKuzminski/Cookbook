using CookbookService.Domain.Abstractions;

namespace CookbookService.Domain
{
	public class IngredientEntity : BaseEntity
	{
		public string Name { get; init; }
		public int Amount { get; init; }
		public string Measure { get; init; }
		public int Count { get; init; }
	}
}
