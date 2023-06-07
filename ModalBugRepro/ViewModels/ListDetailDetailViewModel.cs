namespace ModalBugRepro.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ListDetailDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;

    [RelayCommand]
    private async Task SaveAsync()
    {
        //await _someService.SaveItemAsync(Item);
        await Shell.Current.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task ResetAsync()
    {
        await Shell.Current.Navigation.PopAsync();
    }

    [RelayCommand]
    private async Task ShowEditAsync()
    {
        // This workaround does not work
        //await Shell.Current.Navigation.PushModalAsync(new NavigationPage(new EditPage(this) { Title="This does not show" }));
        
        await Shell.Current.GoToAsync("edit", true, new Dictionary<string, object>
        {
            { "Item", Item }
        });
    }
}
