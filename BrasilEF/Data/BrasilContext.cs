using BrasilEF.Data.Entities;
using BrasilEF.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace BrasilEF.Data
{
	class BrasilContext : DbContext
	{
		public DbSet<Cidade> Cidades { get; set; }
		public DbSet<Estado> Estados { get; set; }
		public DbSet<Pais> Paises { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			modelBuilder.Configurations.Add(new CidadeConfig());
			modelBuilder.Configurations.Add(new EstadoConfig());
			modelBuilder.Configurations.Add(new PaisConfig());

		}

		public override int SaveChanges()
		{
			foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("DataCadastro").CurrentValue = DateTime.Now;
				}

				if (entry.State == EntityState.Modified)
				{
					entry.Property("DataCadastro").IsModified = false;
				}
			}
			return base.SaveChanges();
		}

	}
}
