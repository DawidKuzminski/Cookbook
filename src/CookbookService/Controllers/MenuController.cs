using CookbookService.API.Access.Commands;
using CookbookService.API.Access.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CookbookService.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class MenuController : ControllerBase
	{
		private readonly IMediator _mediator;
		public MenuController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public ActionResult Create([FromBody] AddMenuCommand request)
		{
			return Ok(_mediator.Send(request));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById([FromRoute] int id)
		{
			return Ok(await _mediator.Send(new GetMenuByIdQuery { Id = id }));
		}
	}
}
