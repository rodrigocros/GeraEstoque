namespace GeraEstoque.Screens;
using  GeraEstoque.repositories;
using GeraEstoque.models;

public static class CriarProdutoScreen
{
    public static void Iniciar(ProdutoRepository repository)
    {
    Console.Clear();
    Console.WriteLine("------------------------");
    Console.WriteLine("Cadastrar Produto");
    Console.WriteLine("Nome do produto:");
    var nomeProduto = Console.ReadLine();

    Console.WriteLine("Quantidade em estoque:");
    var quantidadeEstoque = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Valor de compra:");
    var valorCompra = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Valor de venda:");
    var valorVenda = int.Parse(Console.ReadLine()!);
    Guid id = Guid.NewGuid();

    var produto = new Produto(nomeProduto!, quantidadeEstoque, valorCompra, valorVenda);

    Console.WriteLine("------------------------");
    Console.WriteLine("Produto cadastrado com sucesso!");
    Console.WriteLine(" ");
    Console.WriteLine("Id do Produto");
    Console.WriteLine(id.ToString());
    Console.WriteLine("Nome do produto:");
    Console.WriteLine(nomeProduto);
    Console.WriteLine("Quantidade em estoque:");
    Console.WriteLine(quantidadeEstoque);
    Console.WriteLine("Valor de compra:");
    Console.WriteLine(valorCompra);
    Console.WriteLine("Valor de venda:");
    Console.WriteLine(valorVenda);

    repository.Produtos.Add(produto);
    Console.ReadLine();
    }
}
