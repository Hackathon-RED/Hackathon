using Hackathon.Core.Entities;
using Infrastructure.Data.Repositorys;
using Infrastructure.Interfaces;
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
        [Route("/midia/buscar")]
        public object Get()
        {
            return _midiaRepository.GetAll();
        }

        [HttpPost]
        [Route("/midia/inserir")]
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
        [Route("/midia/atualizar/:id")]
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
        [Route("/midia/deletar")]
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
