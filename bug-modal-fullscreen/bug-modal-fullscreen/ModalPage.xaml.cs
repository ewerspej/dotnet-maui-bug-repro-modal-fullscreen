using bug_modal_fullscreen.Services;

namespace bug_modal_fullscreen;

public partial class ModalPage : ContentPage
{
    private readonly DeviceServices _deviceServices;

    public ModalPage()
    {
        InitializeComponent();

        _deviceServices = new DeviceServices();
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        _deviceServices?.HideSystemControls();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        _deviceServices.ShowSystemControls();
    }
}