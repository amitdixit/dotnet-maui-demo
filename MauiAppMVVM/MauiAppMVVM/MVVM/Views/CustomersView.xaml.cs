using MauiAppMVVM.MVVM.ViewModels;

namespace MauiAppMVVM.MVVM.Views;

public partial class CustomersView : ContentPage
{
    public CustomersView()
    {
        InitializeComponent();
        BindingContext = new CustomersViewModel();
    }
}