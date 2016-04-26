using System;
using System.Linq;

namespace BrasilEF
{
	class Program
	{
		static void Main(string[] args)
		{
			using (Data.BrasilContext context = new Data.BrasilContext())
			{
				Console.WriteLine(string.Format("Países: {0}", context.Paises.Count()));
				Console.WriteLine(string.Format("Estados: {0}", context.Estados.Count()));
				Console.WriteLine(string.Format("Cidades: {0}", context.Cidades.Count()));

				Console.ReadKey();
			}
		}
	}
}
