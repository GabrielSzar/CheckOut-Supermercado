using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Self_Service.ViewModels;

namespace Self_Service.Views;

public partial class CarrinhoWindow : Window
{
    public CarrinhoWindow(MainWindowViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}