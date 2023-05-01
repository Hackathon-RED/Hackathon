using Hackathon.Core.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hackathon.Core.Entities
{
    public class VeterinarioEndereco : Entity
    {
        [ForeignKey("Endereco")]
        public Guid EnderecoId { get; set; }
        [ForeignKey("Veterinario")]
        public Guid VeterinarioId { get; set; }
    }
}
