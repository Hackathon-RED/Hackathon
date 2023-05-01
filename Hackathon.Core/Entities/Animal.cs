using Hackathon.Core.Entities.Common;
using Hackathon.Core.Enums;

namespace Hackathon.Core.Entities
{
    public class Animal : Entity
    {
        #region -> Propriedades
        public string Nome { get; set; }
        public string Raca { get; set; }
        public Sexo SexoAnimal { get; set; }
        public Guid? EspecieId { get; set; }
        public PorteAnimal Porte { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Observacao { get; set; }
        #endregion

        #region -> Relacionamentos
        public virtual Especie Especie { get; set; }
        #endregion
    }
}
