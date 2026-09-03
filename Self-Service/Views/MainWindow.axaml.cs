using Avalonia.Controls;
using Avalonia.Interactivity;
using Self_Service.ViewModels;

namespace Self_Service.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void AbrirCarrinho_Click(object? sender, RoutedEventArgs e)
    {
        var viewModel = (MainWindowViewModel)DataContext!;
        var carrinhoWindow = new CarrinhoWindow(viewModel);
        carrinhoWindow.Show();
    }
}