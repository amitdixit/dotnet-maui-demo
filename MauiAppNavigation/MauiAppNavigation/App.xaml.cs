namespace MauiAppNavigation;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MVVM.Views.PageOne());
    }
}
