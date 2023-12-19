using Rex.RIMS.EvriAPI.DTO;

namespace Rex.RIMS.EvriAPI.Services.IService
{
	public interface IEvriService : IScoppedService
	{
		Task<ImportedOrder> GetImportedOrder(int importedOrderID);
	}
}
