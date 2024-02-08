using System.ComponentModel;

namespace AutenticacaoProdutoAPI.Infrastructure.Repositories.Connection
{
    public abstract class ProdutoAbstrato
    {
        public ProdutoAbstrato()
        {
            DataRegistro = DateTime.Now;
            Ativo = true;
        }

        public Guid Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public bool Ativo { get; set; }
    }
}