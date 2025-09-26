using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Shared;

public class AppStateLayoutComponentBase : LayoutComponentBase
{
    [Inject]
    public ApplicationState AppState { get; set; }

    protected override void OnInitialized()
    {
        AppState.OnChange += StateHasChanged; // PropertyChanged(sender, arg)
    }

    public void Dispose()
    {
        AppState.OnChange -= StateHasChanged;
    }
}

public class AppStateComponentBase : ComponentBase
{
    [Inject]
    public ApplicationState AppState { get; set; }

    protected override void OnInitialized()
    {
        AppState.OnChange += StateHasChanged; // PropertyChanged(sender, arg)
    }

    public void Dispose()
    {
        AppState.OnChange -= StateHasChanged;
    }
}



