using Microsoft.IdentityModel.Tokens;
using Rex.RIMS.EvriAPI.Models;
using Rex.RIMS.EvriAPI.Services.IService;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Rex.RIMS.EvriAPI.Services.Service
{
	public class AuthService : IAuthService
	{
		private readonly IConfiguration config;

		public AuthService(IConfiguration config)
		{
			this.config = config;
		}

		public string GetAuthorizeToken(UserModel model)
		{
			string tokenString = string.Empty;
			if (model.UserName == config["JwtSecurityToken:UserName"] && model.Password == config["JwtSecurityToken:Password"])
			{
				var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JwtSecurityToken:SigningCredentials"]));

				var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
				var claims = new[]
				{
					new Claim(ClaimTypes.NameIdentifier,config["JwtSecurityToken:NameIdentifier"])
				};

				var token = new JwtSecurityToken(config["JwtSecurityToken:Issuer"],
				  config["JwtSecurityToken:Audience"],
				  claims,
				  expires: DateTime.Now.AddHours(1),
				  signingCredentials: credentials);


				tokenString = new JwtSecurityTokenHandler().WriteToken(token);
			}
			return tokenString;
		}
	}
}
