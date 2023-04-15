using MauiAppMVVM.MVVM.ViewModels;

namespace MauiAppMVVM.MVVM.Views;

public partial class CustomerView : ContentPage
{
    public CustomerView()
    {
        InitializeComponent();

        BindingContext = new CustomerViewModel();
    }
}