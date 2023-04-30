using Hackathon.Core.Entities;
using Infrastructure.Data.Interfaces;
using Infrastructure.Data.Repositorys;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatRepository _ChatRepository;

        public ChatController(IChatRepository ChatRepository)
        {
            _ChatRepository = ChatRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public object Get()
        {
            return _ChatRepository.GetAll();
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            try
            {
                var chat = new Chat();
                JsonConvert.PopulateObject(values, chat);
                _ChatRepository.Add(chat);
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

            var chat = _ChatRepository.GetById(Key);
            JsonConvert.PopulateObject(values, chat);

            try
            {
                _ChatRepository.Update(chat);
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
            var chat = _ChatRepository.GetById(Key);
            try
            {
                _ChatRepository.Remove(chat);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest("Erro ao excluir: " + e.Message);

            }
        }
    }
}
