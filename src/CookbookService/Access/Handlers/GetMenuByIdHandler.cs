using AutoMapper;
using CookbookService.API.Access.Queries;
using CookbookService.API.DTO;
using CookbookService.Domain;
using CookbookService.Infrastrructure.Abstractions;
using MediatR;

namespace CookbookService.API.Access.Handlers
{
	public class GetMenuByIdHandler : IRequestHandler<GetMenuByIdQuery, MenuDTO>
	{
		private readonly IRepository<MenuEntity> _menuRepository;
		private readonly IMapper _mapper;

		public GetMenuByIdHandler(IRepository<MenuEntity> repository, IMapper mapper)
		{
			_menuRepository = repository;
			_mapper = mapper;
		}

		public async Task<MenuDTO> Handle(GetMenuByIdQuery request, CancellationToken cancellationToken)
		{
			var entity = await _menuRepository.GetByIdAsync(request.Id);
			if (entity is null)
			{
				// TODO: Add nlogger
			}

			return _mapper.Map<MenuDTO>(entity);
			
		}
	}
}
