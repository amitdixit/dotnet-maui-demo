using MauiAppMVVM.MVVM.ViewModels;

namespace MauiAppMVVM.MVVM.Views;

public partial class CalcView : ContentPage
{
    public CalcView()
    {
        InitializeComponent();
        BindingContext = new CalcViewModel();
    }
}