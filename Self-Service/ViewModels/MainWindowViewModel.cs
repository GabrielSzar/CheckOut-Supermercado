using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Self_Service.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private decimal _total;
    public ObservableCollection<Produto> Produtos { get; } =
    [
        new Produto("Arroz", 12.98m, "avares://Self_Service/Assets/Img/arroz.png"),
        new Produto("Feijão", 8.59m, "avares://Self_Service/Assets/Img/feijao.png"),
        new Produto("Batata", 5.89m, "avares://Self_Service/Assets/Img/batata.png"),
        new Produto("Maça", 3.99m, "avares://Self_Service/Assets/Img/maca.png"),
        new Produto("Banana", 56.77m, "avares://Self_Service/Assets/Img/banana.png")
    ];

    private ObservableCollection<ItemCarrinho> Carrinho { get; set; }

    private void AdicionarAoCarrinho(Produto produto)
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
    
    private void RecalcularTotal()
    {
        Total =  Carrinho.Sum(x => x.Quantidade * x.Produto.Preco );
    }
    
}