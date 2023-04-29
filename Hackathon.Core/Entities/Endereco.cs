using Hackathon.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Entities
{
    public class Endereco : Entity
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public Endereco(string rua, string cidade, string estado, string cep)
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public override string ToString()
        {
            return $"{Rua}, {Cidade}, {Estado}, {Cep}";
        }
    }
}
