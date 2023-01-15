using Pokemon2022.Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Extensions
{
    public static class StatsExtension
    {
        public static int GetSum(this Stats stat)
        {
            return (int)stat.HP + (int)stat.Attack + (int)stat.Defense + (int)stat.SpecialAttack + (int)stat.SpecialDefense + (int)stat.Speed;
        }
    }
}
