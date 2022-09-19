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

        [HttpGet("/foto-dia",Name = "Getfoto-dia")]
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
        public async Task<IActionResult> Get(string? id, string? dia )
        {
            Model.PlantacaoModel plantacao1 = new Model.PlantacaoModel();
            Model.PlantacaoModel plantacao2 = new Model.PlantacaoModel();
            plantacao1.plantacao = "MVP plantação 1";
            plantacao2.plantacao = "MVP plantação 2";

            if (id != null)
            {
                return Ok(JsonSerializer.Serialize(plantacao1));
            }
            else
            {
                List<Model.PlantacaoModel> lista = new List<Model.PlantacaoModel>();
                lista.Add(plantacao1);
                lista.Add(plantacao2);
                return Ok(JsonSerializer.Serialize(lista));
            }

        }

        [HttpPut(Name = "Putfoto")]
        public async Task<IActionResult> Modify([FromBody] Model.PlantacaoModel plantacao)
        {
            return Ok(JsonSerializer.Serialize(plantacao));
        }

        [HttpDelete(Name = "Deletefoto")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok($"plantação {id.ToString()} deletada com sucesso!");
        }
    }
}
