using MauiAppNavigation.MVVM.ViewModels;

namespace MauiAppNavigation.MVVM.Views;

public partial class PageTwo : ContentPage
{
    public PageTwo()
    {
        InitializeComponent();
        BindingContext = new PageTwoViewModel();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PageOne());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        // Navigation.PushAsync(new PageThree());

        var theData = ((PageTwoViewModel)BindingContext).Data;

        Navigation.PushAsync(new PageThree
        {
            BindingContext = new PageTwoViewModel { Data = theData },
        });
    }
}