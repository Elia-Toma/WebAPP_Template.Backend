using Microsoft.EntityFrameworkCore;

namespace WebAPP_Template.Backend.Infrastructure.Context
{
	public class MyContext : DbContext
	{
		public MyContext(DbContextOptions<MyContext> options) : base(options)
		{
		}

		//public virtual DbSet<YourEntity> YourEntities { get; set; } // Add your entities here like this

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Load configurations from the classes in this project that implement IEntityTypeConfiguration.

			modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
			base.OnModelCreating(modelBuilder);
		}
	}
}
