using Hackathon.Core.Entities.Common;
using System.Text.RegularExpressions;

namespace Hackathon.Core.Entities
{
    public class Endereco : Entity
    {
        public Endereco(string rua, string cidade, string estado, string cep)
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public bool IsValid()
        {
            // Verifica se o CEP está no formato correto
            if (string.IsNullOrEmpty(Cep) || !Regex.IsMatch(Cep, @"\d{5}-\d{3}"))
                return false;

            // Verifica se a rua/caminho está preenchida
            if (string.IsNullOrEmpty(Rua))
                return false;

            // Verifica se a cidade está preenchida
            if (string.IsNullOrEmpty(Cidade))
                return false;

            // Verifica se o estado/região/estado está preenchido
            if (string.IsNullOrEmpty(Estado))
                return false;

            return true;
        }
    }
}
