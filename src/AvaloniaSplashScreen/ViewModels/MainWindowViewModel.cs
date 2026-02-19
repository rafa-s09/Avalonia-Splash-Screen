using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaSplashScreen.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string? _text = "Avalonia Splash Screen ";
}