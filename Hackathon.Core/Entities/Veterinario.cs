using Hackathon.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Entities
{
    public class Veterinario : Entity
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CFMV { get; set; }
        public string Especialidade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Documento { get; set; }
        public Midia ComprovanteResidencia { get; set; }
        public string Endereco { get; set; }
    }
}
