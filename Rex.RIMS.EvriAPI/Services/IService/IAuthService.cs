using Rex.RIMS.EvriAPI.Models;

namespace Rex.RIMS.EvriAPI.Services.IService
{
	public interface IAuthService : IScoppedService
	{
		string GetAuthorizeToken(UserModel model);
	}
}
