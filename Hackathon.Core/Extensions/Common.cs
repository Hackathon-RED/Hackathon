using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Extensions
{
    public static class Common
    {
        public static async Task<bool> ValidaCPF(string cpf)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // consulta o banco de dados da Receita Federal do Brasil.
                    var response = await client.GetAsync($"https://www.receitaws.com.br/api-cpf/{cpf}");

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                // Caso ocorra algum erro na requisição à API, retorna falso.
                return false;
            }
        }
    }
}
