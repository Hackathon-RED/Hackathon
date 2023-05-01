using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Extensions
{
    public class CPF
    {
        private string _value;

        public CPF(string value)
        {
            if (!IsValid(value))
                throw new ArgumentException("CPF inválido");

            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

        public static bool IsValid(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || !long.TryParse(cpf, out long result))
                return false;

            int[] pesos = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += (cpf[i] - '0') * pesos[i];
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            if ((cpf[9] - '0') != digito1)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += (cpf[i] - '0') * pesos[i];
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            if ((cpf[10] - '0') != digito2)
                return false;

            return true;
        }
    }
}
