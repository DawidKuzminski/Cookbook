using CookbookService.API.Access.Commands;
using CookbookService.Domain;
using CookbookService.Infrastrructure.Abstractions;
using MediatR;

namespace CookbookService.API.Access.Handlers
{
	public class AddMenuCommandHandler : IRequestHandler<AddMenuCommand>
	{
		private readonly IRepository<MenuEntity> _menuRepository;
		public AddMenuCommandHandler(IRepository<MenuEntity> repository)
		{
			_menuRepository = repository;
		}

		public Task<Unit> Handle(AddMenuCommand request, CancellationToken cancellationToken)
		{

			_menuRepository.Add(new MenuEntity{ Name = "Test" });

			return Unit.Task;
		}
	}
}
