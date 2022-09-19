using Green_eyes_server.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Green_eyes_server.Controllers
{
    [ApiController]
    [Route("v1/foto")]
    public class FotoController: ControllerBase
    {

        [HttpPost(Name = "Postfoto")]
        public async Task<IActionResult> Create([FromBody] FotoBasicaModel foto)
        {
            return Ok("{\"id\":\""+foto.id+"\"}");
        }

        [HttpGet("foto-dia")]
        public async Task<IActionResult> GetDia(string data)
        {
            DateTime data_atual;
            List<FotoModel> lista = new List<FotoModel>();

            FotoModel foto1 = new FotoModel();
            FotoModel foto2 = new FotoModel();
            FotoModel foto3 = new FotoModel();

            foto1.link = $"https:://Azure.storage.com?id={foto1.id}";
            
            foto1.id_usuario = "5248e428-43a1-29f2-8774-5f716dc45436";

            foto2.link = $"https:://Azure.storage.com?id={foto2.id}";
            
            foto2.id_usuario = "5248e428-43a1-29f2-8774-5f716dc45436";

            foto3.link = $"https:://Azure.storage.com?id={foto3.id}";
            
            foto3.id_usuario = "5248e428-43a1-29f2-8774-5f716dc45436";

            try
            {
                data_atual = Convert.ToDateTime(data);
                foto1.data = data_atual;
                foto2.data = data_atual;
                foto3.data = data_atual;
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }

            lista.Add(foto1);
            lista.Add(foto2);
            lista.Add(foto3);


            return Ok(JsonSerializer.Serialize(lista));
        }




        [HttpGet(Name = "Getfoto")]
        public async Task<IActionResult> Get(string? id)
        {
            
           

            FotoModel foto1 = new FotoModel();


            foto1.link = $"https:://Azure.storage.com?id={foto1.id}";

            foto1.data = DateTime.Now;

            foto1.id_usuario = "5248e428-43a1-29f2-8774-5f716dc45436";


            if (id != null)
            {
                return Ok(JsonSerializer.Serialize(foto1));
            }
            else
            {
                List<FotoModel> lista = new List<FotoModel>();
                FotoModel foto2 = new FotoModel();
                FotoModel foto3 = new FotoModel();

                foto2.link = $"https:://Azure.storage.com?id={foto2.id}";

                foto2.id_usuario = "5248e428-43a1-29f2-8774-5f716dc45436";

                foto2.data = DateTime.Now;

                foto3.link = $"https:://Azure.storage.com?id={foto3.id}";

                foto3.id_usuario = "5248e428-43a1-29f2-8774-5f716dc45436";

                foto3.data = DateTime.Now;

                lista.Add(foto1);
                lista.Add(foto2);
                lista.Add(foto3);
                return Ok(JsonSerializer.Serialize(lista));
            }

        }

        [HttpDelete(Name = "Deletefoto")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok($"foto {id.ToString()} deletada com sucesso!");
        }
    }
}
