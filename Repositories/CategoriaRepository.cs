using CardapioWeb.Models;
using Microsoft.EntityFrameworkCore;
using CardapioWeb.Context;
namespace CardapioWeb.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    { 

        private readonly AppDBContext _dbcontext;
        public CategoriaRepository ( AppDBContext dbcontext)
        {
        _dbcontext = dbcontext;

        }
    public IEnumerable<Categoria> GetAll()
    {
    return _dbcontext.Categorias.ToList();
    }
    }
}
