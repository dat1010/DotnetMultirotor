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
	  public PostsController(DotnetMultirotorContext context)
		{
		  this.context = context;
		}

		[HttpGet]
	  public async Task<IEnumerable<Models.Post>> GetPosts()
		{
			return await context.Posts.ToListAsync();
		}	

		[HttpPost]
		public async Task<IActionResult> CreatePost([FromBody] Models.Post post)
		{
			context.Posts.Add(post);
			await context.SaveChangesAsync();
			return Ok(post);
		}

		[HttpGet("{id}")]
		public async Task<Models.Post> GetPostById(int id)
		{
			return await context.Posts.FindAsync(id);
		}	

	}
	
}
