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
                new Usuario{ Nome = "Maycon", Id = 1,}
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Usuarios());
        }

   
    }
}