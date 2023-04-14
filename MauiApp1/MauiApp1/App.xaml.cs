namespace MauiApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var navPage = new NavigationPage(new MainPage())
        {
            Background = Colors.Purple,
            BarTextColor = Colors.White
        };

        MainPage = navPage; //new AppShell();
    }
}
