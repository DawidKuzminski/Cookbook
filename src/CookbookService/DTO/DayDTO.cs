namespace CookbookService.API.DTO
{
	public record DayDTO
	{
		public DayOfWeek DayOfWeek { get; init; }
		public List<MealDTO> Meals { get; init; }
	}
}
