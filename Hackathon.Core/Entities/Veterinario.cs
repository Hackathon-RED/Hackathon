using Hackathon.Core.Entities.Common;
using Hackathon.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Entities
{
    public class Veterinario : Entity
    {
        #region -> Propriedades
        public string Nome { get; set; }
        public string CFMV { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Especialidade { get; set; }
        public Email Email { get; set; }
        public string Telefone { get; set; }
        public Guid DocumentoId { get; set; }
        public Guid ComprovanteResendenciaId { get; set; }
        #endregion

        #region -> Relacionamentos
        public virtual Midia Documento { get; set; }
        public virtual Midia ComprovanteResidencia { get; set; }
        #endregion

        #region -> Métodos
        public static bool ValidarRegistroCFMV(string registro)
        {
            // Verificar se o número de registro tem 9 dígitos
            if (registro.Length != 9)
                return false;

            // Verificar se os dois primeiros dígitos correspondem a uma unidade federativa válida
            string uf = registro.Substring(0, 2);
            if (!UnidadesFederativas.ContainsKey(uf))
                return false;

            // Calcular o dígito verificador do número de registro
            int soma = 0;
            for (int i = 0; i < registro.Length - 1; i++)
            {
                int digito = int.Parse(registro[i].ToString());
                soma += digito * (10 - i);
            }
            int resto = soma % 11;
            int dv = resto < 2 ? 0 : 11 - resto;

            // Verificar se o último dígito do número de registro é igual ao dígito verificador calculado
            int ultimoDigito = int.Parse(registro[8].ToString());
            return ultimoDigito == dv;
        }

        // Dicionário de unidades federativas válidas
        private static readonly Dictionary<string, string> UnidadesFederativas = new Dictionary<string, string>
        {
            {"AC", "Acre"},
            {"AL", "Alagoas"},
            {"AP", "Amapá"},
            {"AM", "Amazonas"},
            {"BA", "Bahia"},
            {"CE", "Ceará"},
            {"DF", "Distrito Federal"},
            {"ES", "Espírito Santo"},
            {"GO", "Goiás"},
            {"MA", "Maranhão"},
            {"MT", "Mato Grosso"},
            {"MS", "Mato Grosso do Sul"},
            {"MG", "Minas Gerais"},
            {"PA", "Pará"},
            {"PB", "Paraíba"},
            {"PR", "Paraná"},
            {"PE", "Pernambuco"},
            {"PI", "Piauí"},
            {"RJ", "Rio de Janeiro"},
            {"RN", "Rio Grande do Norte"},
            {"RS", "Rio Grande do Sul"},
            {"RO", "Rondônia"},
            {"RR", "Roraima"},
            {"Santa Catarina", "SC"},
            {"São Paulo", "SP"},
            {"Sergipe", "SE"},
            {"Tocantins", "TO"}
        };
        #endregion
    }
}
