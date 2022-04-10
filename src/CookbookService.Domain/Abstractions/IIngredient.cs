namespace CookbookService.Domain.Abstractions
{
	public interface IIngredient
	{
		string Name { get; set; }
		int Amount { get; set; }
		string Measure { get; set; }
		int Count { get; set; }
	}
}
