using Pokemon2022.Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Extensions
{
    public static class MoveExtension
    {
        public static int GetBoostedPP(this Move move)
        {
            return (int)(move.PowerPoints * (1.0 + (move.PowerPointUpsUsed * 0.2)));
        }
        public static void RestorePP(this Move move)
        {
            move.PowerPointsLeft = move.GetBoostedPP();
        }
        public static void RestorePP(this Move move, int amount)
        {
            move.PowerPointsLeft += amount;
            if (move.PowerPointsLeft > move.GetBoostedPP()) move.PowerPointsLeft = move.GetBoostedPP();
        }
        public static bool IsFaster(this Move move, Move otherMove)
        {
            return move.Priority > otherMove.Priority;
        }
    }
}
