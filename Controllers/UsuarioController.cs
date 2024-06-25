using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using revisandoApis.Data.Dtos;
using revisandoApis.Models;
using revisandoApis.services;

namespace revisandoApis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto){
            await _usuarioService.Cadastra(dto);
            return Ok("Usuário cadastrado");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto){
           var token = await _usuarioService.Login(dto);
            return Ok(token);
        }
    }
}