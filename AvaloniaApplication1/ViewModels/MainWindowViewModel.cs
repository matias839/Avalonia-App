namespace AvaloniaApplication1.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Mi primer programa en Avalonia";
    
    private int _clickCount;

    [RelayCommand]
    private void ChangeText()
    {
        _clickCount++;
        Greeting = $"Has clickeado {_clickCount} veces";
    }
}