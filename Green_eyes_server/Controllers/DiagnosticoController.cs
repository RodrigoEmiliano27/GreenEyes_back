using Green_eyes_server.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Green_eyes_server.Controllers
{
    [ApiController]
    [Route("v1/diag")]
    public class DiagnosticoController : ControllerBase
    {

     
        [HttpGet(Name = "Getdiagnostico")]
        public async Task<IActionResult> Get(string? id_foto_segmentada)
        {
            if (id_foto_segmentada == null)
            {
                return BadRequest($"Foto {id_foto_segmentada.ToString()} não existe");
            }

            DiagnosticoModel diag1 = new DiagnosticoModel();

            diag1.id_foto_segmentada = id_foto_segmentada;
            diag1.grau_certeza = 0.38;
            diag1.classificacao_Azure = "Lagarta";
            diag1.classificacao_final = "sem classificação";
            diag1.data = DateTime.Now.ToString();


            return Ok(JsonSerializer.Serialize(diag1));

        }

        [HttpDelete(Name = "Deletediagnostico")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok($"diagnostico {id.ToString()} deletado com sucesso!");
        }
    }
}
