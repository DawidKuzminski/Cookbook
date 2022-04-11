namespace CookbookService.API.DTO
{
	public record MenuDTO
	{
		public string Name { get; init; }
		public string Description { get; init; }
		public string Owner { get; init; }
		public List<DayDTO> Days { get; init; }
	}
}
