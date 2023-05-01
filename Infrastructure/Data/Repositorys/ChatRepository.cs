﻿using Hackathon.Core.Entities;
using HappyPet.Infrastructure.Data.Repositorys.Common;
using Infrastructure.Data.Context;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositorys
{
    public class ChatRepository : Repository<Chat>, IChatRepository
    {
        public ChatRepository(DataContext dbContext) : base(dbContext)
        {

        }
    }
}
