using Hackathon.Core.Entities;
using Infrastructure.Data.Repositorys;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("chat")]
    public class ChatController : Controller
    {
        private readonly IChatRepository _ChatRepository;

        public ChatController(IChatRepository ChatRepository)
        {
            _ChatRepository = ChatRepository;
        }

        [HttpGet]
        [Route("/chat/buscar")]
        public object Get()
        {
            return _ChatRepository.GetAll();
        }

        [HttpPost]
        [Route("/chat/inserir")]
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
        [Route("/chat/atualizar/:id")]
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
        [Route("/chat/deletar")]
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
