using CRUD_Blazor.Server.Servicios;
using CRUD_Blazor.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario iUsuario;

        public UsuarioController(IUsuario iUsuario)
        {
            this.iUsuario = iUsuario;
        }

        [HttpGet]
        public async Task<List<Usuario>> ListaUsuarios()
        {
            return await Task.FromResult(iUsuario.DatosUsuarios());
        }
        [HttpPost]
        public void Post(Usuario usuario)
        {
            iUsuario.NuevoUsuario(usuario);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuario(int id)
        {
            Usuario usuario = iUsuario.DatosUsuario(id);
            if(usuario != null)
            {
                return Ok(usuario);
            }
            return NotFound();
        }

        [HttpPut]
        public void PutUsuario(Usuario usuario)
        {
            iUsuario.ActualizarUsuario(usuario);
        }

        [HttpDelete("{id}")]
        public void DeleteUsuario(int id)
        {
            iUsuario.EliminarUsuario(id);
        }

    }
}
