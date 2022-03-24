namespace CookbookService.Domain
{
	public class Ingredient
	{
		public int Id { get; }
		public string Name { get; }
		public decimal Amount { get; set; }
		public string Measure { get; set; }
		public decimal Count { get; set; }
	}
}
