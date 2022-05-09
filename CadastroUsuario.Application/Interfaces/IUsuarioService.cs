using CadastroUsuario.Application.Dto;

namespace CadastroUsuario.Application.Interfaces
{
    public interface IUsuarioService
    {
        void Add(string login, string password);

        Task<List<UsuarioDto>> Get();

        Task<UsuarioDto> GetById(Guid id);
    }
}
