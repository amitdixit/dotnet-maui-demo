using MauiAppMvvmCollections.MVVM.ViewModels;

namespace MauiAppMvvmCollections.MVVM.Views;

public partial class PlayerCollectionView : ContentPage
{
    public PlayerCollectionView()
    {
        InitializeComponent();
        BindingContext = new PlayerViewModel();
    }
}