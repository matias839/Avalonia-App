using AvaloniaApplication1.Views;

namespace AvaloniaApplication1.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Contador de clicks: ";
    
    private int _clickCount;

    [RelayCommand]
    private void ChangeText()
    {
        _clickCount++;
        Greeting = $"Contador de clicks: {_clickCount}";
        
        if (_clickCount >= 100)
        {
            Greeting = "¡Has alcanzado el límite de clicks!";
            _clickCount = 100;
        }
    }
}