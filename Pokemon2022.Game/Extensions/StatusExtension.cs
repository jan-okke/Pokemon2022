using Pokemon2022.Game.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Extensions
{
    public static class StatusExtension
    {
        public static double GetDamagePercentageValue(this PokemonStatus status, int statusTurn)
        {
            return status switch
            {
                PokemonStatus.None => 0,
                PokemonStatus.Paralyzed => 0,
                PokemonStatus.Poisoned => 1.0 / 8,
                PokemonStatus.BadlyPoisoned => (1.0 + statusTurn) / 16,
                PokemonStatus.Burned => 1.0 / 16,
                PokemonStatus.Frozen => 0,
                PokemonStatus.Sleeping => 0,
                _ => throw new ArgumentException("The given status was invalid.")
            };
        }
    }
}
