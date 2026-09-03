using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Self_Service;

public partial class ItemCarrinho(Produto produto, int quantidade) : ObservableObject
{   
    public Produto Produto { get; } = produto;
    [ObservableProperty] public partial int Quantidade { get; set; } = quantidade;
}