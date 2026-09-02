using System.Runtime.CompilerServices;

namespace Self_Service;

public class Produto(string nome, decimal valor, string img)
{
    public string Nome { get; set; } = nome;
    public decimal Preco { get; set; } = valor;
    public string Img { get; set; } = img;
}