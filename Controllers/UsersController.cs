using DotnetMultirotor.Controllers.Resources; 
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DotnetMultirotor;
using System.Threading.Tasks;
using DotnetMultirotor.Persistence;

namespace DotnetMultirotor.Controllers
{
	[Route("/api/users")]
	public class UsersController : Controller
  {
		private readonly DotnetMultirotorContext context;
		private readonly IMapper mapper;
	  public UsersController(DotnetMultirotorContext context, IMapper mapper)
		{
		  this.context = context;
			this.mapper = mapper;
		}

		[HttpGet]
	  public async Task<IEnumerable<Models.User>> GetUsers()
		{
			return await context.Users.ToListAsync();
		}	

		[HttpPost]
		public IActionResult CreateUser([FromBody] Models.User user)
		{
			return Ok(user);
		}

	}
	
}
