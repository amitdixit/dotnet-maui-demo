using MauiAppMvvmCollections.MVVM.ViewModels;

namespace MauiAppMvvmCollections.MVVM.Views;

public partial class PlayerView : ContentPage
{
    public PlayerView()
    {
        InitializeComponent();
        BindingContext = new PlayerViewModel();
    }
}