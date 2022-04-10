using CookbookService.Infrastrructure.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace CookbookService.Infrastrructure.EntityFramework.Repositories
{
	public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected readonly DatabaseContext _context;
		private readonly DbSet<TEntity> _dbSet;

		public GenericRepository(DatabaseContext context)
		{
			_context = context;
			_dbSet = _context.Set<TEntity>();
		}

		public virtual void Add(TEntity entity)
		{
			_dbSet.Add(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			throw new NotImplementedException();
		}

		public TEntity GetById(int id)
		{
			return _dbSet.Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return _dbSet.ToList();
		}

		public void Remove(TEntity entity)
		{
			{
				if (_context.Entry(entity).State == EntityState.Detached)
				{
					_dbSet.Attach(entity);
				}
				_dbSet.Remove(entity);
			}
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			throw new NotImplementedException();
		}
	}
}
