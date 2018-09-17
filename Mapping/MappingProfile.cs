using AutoMapper;
using DotnetMultirotor.Controllers.Resources;

namespace DotnetMultirotor.Mapping
{
	public class MappingProfile : Profile
	{

		public MappingProfile()
		{
			CreateMap<Models.User,UserResource>();
			CreateMap<Models.Post,PostResource>();
		}
		
	}
}
