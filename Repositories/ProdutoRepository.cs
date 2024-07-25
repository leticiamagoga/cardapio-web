using CardapioWeb.Context;
using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDBContext _dbContext;
        public IEnumerable<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Produto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> GetByPreferido()
        {
            throw new NotImplementedException();
        }
    }
}
