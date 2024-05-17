using Microsoft.UI.Xaml.Controls;

using TestNameBind.ViewModels;

namespace TestNameBind.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
