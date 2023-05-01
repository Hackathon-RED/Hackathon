using Hackathon.Core.Entities.Common;
using Hackathon.Core.Enums;

namespace Hackathon.Core.Entities
{
    public class Especie : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public TipoAnimal Tipo { get; set; }
    }
}
