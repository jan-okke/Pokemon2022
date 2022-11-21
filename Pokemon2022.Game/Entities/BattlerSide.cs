using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities
{
    public class BattlerSide
    {
        public bool HasReflect;
        public int ReflectTurns;
        public bool HasLightScreen;
        public int LightScreenTurns;
        public bool HasAuroraVeil;
        public int AuroraVeilTurns;
        public bool HasMudSport;
        public bool HasWaterSport;
        public BattlerSide()
        {
            HasReflect = false;
            ReflectTurns = 0;
            HasLightScreen = false;
            LightScreenTurns = 0;
            HasAuroraVeil = false;
            AuroraVeilTurns = 0;
            HasMudSport = false;
            HasWaterSport = false;
        }
    }
}
