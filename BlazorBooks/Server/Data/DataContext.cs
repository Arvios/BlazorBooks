namespace BlazorBooks.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) 
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "Test",
					Description = "Test",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/6/65/Tokyo_Ghoul_volume_1.jpg",
					Price = 1,
				},
				new Product
				{
					Id = 2,
					Title = "Test",
					Description = "Test",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/6/65/Tokyo_Ghoul_volume_1.jpg",
					Price = 1,
				},
				new Product
				{
					Id = 3,
					Title = "Test",
					Description = "Test",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/6/65/Tokyo_Ghoul_volume_1.jpg",
					Price = 1,
				});
		}
		public DbSet<Product> Products { get; set; }
	}
}
