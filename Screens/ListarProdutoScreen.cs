namespace GeraEstoque.Screens;
using GeraEstoque.repositories;

public static class ListarProdutoScreen
{
    public static void Iniciar(ProdutoRepository repository)
{
    Console.Clear();
    Console.WriteLine("Produtos Cadastrados");
    Console.WriteLine("------------------------");
    foreach (var produto in repository.Produtos)
    {
        Console.WriteLine("Id do Produto");
        Console.WriteLine(produto.Id.ToString());
        Console.WriteLine("Nome do produto:");
        Console.WriteLine(produto.Nome);
        Console.WriteLine("Quantidade em estoque:");
        Console.WriteLine(produto.QuantidadeEstoque);
        Console.WriteLine("Valor de compra:");
        Console.WriteLine(produto.ValorCompra);
        Console.WriteLine("Valor de venda:");
        Console.WriteLine(produto.ValorVenda);
        Console.WriteLine(" ");

        Console.ReadLine();
    }

}

}
