using AutoMapper;
using Gateway.Controllers.Resources;
using Gateway.Core.Models;

namespace Gateway.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<UserCredentialsResource, User>();
        }
    }
}
