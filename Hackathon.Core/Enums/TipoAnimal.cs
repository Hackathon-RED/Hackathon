using System.ComponentModel;

namespace Hackathon.Core.Enums
{
    public enum TipoAnimal
    {
        [Description("Herbívoro")]
        Herbivoro = 0,
        [Description("Carnívoro")]
        Carnivoro = 1,
        [Description("Onívoro")]
        Onivoro = 2
    }
}
