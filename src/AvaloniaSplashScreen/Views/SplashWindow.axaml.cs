using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using System;
using System.Threading.Tasks;

namespace AvaloniaSplashScreen.View;

public partial class SplashWindow : Window
{
    private readonly Action? _mainAction;

    public SplashWindow(Action mainAction)
    {
        InitializeComponent();
        _mainAction = mainAction;
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        DummyLoad();
    }

    private async void DummyLoad()
    {
        // Substitua por sua inicialização real (carregar configs, conectar BD, etc.)
        await Task.Delay(1000);
        prgLoading.Value = 25;
        await Task.Delay(2000);
        prgLoading.Value = 50;
        await Task.Delay(2000);
        prgLoading.Value = 75;
        await Task.Delay(2000);
        prgLoading.Value = 100;
        await Task.Delay(1000);

        // Após a "carga", execute a ação principal (abrir MainWindow) e feche o Splash
        await Dispatcher.UIThread.InvokeAsync(() =>
        {
            _mainAction?.Invoke();
            Close();
        });
    }
}