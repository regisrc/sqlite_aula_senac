using CadastroUsuario.Domain.Entities;
using CadastroUsuario.Infrastructure.Context;
using CadastroUsuario.Infrastructure.Interfaces;

namespace CadastroUsuario.Infrastructure.Repositories
{
    public class UsuarioRepository : RepositoryBase<UsuarioEntity>, IUsuarioRepository
    {
        public UsuarioRepository(CadastroUsuarioContext context) : base(context)
        {
        }
    }
}
