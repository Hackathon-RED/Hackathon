using Hackathon.Core.Entities;
using Infrastructure.Data.Repositorys;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("animal")]
    public class AnimalController : Controller
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalController(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object Get()
        {
            return _animalRepository.GetAll();
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            try
            {
                var animal = new Animal();
                JsonConvert.PopulateObject(values, animal);
                _animalRepository.Add(animal);
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

            var animal = _animalRepository.GetById(Key);
            JsonConvert.PopulateObject(values, animal);

            try
            {
                _animalRepository.Update(animal);
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
            var animal = _animalRepository.GetById(Key);
            try
            {
                _animalRepository.Remove(animal);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest("Erro ao excluir: " + e.Message);

            }
        }
    }
}
