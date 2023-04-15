using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiAppMVVM.MVVM.ViewModels;
internal class CalcViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private int num1;
    private int num2;
    private int answer;

    public int Num1
    {
        get => num1;
        set
        {
            num1 = value;
            OnPropertyChanged();
        }
    }
    public int Num2
    {
        get => num2;
        set
        {
            num2 = value;
            OnPropertyChanged();
        }
    }
    public int Answer
    {
        get => answer;
        set
        {
            answer = value;
            OnPropertyChanged();
        }
    }

    public ICommand SumCommand => new Command(() => Answer = Num1 + Num2);

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
