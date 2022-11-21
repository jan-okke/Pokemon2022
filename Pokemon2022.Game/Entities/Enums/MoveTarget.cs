using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities.Enums
{
    public enum MoveTarget
    {
        // https://essentialsdocs.fandom.com/wiki/Defining_a_move
        None,
        User,
        NearAlly,
        UserOrNearAlly,
        AllAllies,
        UserAndAllies,
        NearFoe,
        RandomNearFoe,
        AllNearFoes,
        Foe,
        AllFoes,
        NearOther,
        AllNearOthers,
        Other,
        AllBattlers,
        UserSide,
        FoeSide,
        BothSides
    }
}
