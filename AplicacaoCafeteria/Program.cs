using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Cria os itens
        Item comida = new Item("Pão de queijo", 5.90m);
        Item bebida = new Cafe("Capuccino", 4.00m, "Grande", "Expresso");
        Item sobremesa = new Sobremesa("Bolo", 4.00m, "Chocolate");

        // Cria um pedido e adiciona os itens
        List<Item> itens = new List<Item>();  // Lista de itens inicializada vazia
        Pedido pedido = new Pedido("Pedido Completo", 0, 12345, "João", itens);

        pedido.AdicionarItem(comida);
        pedido.AdicionarItem(bebida);
        pedido.AdicionarItem(sobremesa);

        // Exibe o pedido completo
        Console.WriteLine(pedido);
    }
}