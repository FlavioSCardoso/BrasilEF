using System;

namespace BrasilEF.Data.Entities
{
	public class Cidade
    {

		public Cidade()
		{
		}

		public int Id { get; set; }  
        public string Nome { get; set; }
		public DateTime DataCadastro { get; set; }

		public int EstadoId { get; set; }  
        public virtual Estado Estado { get; set; }  
    }
}
