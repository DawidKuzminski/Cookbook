using CookbookService.Domain;

namespace CookbookService.API.DTO
{
	public record MealDTO
	{
		public MealType Type { get; init; }
		public List<DishDTO> Dishes { get; init; }
	}
}
