using System;
using System.Runtime.CompilerServices;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace Self_Service;

public class Produto(string nome, decimal valor, string caminhoImg)
{
    public string Nome { get; set; } = nome;
    public decimal Preco { get; set; } = valor;
    public Bitmap Img { get; set; } = new(AssetLoader.Open(new Uri(caminhoImg)));
}