using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Names;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Extensions
{
    public static class ItemExtension
    {
        public static double GetEndOfTurnRestorePercentageValue(this Item item)
        {
            return item.Name switch
            {
                ItemNames.STICKYBARB => - (1.0 / 8),
                ItemNames.LEFTOVERS => 1.0 / 16,
                _ => 0,
            };
        }
    }
}
