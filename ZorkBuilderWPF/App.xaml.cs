using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ZorkBuilderWPF.ViewModels;

namespace ZorkBuilderWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new ZorkBuilderViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
