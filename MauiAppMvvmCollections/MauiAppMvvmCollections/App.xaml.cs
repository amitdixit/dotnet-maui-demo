using MauiAppMvvmCollections.MVVM.Views;

namespace MauiAppMvvmCollections;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new PlayerCollectionView();
    }
}
