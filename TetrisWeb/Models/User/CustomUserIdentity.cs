using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TetrisWeb.Models.User
{
	public class CustomUserIdentity : ClaimsIdentity
	{
		public int Id { get; set; }

		public CustomUserIdentity(Entities.User user, string authenticationType = "Cookie") : base(GetUserClaims(user), authenticationType)
		{
			Id = user.Id;
		}

		private static List<Claim> GetUserClaims(Entities.User user)
		{
			var result = new List<Claim>
			{
				new Claim(ClaimTypes.Name, user.Login),
				new Claim(ClaimTypes.Role, "Admin"),
			};

			return result;
		}
	}
}
