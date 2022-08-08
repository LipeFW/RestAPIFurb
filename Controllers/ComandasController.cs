using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestAPIFurb.Models.Dto.Comanda.Post;
using RestAPIFurb.Models.Dto.Comanda.Put;
using RestAPIFurb.Repository.Interface;

namespace RestAPIFurb.Controllers
{
    [Route("ApiRESTFurb/[controller]")]
    [ApiController]
    public class ComandasController : ControllerBase
    {
        private readonly IComandaRepository _comandaRepository;

        public ComandasController(IComandaRepository comandaRepository)
        {
            _comandaRepository = comandaRepository;
        }

        [Authorize]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var result = _comandaRepository.GetAll();

            return Ok(result);
        }

        [Authorize]
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            var result = _comandaRepository.GetById(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [Authorize]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Post([FromBody] PostComandaRequestDto body)
        {
            if (!body.IsValid())
                return BadRequest(new { status = "Error", detalhes = "Há campos faltando ou inválidos na requisição" });

            var result = _comandaRepository.Post(body);

            if (result.StatusCode.Equals(StatusCodes.Status200OK))
                return Ok(result.Result);
            else
                return BadRequest();
        }

        [Authorize]
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put([FromRoute] int id, [FromBody] PutComandaRequestDto body)
        {
            if (!body.IsValid())
                return BadRequest(new { status = "Error", detalhes = "Há campos faltando ou inválidos na requisição" });

            var result = _comandaRepository.Put(id, body);

            if (!result)
                return BadRequest();
            else
                return Ok();
        }

        [Authorize]
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
