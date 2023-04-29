using Hackathon.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Entities
{
    public class Chat : Entity
    {
        public Guid UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public Guid VeterinarioId { get; set; }
        public virtual Veterinario Veterinario { get; set; }
        public Guid ONGId { get; set; }
        public virtual ONG ONG { get; set; }

        public string Mensagem { get; set; }
    }
}
