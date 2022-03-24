namespace CookbookService.Domain
{
	public class Menu
	{
		public string Name { get; }
		public string Description { get; }
		public string Owner { get; }
		public List<Day> Days { get; }
	}
}
