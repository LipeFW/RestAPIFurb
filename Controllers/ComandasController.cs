using Microsoft.AspNetCore.Mvc;
using RestAPIFurb.Models.Dto.Comanda;
using RestAPIFurb.Repository.Interface;

namespace RestAPIFurb.Controllers
{
    [ApiController]
    [Route("ApiRESTFurb/[controller]")]
    public class ComandasController : Controller
    {
        private readonly IComandaRepository _comandaRepository;

        public ComandasController(IComandaRepository comandaRepository)
        {
            _comandaRepository = comandaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            var ret = _comandaRepository.GetById(id);

            return Ok(ret);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostComandaBody body)
        {
            var ret = _comandaRepository.Post(body);

            return Ok(ret);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok(new {success = new { text = "comanda removida" }
        });
        }
    }
}
