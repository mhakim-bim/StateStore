using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using StateStore.Store;
using StateStore.ViewModels;

namespace StateStore
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            Services = ConfigureServices();
            base.OnStartup(e);
        }

        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IPersonStore, PersonStore>();
            services.AddSingleton<FirstChildViewModel>();
            services.AddSingleton<SecondChildViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
