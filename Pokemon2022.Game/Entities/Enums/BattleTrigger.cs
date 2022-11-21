﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Entities.Enums
{
    public enum BattleTrigger
    {
        None,
        OnSendOut,
        OnDealDamage,
        OnTakeDamage,
        OnFaint
    }
}
