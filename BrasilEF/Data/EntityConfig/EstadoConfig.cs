using System.Data.Entity.ModelConfiguration;
using BrasilEF.Data.Entities;

namespace BrasilEF.Data.EntityConfig
{
	public class EstadoConfig : EntityTypeConfiguration<Estado>
	{
		public readonly static string NomeTabela = "Estados";

		public EstadoConfig()
		{
			HasKey(e => e.Id);
			Property(i => i.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			Property(e => e.DataCadastro)
				.IsRequired();

			Property(e => e.Nome)
			.HasColumnType("nvarchar")
			.IsRequired()
			.HasMaxLength(60);

			HasRequired(e => e.Pais)
			.WithMany(p => p.Estados)
			.HasForeignKey(e => e.PaisId);

			Property(e => e.Sigla)
			.IsRequired()
			.HasMaxLength(2);

			ToTable(NomeTabela);
		}
	}
}
