using Pokemon2022.Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Game.Logic
{
    public class TextHelper
    {
        public static List<string> GetMoveUseString(Pokemon attacker, Pokemon defender, bool wildBattle, Move move, double effectivity, bool moveFailed, bool moveMissed, bool fainted)
        {
            List<string> strings = new();
            strings.Add($"{attacker.Name} used {move.Name}!");
            if (moveFailed)
            {
                strings.Add("But it failed!");
                return strings;
            }
            if (moveMissed)
            {
                if (wildBattle) strings.Add($"The wild {defender.Name} evaded the attack!");
                else strings.Add($"The opposing {defender.Name} evaded the attack!");
                return strings;
            }
            if (effectivity == 0)
            {
                if (wildBattle) strings.Add($"It had no effect on the wild {defender.Name}...");
                else strings.Add($"It had no effect on the opposing {defender.Name}...");
                return strings;
            }
            if (effectivity < 1)
            {
                strings.Add("It's not very effective...");
                if (fainted)
                {
                    if (wildBattle) strings.Add($"The wild {defender.Name} fainted!");
                    else strings.Add($"The opposing {defender.Name} fainted!");
                }
                return strings;
            }
            if (effectivity > 1)
            {
                strings.Add("It's super effective!");
                if (fainted)
                {
                    if (wildBattle) strings.Add($"The wild {defender.Name} fainted!");
                    else strings.Add($"The opposing {defender.Name} fainted!");
                }
                return strings;
            }

            if (fainted)
            {
                if (wildBattle) strings.Add($"The wild {defender.Name} fainted!");
                else strings.Add($"The opposing {defender.Name} fainted!");
            }
            return strings;
        }
    }
}
