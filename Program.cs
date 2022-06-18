namespace GeraEstoque;
using GeraEstoque.Screens;
using GeraEstoque.repositories;

class Program
{   static void Main(string[] args)
    {
        var repository = new ProdutoRepository();
        MenuScreen.Iniciar(repository);
        
    }

}

