using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaSplashScreen.View;
using AvaloniaSplashScreen.ViewModels;

namespace AvaloniaSplashScreen
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new SplashWindow(() =>
                {

                    var mainWindow = new MainWindow()
                    {
                        DataContext = new MainWindowViewModel()
                    };

                    mainWindow.Show();
                    mainWindow.Focus();

                    desktop.MainWindow = mainWindow;
                });
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}