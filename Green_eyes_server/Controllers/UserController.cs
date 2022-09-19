using Green_eyes_server.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Green_eyes_server.Controllers
{
    [ApiController]
    [Route("v1/user")]
    public class UserController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        }*/


        [HttpPost(Name = "Postuser")]
        public async Task<IActionResult> Create([FromBody] UserModel usuario)
        {
            return Ok(JsonSerializer.Serialize(usuario));
        }

        [HttpGet(Name = "Getuser")]
        public async Task<IActionResult> Get(string? id)
        {
            UserModelBasico usuario1 = new Model.UserModelBasico();
            UserModelBasico usuario2 = new Model.UserModelBasico();
            usuario1.Nome = "Fulano";
            usuario1.Login = "Login1";
            usuario1.id_plantacao = 1;
            usuario1.Tipo = 1;
            usuario2.Nome = "Fulano2";
            usuario2.id_plantacao = 1;
            usuario2.Tipo = 2;
            usuario2.Login = "Login2";

            if (id != null)
            {
                return Ok(JsonSerializer.Serialize(usuario1));
            }
            else
            {
                List<UserModelBasico> lista = new List<UserModelBasico>();
                lista.Add(usuario1);
                lista.Add(usuario2);
                return Ok(JsonSerializer.Serialize(lista));
            }

        }

        [HttpPut(Name = "Putuser")]
        public async Task<IActionResult> Modify([FromBody] UserModel usuario)
        {
            UserModelBasico usuario1 = new Model.UserModelBasico();
            usuario1.Nome = usuario.Nome;
            usuario1.Tipo=usuario.Tipo;
            usuario1.Login = usuario.Login;
            usuario1.id_plantacao = usuario.id_plantacao;
            return Ok(JsonSerializer.Serialize(usuario1));
        }

        [HttpDelete(Name = "Deleteuser")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok($"Usuário Fulano deletado com sucesso!");
        }

    }
}
