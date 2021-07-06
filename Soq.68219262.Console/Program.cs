using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Soq._68219262.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            IMapper mapper = services.BuildServiceProvider().GetService<IMapper>();

            IEnumerable<IMySetting> settings = await MySettingService.GetCollectionAsync();

            IMySettingLookup lookup = mapper.Map<IMySettingLookup>(settings);

            System.Console.WriteLine(lookup.MySetting1);
            System.Console.WriteLine(lookup.MySetting2);

            // Expected output:
            // MyValue1
            // MyValue2
        }
    }
}
