using Microsoft.AspNetCore.Mvc;
using WebAPP_Template.Backend.Application.Models.Responses;

namespace WebAPP_Template.Backend.API.Controllers
{
	public class BaseController : Controller
	{
		protected IActionResult HandleException(Exception ex)
		{
			var errorResponse = new ErrorResponse
			{
				Errors = ex.Message
			};
			return BadRequest(errorResponse);
		}
	}
}
