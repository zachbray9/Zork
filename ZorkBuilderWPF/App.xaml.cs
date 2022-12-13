using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using ZorkBuilderWPF.ViewModels;

namespace ZorkBuilderWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ZorkBuilderViewModel MainViewModel = new ZorkBuilderViewModel();
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = MainViewModel
            };
            MainWindow.Closing += Window_Closing;
            MainWindow.Show();

            base.OnStartup(e);
        }

        protected void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            MainViewModel.ExitCommand.Execute(null);
        }


    }
}
