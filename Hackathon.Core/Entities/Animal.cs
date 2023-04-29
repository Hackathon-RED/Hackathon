using Hackathon.Core.Common;
using Hackathon.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Entities
{
    public class Animal : Entity
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public Sexo SexoAnimal { get; set; }
        public TipoAnimal Especie { get; set; }
        public PorteAnimal Porte { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Observacao { get; set; }
    }
}
