using CookbookService.API.Access.Commands;
using CookbookService.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CookbookService.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class IngredientController : ControllerBase
	{
		public Task<ActionResult<IngredientEntity>> CreateIngredient([FromBody] CreateIngredientCommand request)
		{

		}
	}
}
