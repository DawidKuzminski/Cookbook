namespace CookbookService.Domain
{
	public class Day
	{
		public int Id { get; }
		public DayOfWeek DayOfWeek { get; }
		public List<Meal> Meals { get; }
	}
}
