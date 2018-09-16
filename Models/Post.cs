using System;
using System.ComponentModel.DataAnnotations;

namespace DotnetMultirotor.Models
{
	public class Post
	{
		public int Id {get; set;}

		[Required]
		[StringLength(255)]
		public string Title {get; set;} 
		public string Body {get; set;}
		public int Votes {get; set;}
		public DateTime Date {get; set;}
		public int Views {get; set;}
		public int UserId {get; set;}
		public int Type {get; set;}
		public int ParentId {get; set;}
		
	}
}
