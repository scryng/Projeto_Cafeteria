using System;

public class Cafe : Bebida
{
    // Atributos e métodos da classe
    public string Tipo { get; private set; }

    // Construtor
    public Cafe(string nome, decimal preco, string tamanho, string tipo) : base(nome, preco, tamanho)
    {
        Tipo = tipo;
        Preco = CalcularPreco();
    }

    // Métodos
    public override decimal CalcularPreco()
    {
        // Ajusta o preço com base no tamanho
        return Tamanho == "Grande" ? Preco * 2 : Preco;
    }

    public override string ToString()
    {
        return $"Item: {Nome}, Preço: {Preco:C}, Tamanho: {Tamanho}, Tipo: {Tipo}";
    }
}