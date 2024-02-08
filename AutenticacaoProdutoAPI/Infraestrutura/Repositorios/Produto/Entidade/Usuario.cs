using AutenticacaoProdutoAPI.Infrastructure.Repositories.Connection;

namespace AutenticacaoProdutoAPI.Infrastructure.Repositories.Produto.Entity
{
    public class Usuario : ProdutoAbstrato
    {
        public Usuario(
            string loginUsuario,
            string senha,
            DateTime dataCadastroSenha,
            int diasRenovacao,
            int idGrupo,
            int idPessoa
        )
        {
            LoginUsuario = loginUsuario;
            Senha = senha;
            DataCadastroSenha = dataCadastroSenha;
            DiasRenovacao = diasRenovacao;
            IdGrupo = idGrupo;
            IdPessoa = idPessoa;
        }

        public string LoginUsuario { get; }
        public string Senha { get; }
        public DateTime DataCadastroSenha { get; set; }
        public int DiasRenovacao { get; set; }
        public int IdGrupo { get; }
        public int IdPessoa { get; }
        public List<UsuarioGrupo> UsuarioGrupos { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
