using CardapioWeb.Context;
using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDBContext _dbContext;

        public ProdutoRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _dbContext.Produtos.ToList(); // Busca tudo que há na tabela produtos, ToList converte em uma lista
        }

        public Produto GetById(int id)
        {
            return _dbContext.Produtos.FirstOrDefault(p => p.Id == id); // Busca pela referência Id, o FirstOrDefault pega o primeiro encontrado, se não achar envia uma mensagem de erro
        }

        public IEnumerable<Produto> GetByPreferido()
        {
            return _dbContext.Produtos.Where(p => p.Produto_Preferido == true).ToList(); // Busca pela referência dos produtos preferidos e monta uma lista
        }
    }
}