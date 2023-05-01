using Hackathon.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Entities
{
    public class VeterinarioEspecialidade : Entity
    {
        [ForeignKey("Especialidade")]
        public Guid EspecialidadeId { get; set; }
        [ForeignKey("Veterinario")]
        public Guid VeterinarioId { get; set; }
    }
}
