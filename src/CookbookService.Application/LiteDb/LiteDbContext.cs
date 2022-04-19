using LiteDB;
using Microsoft.Extensions.Options;
using CookbookService.Domain.Options;
using CookbookService.Infrastrructure.Abstractions;

namespace CookbookService.Infrastrructure.LiteDb
{
	public class LiteDbContext<TEntity> : IRepository<TEntity> where TEntity : class
	{
		private LiteDatabase _database { get; init; }

		public LiteDbContext(IOptions<LiteDbOptions> settings)
		{
			_database = new LiteDatabase(settings.Value.DatabaseLocation);
		}

		public TEntity GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TEntity> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Add(TEntity entity)
		{
			_database.GetCollection<TEntity>().Insert(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			throw new NotImplementedException();
		}

		public void Remove(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			throw new NotImplementedException();
		}
	}
}
