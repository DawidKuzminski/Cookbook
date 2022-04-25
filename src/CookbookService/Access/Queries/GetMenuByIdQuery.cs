using CookbookService.API.DTO;
using MediatR;

namespace CookbookService.API.Access.Queries
{
	public class GetMenuByIdQuery : IRequest<MenuDTO>
	{
		public int Id { get; init; }
	}
}
