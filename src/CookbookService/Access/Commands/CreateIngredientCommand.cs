using CookbookService.Domain.Abstractions;

namespace CookbookService.API.Access.Commands
{
	public class CreateIngredientCommand : IIngredient
	{
		public string Name { get; set; }
		public int Amount { get; set; }
		public string Measure { get; set; }
		public int Count { get; set; }
	}
}
