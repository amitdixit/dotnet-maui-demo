using MauiAppMVVM.MVVM.Models;

namespace MauiAppMVVM.MVVM.ViewModels;
internal class CustomerViewModel
{
    public Customer Customer { get; set; }

    public CustomerViewModel()
    {
        Customer = new Customer
        {
            Name = "Sam Smith",
            Street = "123 Main St",
            City = "Pittsburgh",
            State = "PA",
            ZipCode = 15222,
            Phone = "412-555-1212",
            BirthDay = new DateTime(1974, 12, 21),
            ContactTime = new TimeSpan(12, 0, 0),
            Balance = 123.45,
            ActiveCustomer = true
        };
    }
}
