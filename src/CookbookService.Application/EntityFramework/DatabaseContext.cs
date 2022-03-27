using CookbookService.Domain;
using Microsoft.EntityFrameworkCore;

namespace CookbookService.Infrastrructure.EntityFramework
{
	public class DatabaseContext : DbContext
	{
		private readonly string _connectionString = "Server=localhost,1433;database=Cookbook;user id=sa;pwd=yourStrong(!)Password;";

		public DbSet<MenuEntity> Menus { get; set; }
		public DbSet<DayEntity> Days { get; set; }
		public DbSet<MealEntity> Meals { get; set; }
		public DbSet<DishEntity> Dishes { get; set; }
		public DbSet<IngredientEntity> Ingredients { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			OnMenuCreating(modelBuilder);
			OnDayCreating(modelBuilder);
			OnMealCreating(modelBuilder);
			OnDishCreating(modelBuilder);
			OnIngredientCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_connectionString);
		}

		private static void OnMenuCreating(ModelBuilder modelBuilder)
		{
			var entity = modelBuilder.Entity<MenuEntity>();
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50);

			entity.Property(e => e.Description)
				.HasMaxLength(255);

			entity.Property(e => e.Owner)
				.IsRequired()
				.HasMaxLength(50);
		}

		private static void OnDayCreating(ModelBuilder modelBuilder)
		{
			var entity = modelBuilder.Entity<DayEntity>();
			entity.Property(e => e.DayOfWeek)
				.IsRequired();
		}

		private static void OnMealCreating(ModelBuilder modelBuilder)
		{
			var entity  = modelBuilder.Entity<MealEntity>();
			entity.Property(e => e.Type)
				.IsRequired();
		}

		private static void OnDishCreating(ModelBuilder modelBuilder)
		{
			var entity = modelBuilder.Entity<DishEntity>();
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50);

			entity.Property(e => e.Description)
				.HasMaxLength(255);
		}

		private static void OnIngredientCreating(ModelBuilder modelBuilder)
		{
			var entity = modelBuilder.Entity<IngredientEntity>();
			entity.Property(e => e.Name)
				.IsRequired()
				.HasMaxLength(50);
		}
	}
}
