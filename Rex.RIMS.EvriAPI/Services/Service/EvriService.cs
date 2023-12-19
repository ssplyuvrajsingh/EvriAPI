using Microsoft.EntityFrameworkCore;
using Rex.RIMS.EvriAPI.DTO;
using Rex.RIMS.EvriAPI.Services.IService;

namespace Rex.RIMS.EvriAPI.Services.Service
{
	public class EvriService : IEvriService
	{
		private readonly RexRimsContext _dbContext;
		public EvriService(IConfiguration config) 
		{ 
			_dbContext = new RexRimsContext(config);
		}
		public async Task<ImportedOrder> GetImportedOrder(int importedOrderID)
		{
			return await _dbContext?.ImportedOrders?.AsNoTracking()?.FirstOrDefaultAsync(x=>x.ImportedOrderId == importedOrderID);
		}
	}
}
