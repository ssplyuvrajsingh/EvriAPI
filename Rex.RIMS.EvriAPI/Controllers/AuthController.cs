using Microsoft.AspNetCore.Mvc;
using Rex.RIMS.EvriAPI.Models;
using Rex.RIMS.EvriAPI.Services.IService;

namespace Rex.RIMS.EvriAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AuthController : ControllerBase
	{
		private readonly ILogger<AuthController> logger;
		private readonly IAuthService authService;
		public AuthController(ILogger<AuthController> logger, IAuthService authService)
		{
			this.logger = logger;
			this.authService = authService;
		}

		[HttpPost] //Route("authorize")]
		public IActionResult Authorize(UserModel model)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return BadRequest("Invalid client request");
				}

				string token = authService.GetAuthorizeToken(model);
				if (!string.IsNullOrWhiteSpace(token))
				{
					return Ok(new { Token = token });
				}

				return Unauthorized();
			}
			catch (Exception ex)
			{
				logger.LogError($"Authorize API : {ex.Message}", ex);
				return BadRequest(new { Message = ex.Message });
			}
		}
	}
}
