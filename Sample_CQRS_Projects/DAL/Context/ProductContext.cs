using Microsoft.EntityFrameworkCore;
using Sample_CQRS_Projects.DAL.Entities;

namespace Sample_CQRS_Projects.DAL.Context
{
	public class ProductContext:DbContext

	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-0LTDDDI\\SQLEXPRESS01;initial catalog=SampleCQRS;integrated security=true");
		}

		public DbSet<Product> Products { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<University> Universities { get; set; }
    }
}
