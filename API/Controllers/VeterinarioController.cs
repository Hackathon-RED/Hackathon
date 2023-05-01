using Hackathon.Core.Entities;
using Infrastructure.Data.Repositorys;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("veterinario")]
    public class VeterinarioController : Controller
    {
        private readonly IVeterinarioRepository _veterinarioRepository;

        public VeterinarioController(IVeterinarioRepository veterinarioRepository)
        {
            _veterinarioRepository = veterinarioRepository;
        }

        [HttpGet]
        public object Get()
        {
            return _veterinarioRepository.GetAll();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post(string values)
        {
            try
            {
                var veterinario = new Veterinario();
                JsonConvert.PopulateObject(values, veterinario);
                _veterinarioRepository.Add(veterinario);
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

            var veterinario = _veterinarioRepository.GetById(Key);
            JsonConvert.PopulateObject(values, veterinario);

            try
            {
                _veterinarioRepository.Update(veterinario);
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
            var veterinario = _veterinarioRepository.GetById(Key);
            try
            {
                _veterinarioRepository.Remove(veterinario);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest("Erro ao excluir: " + e.Message);

            }
        }
    }
}
