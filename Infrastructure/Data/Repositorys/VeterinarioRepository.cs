using Hackathon.Core.Entities;
using Infrastructure.Data.Context;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositorys
{
    public class VeterinarioRepository : Repository<Veterinario>, IVeterinarioRepository
    {
        public VeterinarioRepository(DataContext dbContext) : base(dbContext)
        {

        }


        public async Task<bool> VerificaCFMVA(string cfmv)
        {
            using (var client = new HttpClient())
            {
                //Verica a API Oficial do governo de Conselho Federal de Medicina Veterinária
                var response = await client.GetAsync($"https://sicv.cfmv.gov.br/api/{cfmv}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }

    }
}
