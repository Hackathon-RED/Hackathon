using Hackathon.Core.Entities;
using Infrastructure.Data.Context;
using Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositorys
{
    public class AnimalRepository : Repository<Animal>, IAnimalRepository
    {
        public AnimalRepository(DataContext dbContext) : base(dbContext)
        {

        }
    }
}
