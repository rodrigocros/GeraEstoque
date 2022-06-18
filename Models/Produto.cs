namespace GeraEstoque.models
{
    public class Produto
    {
        
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }

        public Produto(){}

        public Produto(string name, int quantidade, decimal valorCompra, decimal valorVenda)
        {
            Id = Guid.NewGuid();
            Nome = name;
            QuantidadeEstoque = quantidade;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
        }

        public override string ToString()
        {
            return $"Id do Produto: {Id}\nNome do produto: {Nome}\nQuantidade em estoque: {QuantidadeEstoque}\nValor de compra: {ValorCompra}\nValor de venda: {ValorVenda}";
        }

        
        
    }
}