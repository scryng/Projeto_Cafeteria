using System;   // using é equivalente ao import em Java

public class Sobremesa : Item
{
    // Atributos e métodos da classe
    public string Sabor { get; private set; }

    // Construtor
    public Sobremesa(string nome, decimal preco, string sabor) : base(nome, preco)
    {
        Sabor = sabor;
    }

    // Métodos
    public override decimal CalcularPreco()
    {
        return Preco;
    }
    public override string ToString()
    {
        return $"Item: {Nome}, Preço: {Preco:C}, Sabor: {Sabor}";
    }
}