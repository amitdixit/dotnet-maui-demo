using MauiAppMVVM.MVVM.Views;

namespace MauiAppMVVM;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new CalcView(); //new AppShell();
    }
}
