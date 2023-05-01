using Hackathon.Core.Entities;
using Infrastructure.Data.Interfaces;
using Infrastructure.Data.Repositorys;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("midia")]
    public class MidiaController : Controller
    {
        private readonly IMidiaRepository _midiaRepository;

        public MidiaController(IMidiaRepository midiaRepository)
        {
            _midiaRepository = midiaRepository;
        }

        [HttpGet]
        public object Get()
        {
            return _midiaRepository.GetAll();
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            try
            {
                var midia = new Midia();
                JsonConvert.PopulateObject(values, midia);
                _midiaRepository.Add(midia);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao inserir: " + e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(Guid Key, string values)
        {

            var midia = _midiaRepository.GetById(Key);
            JsonConvert.PopulateObject(values, midia);

            try
            {
                _midiaRepository.Update(midia);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest("Erro ao editar: " + e.Message);
            }

        }

        [HttpDelete]
        public IActionResult Delete(Guid Key)
        {
            var midia = _midiaRepository.GetById(Key);
            try
            {
                _midiaRepository.Remove(midia);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest("Erro ao excluir: " + e.Message);

            }
        }
    }
}
