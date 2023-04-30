using Hackathon.Core.Entities;
using Infrastructure.Data.Interfaces;
using Infrastructure.Data.Repositorys;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    public class HistoricoController : Controller
    {
        private readonly IHistoricoRepository _historicoRepository;

        public HistoricoController(IHistoricoRepository historicoRepository)
        {
            _historicoRepository = historicoRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object Get()
        {
            return _historicoRepository.GetAll();
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            try
            {
                var historico = new Historico();
                JsonConvert.PopulateObject(values, historico);
                _historicoRepository.Add(historico);
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

            var historico = _historicoRepository.GetById(Key);
            JsonConvert.PopulateObject(values, historico);

            try
            {
                _historicoRepository.Update(historico);
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
            var historico = _historicoRepository.GetById(Key);
            try
            {
                _historicoRepository.Remove(historico);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest("Erro ao excluir: " + e.Message);

            }
        }
    }
}
