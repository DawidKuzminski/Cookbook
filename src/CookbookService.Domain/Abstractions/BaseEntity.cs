namespace CookbookService.Domain.Abstractions
{
	public abstract class BaseEntity
	{
		public virtual int Id { get; protected set; }

		public BaseEntity()
		{
		}

		public BaseEntity(int id)
		{
			Id = id;
		}
	}
}
