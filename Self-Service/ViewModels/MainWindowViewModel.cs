using System;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Self_Service.Views;

namespace Self_Service.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{   
    [ObservableProperty]
    public partial decimal Total { get; set; }

    [ObservableProperty] public partial string? Notificacao { get; set; };
    public ObservableCollection<Produto> Produtos { get; } =
    [
        new Produto("Arroz", 12.98m, "avares://Self-Service/Assets/Img/arroz.png"),
        new Produto("Feijão", 8.59m, "avares://Self-Service/Assets/Img/feijao.png"),
        new Produto("Batata", 5.89m, "avares://Self-Service/Assets/Img/batata.png"),
        new Produto("Maça", 3.99m, "avares://Self-Service/Assets/Img/maca.png"),
        new Produto("Banana", 56.77m, "avares://Self-Service/Assets/Img/banana.png")
    ];

    public ObservableCollection<ItemCarrinho> Carrinho { get; set; } = [];
    
    [RelayCommand] private void AdicionarAoCarrinho(Produto produto)
    {
        var item = Carrinho.FirstOrDefault(x => x.Produto == produto);
        if (item == null)
        {
            Carrinho.Add(new ItemCarrinho(produto,1));
        }
        else
        {
            item.Quantidade++;
        }

        RecalcularTotal();
    }
    
    [RelayCommand] private void AumentarQuantidade(ItemCarrinho item)
    {
        item.Quantidade += 1;
        RecalcularTotal();
    }
    
    [RelayCommand] private void DiminuirQuantidade(ItemCarrinho item)
    {
        if (item.Quantidade <= 1)
        {
            Carrinho.Remove(item);
        }
        else
        {
            item.Quantidade -= 1;
        }
        RecalcularTotal();
    }
    
    private void RecalcularTotal()
    {
        Total =  Carrinho.Sum(x => x.Quantidade * x.Produto.Preco );
    }

    [RelayCommand] private void Pagar()
    {
        Carrinho.Clear();
        RecalcularTotal();
        Notificacao = "Pagamento Efetuado com sucesso!";
    }
}