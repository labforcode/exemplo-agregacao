using AutoMapper;

namespace Application.Automapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(configuration =>
            {
                configuration.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
