using Hackathon.Core.Entities.Common;
using Hackathon.Core.Extensions;
using Hackathon.Core.ValueObjects;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hackathon.Core.Entities
{
    public class Usuario : Entity
    {
        #region -> Propriedades
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Rg { get; set; }
        public CPF Cpf { get; set; }
        public Email Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public DateTime? DataNascimento { get; set; }
        #endregion

        #region -> Relacionamento
        public Guid ComprovanteResidenciaId { get; set; }
        public virtual Midia ComprovanteResidencia { get; set; }
        [ForeignKey("Endereco")]
        public Guid EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        #endregion
    }
}
