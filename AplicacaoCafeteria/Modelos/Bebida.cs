using System;   // using é equivalente ao import em Java

public abstract class Bebida : Item
{
    // Atributos e métodos da classe
    public string Tamanho { get; private set; }

    // Construtor
    public Bebida(string nome, decimal preco, string tamanho) : base(nome, preco)
    {
        Tamanho = tamanho;
    }

    // Métodos
    public override abstract decimal CalcularPreco();
    public override abstract string ToString();
}