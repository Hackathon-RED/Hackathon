using Hackathon.Core.Entities;
using Infrastructure.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    public class ONGController : Controller
    {
        private readonly IONGRepository _ONGRepository;

        public ONGController(IONGRepository ONGRepository)
        {
            _ONGRepository = ONGRepository;
        }

        [HttpGet]
        public object Get()
        {
            return _ONGRepository.GetAll();
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            try
            {
                var ong = new ONG();
                JsonConvert.PopulateObject(values, ong);
                _ONGRepository.Add(ong);
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

            var ong = _ONGRepository.GetById(Key);
            JsonConvert.PopulateObject(values, ong);

            try
            {
                _ONGRepository.Update(ong);
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
            var ong = _ONGRepository.GetById(Key);
            try
            {
                _ONGRepository.Remove(ong);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest("Erro ao excluir: " + e.Message);

            }
        }
    }
}
