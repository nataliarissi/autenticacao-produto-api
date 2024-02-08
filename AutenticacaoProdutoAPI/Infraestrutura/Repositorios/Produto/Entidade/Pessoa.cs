using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using AutenticacaoProdutoAPI.Infrastructure.Repositories.Connection;

namespace AutenticacaoProdutoAPI.Infrastructure.Repositories.Produto.Entity
{
    public class Pessoa : ProdutoAbstrato
    {
        public Pessoa()
        {
        }

        public Pessoa(int id, string nome, string cpf, string cnpj, string email, string ddd, string numero)
        {
            Nome = nome;
            Cpf = cpf;
            Cnpj = cnpj;
            Email = email;
            Ddd = ddd;
            Numero = numero;
        }

        public Pessoa(int id, string nome, Cpf cpf, string email, Telefone telefone)
        {
            bool possuiTelefone = telefone != null;

            Nome = nome;
            Cpf = cpf?.ValorNumerico;
            Email = email;
            Ddd = possuiTelefone ? telefone.Ddd : null;
            Numero = possuiTelefone ? telefone.Numero : null;
        }

        [Description("NOME")]
        [StringLength(80)]
        public string Nome { get; set; }
        [Description("CPF")]
        public string Cpf { get; set; }
        [Description("CNPJ")]
        public string Cnpj { get; set; }
        [Description("EMAIL")]
        [StringLength(100)]
        public string Email { get; set; }
        [Description("DDD")]
        public string Ddd { get; set; }
        [Description("NUMERO")]
        public string Numero { get; set; }
    }
}
