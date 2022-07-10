using AutoMapper;
using FloraCapstone2nd.Model;
using FloraCapstone2nd.ViewModel;

namespace FloraCapstone2nd.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User, RegisterViewModel>().ReverseMap();
        }
        
    }
}
