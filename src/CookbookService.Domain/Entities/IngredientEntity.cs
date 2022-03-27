using CookbookService.Domain.Abstractions;

namespace CookbookService.Domain
{
	public class IngredientEntity : BaseEntity
	{
		public string Name { get; }
		public int Amount { get; set; }
		public string Measure { get; set; }
		public int Count { get; set; }
	}
}
