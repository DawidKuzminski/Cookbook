using CookbookService.API.Access.Commands;
using Microsoft.AspNetCore.Mvc;

namespace CookbookService.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class MenuController : ControllerBase
	{
		[HttpPost]
		public ActionResult Create([FromBody] AddMenuCommand request)
		{
			var xxxx = request;

			return NoContent();
		}
	}
}
