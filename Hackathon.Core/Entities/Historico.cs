using Hackathon.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Entities
{
    public class Historico : Entity
    {
        public Guid AnimalId { get; set; }
        public virtual Animal Animal { get; set; }
        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public Guid VeterinarioId { get; set; }
        public virtual Veterinario Veterinario { get; set; }
        public Guid AdaptacaoId { get; set; }
        public virtual Adaptacao Adaptacao { get; set; }
    }
}
