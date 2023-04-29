using Hackathon.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Entities
{
    public class ONG : Entity
    {
        public string Nome { get; set; }
        public string Fundacao { get; set;}
        public Guid EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public Guid AnimalId { get; set; }
        public virtual Animal Animal { get; set; }
        public Guid VeterinarioId { get; set; }
        public virtual Veterinario Veterinario { get; set; }
    }
}
