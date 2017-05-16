using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Data.EntityConfig
{
    public class ProdutoConfiguration: EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);
            Property(p => p.Nome).IsRequired().HasMaxLength(150);
            Property(p => p.Valor).IsRequired();

            HasRequired(p => p.cliente).WithMany().HasForeignKey(p => p.ClienteId);
        }
    }
}
