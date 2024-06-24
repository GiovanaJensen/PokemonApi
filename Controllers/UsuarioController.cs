using Microsoft.AspNetCore.Mvc;
using revisandoApis.Data.Dtos;

namespace revisandoApis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto dto){
            throw new NotImplementedException();
        }
    }
}