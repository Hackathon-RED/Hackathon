using Hackathon.Core.Entities;
using Infrastructure.Data.Interfaces;
using Infrastructure.Data.Repositorys;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    public class AdaptacaoController : Controller
    {
        private readonly IAdaptacaoRepository _adaptacaoRepository;

        public AdaptacaoController(IAdaptacaoRepository adaptacaoRepository)
        {
            _adaptacaoRepository = adaptacaoRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object Get()
        {
            return _adaptacaoRepository.GetAll();
        }

        [HttpPost]
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
