using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Banking.Application.DTO.MapperProfile
{
    public static class IServiceCollectionExtension
    {
        public static IConfiguration _configuration { get; set; }

        public static void RegisterMappingProfiles(this IServiceCollection services)
        {
     
            var profiles = typeof(AccountProfile)
                                    .Assembly
                                    .GetTypes()
                                    .Where(x => typeof(Profile)
                                                .IsAssignableFrom(x))
                                                .ToList();

            var mappingConfig = new MapperConfiguration(cfg =>
                                        cfg.AddMaps(profiles));

            IMapper mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);
            services.AddSingleton<IMappingBase, MappingBase>();

            mappingConfig.CompileMappings();
        }
    }
}
