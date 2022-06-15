namespace GeraEstoque;

class Program
{   static void Main(string[] args)
    {
        Menu();
        var option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 1 : CadastrarProduto(); break;
            case 2 : ConsultarProduto(); break;
            case 3 : ModificarProduto(); break;
            case 4 : ExcluirProduto(); break;
            case 0 : Sair(); break;
            default: Menu(); break;
        }
    }
    public static void Menu()
    {
        Console.WriteLine(":D");
        Console.WriteLine("Seja Bem vindo ao GeraEstoque 1.0");
        Console.WriteLine("------------------------");
        Console.WriteLine("1 - Cadastrar Produto.");
        Console.WriteLine("2 - Consultar Produto.");
        Console.WriteLine("3 - Modificar Produto.");
        Console.WriteLine("4 - Excluir Produto.");
        Console.WriteLine("0 - Sair.");
    }
    public static void CadastrarProduto()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Cadastrar Produto");
        Console.WriteLine("Nome do produto:");
        var nomeProduto = Console.ReadLine();
        Console.WriteLine("Quantidade em estoque:");
        var quantidadeEstoque = Console.ReadLine();
        Console.WriteLine("Valor de compra:");
        var valorCompra = Console.ReadLine();
        Console.WriteLine("Valor de venda:");
        var valorVenda = Console.ReadLine();

        Guid id = Guid.NewGuid();

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


    }
    public static void ConsultarProduto()
    {

        Console.WriteLine("------------------------");
        Console.WriteLine("Consultar Produto:");
        Menu();

    } 
    public static void ModificarProduto()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("ModificarProduto");
        Menu();
    } 
    public static void ExcluirProduto() 
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Excluir Produto");
        Menu();
    } 
    public static void Sair()   
    {
        Console.WriteLine("Sair");
        Menu();
    }  

}

