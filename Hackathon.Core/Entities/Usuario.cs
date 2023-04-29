using Hackathon.Core.Common;

namespace Hackathon.Core.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string ComprovanteResidencia { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Guid EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
