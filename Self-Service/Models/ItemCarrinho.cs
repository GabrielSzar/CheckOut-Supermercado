using System.Runtime.CompilerServices;

namespace Self_Service;

public class ItemCarrinho(Produto produto, int quantidade)
{   
    public Produto Produto { get; } = produto;
    public int Quantidade { get; set; } = quantidade;
}