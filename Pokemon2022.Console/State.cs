using Pokemon2022.Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon2022.Console
{
    public class State
    {
        public Pokemon PlayerPokemon;
        public Pokemon OpponentPokemon;
        public Battle Battle;
        public Move AttackerMove;
        public Move OpponentMove;
        public int Index;

        public State(Pokemon playerPokemon, Pokemon opponentPokemon, Battle battle, Move attackerMove, Move opponentMove, int index)
        {
            PlayerPokemon = playerPokemon;
            OpponentPokemon = opponentPokemon;
            Battle = battle;
            AttackerMove = attackerMove;
            OpponentMove = opponentMove;
            Index = index;
        }
    }
}
