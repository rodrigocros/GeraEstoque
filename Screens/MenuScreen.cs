namespace GeraEstoque.Screens;
using GeraEstoque.repositories;
public static class MenuScreen
{
    public static void Iniciar( ProdutoRepository repository)
    {
        Menu();
        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1 : CriarProdutoScreen.Iniciar(repository); Iniciar(repository); break;
            case 2 : ConsultarProduto(); break;
            case 3 : ModificarProduto(); break;
            case 4 : ExcluirProduto(); break;
            case 5 : ListarProdutoScreen.Iniciar(repository); Iniciar(repository); break;
            case 0 : Sair(); break;
            default: Environment.Exit(0); break;
        }
    }
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine(":D");
        Console.WriteLine("Seja Bem vindo ao GeraEstoque 1.0");
        Console.WriteLine("------------------------");
        Console.WriteLine("1 - Cadastrar Produto.");
        Console.WriteLine("2 - Consultar Produto.");
        Console.WriteLine("3 - Modificar Produto.");
        Console.WriteLine("4 - Excluir Produto.");
        Console.WriteLine("5 - Listar todos os Produtos");
        Console.WriteLine("0 - Sair.");
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
