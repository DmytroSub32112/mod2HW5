using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Hw5
{
    public class AppStarter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
               .AddSingleton<ILogger, Logger>()
               .AddTransient<IConfigService, ConfigService>()
               .AddTransient<IFileService, FileService>()
               .AddTransient<Actions>()
               .AddTransient<Starter>().BuildServiceProvider();
            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}
