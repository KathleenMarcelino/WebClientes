using Microsoft.EntityFrameworkCore;
namespace WebClientes.Models
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options) : base(options)
		{

		}

		public DbSet<Cliente> Cliente { get; set; }
	}
}
