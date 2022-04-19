using AutoMapper;
using CookbookService.API.Access.Commands;
using CookbookService.Domain;
using CookbookService.Infrastrructure.Abstractions;
using MediatR;

namespace CookbookService.API.Access.Handlers
{
	public class AddMenuCommandHandler : IRequestHandler<AddMenuCommand>
	{
		private readonly IRepository<MenuEntity> _menuRepository;
		private readonly IMapper _mapper;

		public AddMenuCommandHandler(IRepository<MenuEntity> repository, IMapper mapper)
		{
			_menuRepository = repository;
			_mapper = mapper;
		}

		public Task<Unit> Handle(AddMenuCommand request, CancellationToken cancellationToken)
		{
			var entity = _mapper.Map<MenuEntity>(request);
			_menuRepository.Add(entity);

			return Unit.Task;
		}
	}
}
