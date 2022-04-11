namespace CookbookService.API.DTO
{
	public record DishDTO
	{
		public string Name { get; init; }
		public string Description { get; init; }
		public List<IngredientDTO> Ingredients { get; init; }
	}
}
