using Application.Common.Interfaces;
using Domain.Entities;
using Infrastructure.Common.Factories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public Repository(IDbContextFactory factory)
        {
            _context = (ApplicationDbContext)factory.Create();
        }

        protected DbSet<T> Set => _context.Set<T>();

        public IQueryable<T> ListarTodos()
        {
            return Set.AsQueryable<T>();
        }

        public async Task<IEnumerable<T>> ListarTodosAsync()
        {
            return await Set.ToListAsync();
        }

        public async Task<T?> ObtenerPorIdAsync(Guid id)
        {
            return await Set.FindAsync(id);
        }

        public async Task<T> ObtenerPorIdAsync(string id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await Set.FindAsync(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task AgregarAsync(T entity)
        {
            await Set.AddAsync(entity);
            await GuardarAsync();
        }

        public async Task ActualizarAsync(T entity)
        {
            Set.Update(entity);
            await GuardarAsync();
        }

        public async Task EliminarAsync(T entity)
        {
            Set.Remove(entity);
            await GuardarAsync();
        }

        public async Task<IEnumerable<T>> ExecuteStoredProcedure(string query)
        {
            return await Set.FromSqlRaw(query).ToListAsync();
        }

        ///////////////////////////// Private Methods ///////////////////////////////
        private async Task GuardarAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
