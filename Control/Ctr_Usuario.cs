using ProjetoTCC.Dao;
using ProjetoTCC.Model;

namespace ProjetoTCC.Control
{
    class Ctr_Usuario
    {
        private static Usuario usuarioLogado;
        public static Usuario UsuarioLogado
        {
            get
            {
                if (usuarioLogado == null)
                    usuarioLogado = new Usuario();

                return usuarioLogado;
            }
            set
            {
                usuarioLogado = value;
            }
        }

        Dao_Usuario dao_usuario;

        public bool Conectar(Usuario Usuario)
        {
            bool result = dao_usuario.Connect(Usuario);

            if (result == true)
                UsuarioLogado = new Usuario() { Username = Usuario.Username };
            else
                UsuarioLogado = new Usuario();

            return result;
        }

        public bool Adicionar(Usuario Usuario)
        {
            return dao_usuario.Create(Usuario);
        }

        public bool AlterarSenha(Usuario Usuario)
        {
            return dao_usuario.Update(Usuario);
        }

        public Usuario Busca(Usuario Usuario)
        {
            return dao_usuario.Read(Usuario);
        }

        public bool Excluir(Usuario Usuario)
        {
            return dao_usuario.Delete(Usuario);
        }

        public Ctr_Usuario()
        {
            dao_usuario = new Dao_Usuario();
        }
    }
}
