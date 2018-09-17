using System.ComponentModel.DataAnnotations;

namespace DotnetMultirotor.Controllers.Resources
{
	public class UserResource
	{
	  public int Id {get;set;}

		[Required]
		[StringLength(255)]
		public string Name {get;set;}
		[Required]
		public string Email {get;set;}
		[Required]
		public string Password {get;set;}
	
	}
}
