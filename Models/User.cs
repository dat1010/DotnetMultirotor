using System.ComponentModel.DataAnnotations;

namespace DotnetMultirotor.Models

{
	public class User
	{
		public int Id {get;set;}

		[Required]
		[StringLength(255)]
		public string Name {get;set;}
		public string Email {get;set;}
		public string Password {get;set;}
	}
}
