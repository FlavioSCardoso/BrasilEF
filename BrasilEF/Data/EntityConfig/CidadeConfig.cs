using BrasilEF.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BrasilEF.Data.EntityConfig
{
	public class CidadeConfig : EntityTypeConfiguration<Cidade>
	{

		public CidadeConfig()
		{
			HasKey(c => c.Id);
			Property(i => i.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			Property(c => c.DataCadastro)
				.IsRequired();

			Property(c => c.Nome)
			.HasColumnType("varchar")
			.HasMaxLength(60)
			.IsRequired();

			HasRequired(c => c.Estado)
			.WithMany(e => e.Cidades)
			.HasForeignKey(c => c.EstadoId);

			ToTable("Cidades");
		}
	}
}
