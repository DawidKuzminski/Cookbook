namespace CookbookService.Infrastrructure.Abstractions
{
	public interface IRepository<TEntity> where TEntity : class
	{
		Task<TEntity> GetByIdAsync(int id);
		IEnumerable<TEntity> GetAll();

		void Add(TEntity entity);
		void AddRange(IEnumerable<TEntity> entities);

		void Remove(TEntity entity);
		void RemoveRange(IEnumerable<TEntity> entities);
	}
}
