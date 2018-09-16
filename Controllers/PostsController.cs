using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DotnetMultirotor;
using System.Threading.Tasks;
using DotnetMultirotor.Persistence;

namespace DotnetMultirotor.Controllers
{
	public class PostsController : Controller
  {
		private readonly DotnetMultirotorContext context;
	  public PostsController(DotnetMultirotorContext context)
		{
		  this.context = context;
		}

		[HttpGet("/api/posts")]
	  public async Task<IEnumerable<Models.Post>> GetPosts()
		{
			return await context.Posts.ToListAsync();
		}	

	}
	
}
