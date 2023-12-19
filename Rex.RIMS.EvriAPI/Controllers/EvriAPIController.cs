using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rex.RIMS.EvriAPI.Models;
using Rex.RIMS.EvriAPI.Services.IService;

namespace Rex.RIMS.EvriAPI.Controllers
{
	[Authorize]
	[ApiController]
	[Route("[controller]")]
	//[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
	public class EvriAPIController : ControllerBase
	{
		private readonly ILogger<EvriAPIController> _logger;
		private readonly IEvriService _evriService;

		public EvriAPIController(ILogger<EvriAPIController> logger, IEvriService evriService)
		{
			_logger = logger;
			_evriService = evriService;
		}

		[HttpGet]
		//importedOrderID = 1231254
		public async Task<ResultModel> GetImportedOrderById(int importedOrderID)
		{
			_logger.LogInformation("GetImportedOrderById API Calling!");
			ResultModel model = new ResultModel();
			try
			{
				if (importedOrderID > 0)
				{
					model.Success = true;
					model.Result = await _evriService.GetImportedOrder(importedOrderID);
				}
				else
				{
					model.Message = "Please enter imported order id!";
				}
			}
			catch (Exception ex)
			{
				model.Message = ex.Message;
				_logger.LogError($"GetImportedOrderById API :- {ex.Message}", ex);
			}
			return model;
		}
	}
}
