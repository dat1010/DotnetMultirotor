using System;
using System.ComponentModel.DataAnnotations;

namespace DotnetMultirotor.Controllers.Resources
{
	public class PostResource
	{
		public int Id {get; set;}

		[Required]
		[StringLength(255)]
		public string Title {get; set;} 
		[Required]
		public string Body {get; set;}
		public DateTime Date {get; set;}

	}
}
