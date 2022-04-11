using CookbookService.API.DTO;

namespace CookbookService.API.Access.Commands
{
	public record AddMenuCommand
	{
		public string Name { get; init; }
		public string Description { get; init; }
		public string Owner { get; init; }
		public List<DayDTO> Days { get; init; }
	}
}
