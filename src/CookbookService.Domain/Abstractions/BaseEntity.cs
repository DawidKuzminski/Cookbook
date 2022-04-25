namespace CookbookService.Domain.Abstractions
{
	public abstract class BaseEntity
	{
		public virtual int Id { get; init; }

		public BaseEntity()
		{
		}

		public BaseEntity(int id)
		{
			Id = id;
		}
	}
}
