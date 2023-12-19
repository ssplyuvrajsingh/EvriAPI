using System.ComponentModel.DataAnnotations;

namespace Rex.RIMS.EvriAPI.Models
{
	public class UserModel
	{
		[Required]
		public string? UserName { get; set; }
		[Required]
		public string? Password { get; set; }
	}
}
