using Green_eyes_server.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Green_eyes_server.Controllers
{
    [ApiController]
    [Route("v1/login")]
    public class LoginController:ControllerBase
    {
        [HttpPost(Name = "PostLogin")]
        public async Task<IActionResult> Create([FromBody] LoginAPI login)
        {
            LoginAPIResponse resposta = new LoginAPIResponse();
            resposta.id_usuario = "5248e428-43a1-29f2-8774-5f716dc45436";
            resposta.login = login.login;
            resposta.plantacao = "MVP plantacao";
            resposta.role = "admin";
            resposta.token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
            return Ok(JsonSerializer.Serialize(resposta));
        }

    }
}
