using System.Data.Entity.ModelConfiguration;
using BrasilEF.Data.Entities;

namespace BrasilEF.Data.EntityConfig
{
	public class PaisConfig : EntityTypeConfiguration<Pais>
	{
		public PaisConfig()
		{
			HasKey(p => p.Id);
			Property(i => i.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			Property(p => p.DataCadastro)
				.IsRequired();

			Property(p => p.Nome)
				.HasMaxLength(60)
				.HasColumnType("varchar")
				.IsRequired();

			ToTable("Paises");
		}
	}
}
