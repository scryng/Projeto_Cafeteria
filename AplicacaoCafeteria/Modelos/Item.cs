using System;   //using é equivalente ao import JAVA
                //namespace é equivalente ao package do JAVA

public class Item (string nome, decimal preco)
{
    // Atributos e métodos da classe
    public string Nome { get; private set; } = nome;
    public decimal Preco { get; protected set; } = preco;

    // // Construtor
    // public Item(string nome, decimal preco)
    // {
    //     Nome = nome; 
    //     Preco = preco; 
    // }

    // Métodos
    public virtual decimal CalcularPreco()
    {
        return Preco;
    }

    // ToString()
    public override string ToString()
    {
        return $"Item: {Nome}, Preço: {Preco:C}";
    }
}