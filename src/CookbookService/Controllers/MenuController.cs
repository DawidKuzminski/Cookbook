using CookbookService.API.Access.Commands;
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
			_mediator.Send(request);

			return NoContent();
		}
	}
}
