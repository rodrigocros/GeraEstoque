namespace GeraEstoque.repositories;
using GeraEstoque.models;

public class ProdutoRepository
{ 
    public IList<Produto> Produtos {get; set;}
    
    public ProdutoRepository()
    {
        Produtos = new List<Produto>();
    }
}
