using CardapioWeb.Models;
using Microsoft.EntityFrameworkCore;
using CardapioWeb.Context;

namespace CardapioWeb.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private readonly AppDBContext _dbcontext;
        public CategoriaRepository(AppDBContext dbcontext)
        {
            _dbcontext = dbcontext;

        }

        public async Task Add(Categoria categoria)
        {
            try
            {
                _dbcontext.Categorias.Add(categoria); //ad coisa no bd
                await _dbcontext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }

        }

        public async Task Delete(Categoria categoria)
        {
            try
            {
                _dbcontext.Categorias.Remove(categoria); //ad coisa no bd
                await _dbcontext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }
        }

        public async Task<Categoria> GetById(int id)
        {
            return await _dbcontext.Categorias.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task Update(Categoria categoria)
        {
            try
            {
                _dbcontext.Categorias.Update(categoria); //ad coisa no bd
                await _dbcontext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }
        }

        public async Task<List<Categoria>> GetAll()
        {
            return await _dbcontext.Categorias.ToListAsync();
        }
    }
}
