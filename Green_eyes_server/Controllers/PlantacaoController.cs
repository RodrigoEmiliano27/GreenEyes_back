using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Green_eyes_server.Controllers
{
    [ApiController]
    [Route("v1/plant")]
    public class PlantacaoController : ControllerBase
    {
       /* public IActionResult Index()
        {
            return View();
        }*/

        [HttpPost(Name = "Postplant")]
        public async Task<IActionResult> Create([FromBody] Model.PlantacaoModel plantacao)
        {
            return Ok(JsonSerializer.Serialize(plantacao));
        }

        [HttpGet(Name = "Getplant")]
        public async Task<IActionResult> Get(string? id)
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

        [HttpPut(Name = "Putplant")]
        public async Task<IActionResult> Modify([FromBody] Model.PlantacaoModel plantacao)
        {
            return Ok(JsonSerializer.Serialize(plantacao));
        }

        [HttpDelete(Name = "Deleteplant")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok($"plantação {id.ToString()} deletada com sucesso!");
        }
    }
}
