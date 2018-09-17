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

	[Route("/api/posts")]
	public class PostsController : Controller
  {
		private readonly DotnetMultirotorContext context;
		private readonly IMapper mapper;
	  public PostsController(DotnetMultirotorContext context, IMapper mapper)
		{
		  this.context = context;
			this.mapper = mapper;
		}

		[HttpGet]
	  public async Task<IEnumerable<Models.Post>> GetPosts()
		{
			return await context.Posts.ToListAsync();
		}	

		[HttpPost]
		public IActionResult CreatePost([FromBody] Models.Post post)
		{
			return Ok(post);
		}

	}
	
}
