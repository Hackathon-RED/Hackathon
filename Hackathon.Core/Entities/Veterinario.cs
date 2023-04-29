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
    }
}
