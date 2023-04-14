namespace MauiAppControls;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private async void ControlBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ControlDemo());
    }
}

