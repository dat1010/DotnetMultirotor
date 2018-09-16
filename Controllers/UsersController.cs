using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DotnetMultirotor;
using System.Threading.Tasks;
using DotnetMultirotor.Persistence;

namespace DotnetMultirotor.Controllers
{
	public class UsersController : Controller
  {
		private readonly DotnetMultirotorContext context;
	  public UsersController(DotnetMultirotorContext context)
		{
		  this.context = context;
		}

		[HttpGet("/api/users")]
	  public async Task<IEnumerable<Models.User>> GetUsers()
		{
			return await context.Users.ToListAsync();
		}	

	}
	
}
