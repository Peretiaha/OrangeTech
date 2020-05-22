using AutoMapper;

namespace OrangeTech.Web.Mapping
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration Create()
        {
            var config = new MapperConfiguration(
                x =>
                {
                    x.AddProfile<MappingProfile>();
                });
            return config;
        }
    }
}
