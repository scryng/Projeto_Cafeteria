using System;

public class Pedido : Item
{
    // Atributos da classe
    public int NumeroPedido { get; private set; }
    public string Cliente { get; private set; }
    public List<Item> Itens { get; private set; }
    public decimal Total { get; private set; }

    // Construtor
    public Pedido(string nome, decimal preco, int numeropedido, string cliente, List<Item> itens) : base(nome, preco)
    {
        NumeroPedido = numeropedido;
        Cliente = cliente;
        Itens = itens;
        Total = CalcularTotal();  // Inicializa o total
    }

    // Métodos
    public void AdicionarItem(Item item)
    {
        Itens.Add(item);
        Total = CalcularTotal();  // Recalcula o total após adicionar o item
    }

    public void RemoverItem(Item item)
    {
        Itens.Remove(item);
        Total = CalcularTotal();  // Recalcula o total após remover o item
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var item in Itens)
        {
            total += item.Preco;
        }
        return total;
    }

    public override string ToString()
    {
        string itensDetalhes = "";
        foreach (var item in Itens)
        {
            itensDetalhes += $"{item.Nome} - {item.Preco:C}\n";
        }

        return $"Número do Pedido: {NumeroPedido}\n" +
               $"Cliente: {Cliente}\n" +
               $"Itens:\n{itensDetalhes}" +
               $"Total: {Total:C}";
    }
}
