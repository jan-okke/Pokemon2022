using Pokemon2022.Game.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities
{
    public class Move
    {
        public string Name;
        public string Description;
        public int BasePower;
        public double Accuracy;
        public int Priority;
        public PokemonType MoveType;
        public MoveCategory Category;
        public int PowerPoints;

        public MoveTarget Target;
        public bool IsContactMove;
        public bool IsSoundMove;
        public bool IsRecoilMove;
        public bool IsPunchingMove;
        public bool IsBitingMove;
        public bool IsAuraMove;
        public bool IsPulseMove;
        public bool IsBombMove;
        public bool IsPowderMove;
        public bool IsDanceMove;

        public bool TramplesMinimize;
        public bool HasHighCritRate;

        public int PowerPointUpsUsed;
        public int PowerPointsLeft;

        public Move()
        {
            Name = "";
            Description = "";
            PowerPointUpsUsed = 0;

            BasePower = 0;
            Priority = 0;

            IsContactMove = false;
            IsSoundMove = false;
            IsRecoilMove = false;
            IsPunchingMove = false;
            IsBitingMove = false;
            IsAuraMove = false;
            IsPulseMove = false;
            IsBombMove = false;
            IsPowderMove = false;
            IsDanceMove = false;

            TramplesMinimize = false;
            HasHighCritRate = false;
        }

        public Move Clone()
        {
            Move clone = new()
            {
                Name = Name,
                Description = Description,
                BasePower = BasePower,
                Accuracy = Accuracy,
                Priority = Priority,
                MoveType = MoveType,
                Category = Category,
                PowerPoints = PowerPoints,

                Target = Target,
                IsContactMove = IsContactMove,
                IsSoundMove = IsSoundMove,
                IsRecoilMove = IsRecoilMove,
                IsPunchingMove = IsPunchingMove,
                IsBitingMove = IsBitingMove,
                IsAuraMove = IsAuraMove,
                IsPulseMove = IsPulseMove,
                IsBombMove = IsBombMove,
                IsPowderMove = IsPowderMove,
                IsDanceMove = IsDanceMove,

                TramplesMinimize = TramplesMinimize,
                HasHighCritRate = HasHighCritRate,

                PowerPointUpsUsed = PowerPointUpsUsed,
                PowerPointsLeft = PowerPointsLeft,
            };
            return clone;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
