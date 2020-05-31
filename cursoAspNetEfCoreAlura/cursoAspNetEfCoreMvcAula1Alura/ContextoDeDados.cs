using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo
{
	public class ContextoDeDados : DbContext
	{
		public ContextoDeDados(DbContextOptions options) : base(options)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Produto>().HasKey(t => t.Id);
		}
	}
}