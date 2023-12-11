using CRUD_User.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_User.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> Usuarios() {
            return new List<Usuario>{
                new Usuario{ Nome = "Maycon", Id = 1, DataNascimento = new DateTime(1992, 06, 13)}
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Usuarios());
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            var usuarios = Usuarios();
            usuarios.Add(usuario);
            return Ok(usuarios);
        }

   
    }
}