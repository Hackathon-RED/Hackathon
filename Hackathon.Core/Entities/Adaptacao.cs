using Hackathon.Core.Entities.Common;
using Hackathon.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Core.Entities
{
    public class Adaptacao : Entity
    {
        public DateTime DataFim { get; set; }
        public StatusAdaptacao Status { get; set; }

    }
}
