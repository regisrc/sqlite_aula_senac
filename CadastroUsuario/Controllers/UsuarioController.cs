using CadastroUsuario.Application.Interfaces;
using CadastroUsuario.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CadastroUsuario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _usuarioService.Get());
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _usuarioService.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] InputUsuarioDto usuarioDto)
        {
            _usuarioService.Add(usuarioDto.Login, usuarioDto.Password);

            return Ok();
        }
    }
}