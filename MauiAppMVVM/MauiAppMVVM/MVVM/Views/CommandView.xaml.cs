using MauiAppMVVM.MVVM.ViewModels;

namespace MauiAppMVVM.MVVM.Views;

public partial class CommandView : ContentPage
{
    public CommandView()
    {
        InitializeComponent();
        BindingContext = new CommandViewModel();
    }
}