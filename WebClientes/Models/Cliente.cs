using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebClientes.Models
{
	[Table("clientes")]
	public class Cliente
	{
		[Column("Id")]
		[Display(Name = "ID")]
		public int Id { get; set; }
		[Column("Name")]
		[Display(Name = "Nome")]
		public string Name { get; set; }
		[Column("Email")]
		[Display(Name="E-mail")]
		public string Email { get; set; }
	}
}
