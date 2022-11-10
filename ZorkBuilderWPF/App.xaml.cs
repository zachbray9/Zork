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
