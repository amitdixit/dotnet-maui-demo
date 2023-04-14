namespace MauiLayout;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void SLayoutBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new StackDemo());
    }

    private void SLayoutBtn_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HStackDemo());
    }

    private void GridBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridDemo());
    }

    private void OnCalc_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CalcDemo());
    }

    private void FlexBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexDemo());
    }

    private void OnAbsoluteClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteDemo());
    }
}

