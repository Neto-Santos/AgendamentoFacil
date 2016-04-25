using System.Data.Entity.ModelConfiguration.Conventions;
using ControleDeServicos.Models;
using System.Data.Entity;

namespace ControleDeServicos.DAL
{
  public class ControleDeServicoContext : DbContext
  {
    public ControleDeServicoContext() : base("name=DefaultConnection") {}

    public DbSet<Servico> Servicos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
  }
}