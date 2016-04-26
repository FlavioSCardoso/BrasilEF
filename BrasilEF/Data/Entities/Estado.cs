using System;
using System.Collections.Generic;

namespace BrasilEF.Data.Entities
{
	public class Estado
    {
		public Estado()
		{
			Cidades = new List<Cidade>();
		}

		public int Id { get; set; } 
        public string Nome { get; set; } 
        public string Sigla { get; set; } 
        public int PaisId { get; set; }
		public DateTime DataCadastro { get; set; }

		public virtual ICollection<Cidade> Cidades { get; set; }

        public virtual Pais Pais { get; set; } 
    }
}
