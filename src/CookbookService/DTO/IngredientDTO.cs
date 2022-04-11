namespace CookbookService.API.DTO
{
	public record IngredientDTO
	{
		public string? Name { get; init; }
		public int Amount { get; init; }
		public string? Measure { get; init; }
		public int Count { get; init; }
	}
}
