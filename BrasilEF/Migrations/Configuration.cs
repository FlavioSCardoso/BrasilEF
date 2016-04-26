using BrasilEF.Seed;
using System.Data.Entity.Migrations;
using System.Linq;

namespace BrasilEF.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<BrasilEF.Data.BrasilContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BrasilEF.Data.BrasilContext context)
        {
			if(context.Paises.Count() == 0)
				Localizacao.Seed(context);
		}
	}
}
