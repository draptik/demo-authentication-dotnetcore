using AutoMapper;
using Proxy.Controllers.Resources;
using Proxy.Core.Models;

namespace Proxy.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<UserCredentialsResource, User>();
        }
    }
}
