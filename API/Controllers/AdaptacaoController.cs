using Hackathon.Core.Entities;
using Infrastructure.Data.Repositorys;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("adaptacao")]
    public class AdaptacaoController : Controller
    {
        private readonly IAdaptacaoRepository _adaptacaoRepository;

        public AdaptacaoController(IAdaptacaoRepository adaptacaoRepository)
        {
            _adaptacaoRepository = adaptacaoRepository;
        }

        [HttpGet]
        [Route("/adaptacao/buscar")]
        public object Get()
        {
            return _adaptacaoRepository.GetAll();
        }

        [HttpPost]
        [Route("/adaptacao/inserir")]
        public IActionResult Post(string values)
        {
            try
            {
                var adaptacao = new Adaptacao();
                JsonConvert.PopulateObject(values, adaptacao);
                _adaptacaoRepository.Add(adaptacao);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Erro ao inserir: " + e.Message);
            }
        }

        [HttpPut]
        [Route("/adaptacao/atualizar/:id")]
        public IActionResult Put(Guid Key, string values)
        {

            var adaptacao = _adaptacaoRepository.GetById(Key);
            JsonConvert.PopulateObject(values, adaptacao);

            try
            {
                _adaptacaoRepository.Update(adaptacao);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest("Erro ao editar: " + e.Message);
            }

        }

        [HttpDelete]
        [Route("/adaptacao/deletar")]
        public IActionResult Delete(Guid Key)
        {
            var adaptacao = _adaptacaoRepository.GetById(Key);
            try
            {
                _adaptacaoRepository.Remove(adaptacao);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest("Erro ao excluir: " + e.Message);

            }
        }
    }
}
