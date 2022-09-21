using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppDependencyInyection.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection service = new ServiceCollection();
            ConfigureServices(service);
            _serviceProvider = service.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection service)
        {
            service.AddSingleton<MainWindow>();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            MainWindow.Show();
        }
    }
}
