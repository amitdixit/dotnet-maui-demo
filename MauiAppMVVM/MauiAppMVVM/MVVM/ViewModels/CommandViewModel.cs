using System.Windows.Input;

namespace MauiAppMVVM.MVVM.ViewModels;
internal class CommandViewModel
{
    public ICommand BtnClickCommand =>
           new Command(() => App.Current.MainPage.DisplayAlert("First Command", "You clicked the button", "OK"));
}
