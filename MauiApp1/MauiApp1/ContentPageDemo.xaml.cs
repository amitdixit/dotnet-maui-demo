namespace MauiApp1;

public partial class ContentPageDemo : ContentPage
{
    public ContentPageDemo()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new MainPage());
    }

    private void Flyout_Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new FlyoutDemoPage());
    }

    private void Tabbed_Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new TabbedDemoPage());
    }
}