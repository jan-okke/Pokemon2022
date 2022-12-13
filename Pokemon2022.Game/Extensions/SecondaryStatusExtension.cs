using Pokemon2022.Game.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Extensions
{
    public static class SecondaryStatusExtension
    {
        public static double GetDamagePercentageValue(this PokemonStatusSecondary status)
        {
            return status switch
            {
                PokemonStatusSecondary.Confused => 0,
                PokemonStatusSecondary.LeechSeed => 1.0 / 16,
                PokemonStatusSecondary.Trapped => 0,
                _ => throw new ArgumentException("The given status was invalid."),
            };
        }
    }
}
