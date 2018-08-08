using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Linq;
using System.Windows;
using Models;


namespace RemoveJasGUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider RegisterServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<Blade>();
            //serviceCollection.AddSingleton<, BooksService>();
            //serviceCollection.AddSingleton<IBooksRepository, BooksSampleRepository>();
            return serviceCollection.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Container = RegisterServices();

            var mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private Blade _BladeService;
        public Blade BladeService
        {
            get
            {
                _BladeService = new Blade();
                return _BladeService;
            }
        }
    }
}
