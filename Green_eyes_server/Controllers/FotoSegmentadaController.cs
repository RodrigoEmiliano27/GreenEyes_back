using Green_eyes_server.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Green_eyes_server.Controllers
{
    [ApiController]
    [Route("v1/fotoseg")]
    public class FotoSegmentadaController : ControllerBase
    {

        [HttpPost(Name = "PostfotoSegmentada")]
        public async Task<IActionResult> Create([FromBody] FotoBasicaModel foto)
        {
            return Ok("{\"id\":\"" + foto.id + "\"}");
        }

        [HttpPatch(Name = "PatchfotoSegmentada")]
        public async Task<IActionResult> Segmentar([FromBody] FotoBasicaModel foto)
        {
            return Ok("foto segmentada em 20 fotos");
        }



        [HttpGet(Name = "GetfotoSegmentada")]
        public async Task<IActionResult> Get(string? id_foto_original)
        {

            if (id_foto_original == null)
            {
                return BadRequest($"Foto {id_foto_original.ToString()} não existe");
            }

            List<FotoSegmentadaModel> lista = new List<FotoSegmentadaModel>();

            FotoSegmentadaModel foto1 = new FotoSegmentadaModel();
            FotoSegmentadaModel foto2 = new FotoSegmentadaModel();
            FotoSegmentadaModel foto3 = new FotoSegmentadaModel();

            foto1.link = $"https:://Azure.storage.com?id={foto1.id}";
            foto1.id_foto = "5248e428-43a1-29f2-8774-5f716dc45436";
            foto1.data = DateTime.Now.ToString();
            foto1.versao_segmentador = "1.0";

            foto2.link = $"https:://Azure.storage.com?id={foto2.id}";
            foto2.id_foto = "5248e428-43a1-29f2-8774-5f716dc45436";
            foto2.data = DateTime.Now.ToString();
            foto2.versao_segmentador = "1.0";

            foto3.link = $"https:://Azure.storage.com?id={foto3.id}";
            foto3.id_foto = "5248e428-43a1-29f2-8774-5f716dc45436";
            foto3.data = DateTime.Now.ToString();
            foto3.versao_segmentador = "1.0";


            lista.Add(foto1);
            lista.Add(foto2);
            lista.Add(foto3);

            return Ok(JsonSerializer.Serialize(lista));

        }

        [HttpDelete(Name = "DeletefotoSegmentada")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok($"foto Segmentada {id.ToString()} deletada com sucesso!");
        }
    }
}
