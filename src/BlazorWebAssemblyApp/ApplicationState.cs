using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp;


public class ApplicationState 
{
    // back field
    private string _currentTheme = "light";

    // property
    public string CurrentTheme
    {
        get => _currentTheme;
        set 
        {
            _currentTheme = value;
            NotifyStateChanged(); // like a NotifyPropertyChanged in WPF
        }
    }


    public event Action? OnChange;
    private void NotifyStateChanged() => OnChange?.Invoke();

    public void ToggleTheme()
    {
        CurrentTheme = CurrentTheme == "light" ? "dark" : "light";
    }
}
