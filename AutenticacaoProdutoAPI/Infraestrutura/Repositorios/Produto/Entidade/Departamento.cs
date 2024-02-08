using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AutenticacaoProdutoAPI.Infrastructure.Repositories.Connection;

namespace AutenticacaoProdutoAPI.Infrastructure.Repositories.Produto.Entity
{
    public class DepartamentoDto : ProdutoAbstrato
    {
        public DepartamentoDto()
        {
        }
        public DepartamentoDto(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        [Description("NOME")]
        [StringLength(80)]
        public string Nome { get; set; }
        [Description("DESCRICAO")]
        [StringLength(200)]
        public string Descricao { get; set; }
    }
}
