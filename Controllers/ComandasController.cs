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
        public IActionResult GetAll()
        {
            var result = _comandaRepository.GetAll();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var result = _comandaRepository.GetById(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostComandaRequestDto body)
        {
            var result = _comandaRepository.Post(body);

            return Ok(result);
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
            var result = _comandaRepository.Delete(id);

            if (result)
                return Ok(new
                {
                    success = new { text = "comanda removida" }
                });
            else
                return NotFound();
        }
    }
}
