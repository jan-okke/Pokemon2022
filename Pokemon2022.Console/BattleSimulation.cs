using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9290724

namespace Pokemon2022.Console
{
    public class BattleSimulation
    {
        private readonly PokemonParty PlayerParty;
        private readonly PokemonParty EnemyParty;
        private readonly Battle Battle;
        public BattleSimulation(PokemonParty playerParty, PokemonParty enemyParty)
        {
            PlayerParty = playerParty;
            EnemyParty = enemyParty;
            Print("A battle has started!");
            Battle = GameController.StartTrainerBattle(PlayerParty, EnemyParty);
            Start();
        }
        private static void Print(string text, bool newLine=true)
        {
            if (!newLine) { System.Console.Write(text); return; }
            System.Console.WriteLine(text);
        }
        /*private static void Print(Stats stats)
        {
            Print($"HP: {stats.HP} Attack: {stats.Attack} Defense: {stats.Defense} SpecialAttack: {stats.SpecialAttack} SpecialDefense: {stats.SpecialDefense} Speed: {stats.Speed}");
        }
        private static void Print(Move move)
        {
            Print($"Name: {move.Name} Type: {move.MoveType} BasePower: {move.BasePower} Accuracy: {move.Accuracy} PP: {move.PowerPointsLeft}/{move.PowerPoints}");
        }
        private static void Print(List<Move> moves)
        {
            foreach (Move move in moves) Print(move);
        }
        */
        private static void DrawLines(int amount, char letter='=', bool addNewLine=false)
        {
            for (int i = 0; i < amount; i++)
            {
                Print(letter.ToString(), false);
            }
            Print("");
            if (addNewLine) Print("");
        }
        private static string EmptySpaces(int amount)
        {
            string ret = "";
            for (int i = 0; i < amount; i++)
            {
                ret += " ";
            }
            return ret;
        }
        private static void Print(Pokemon pokemon)
        {
            DrawLines(96);
            Print("Name\t\tStatus\t\tLevel\t\tAbility\t\tItem\t\tHP");
            DrawLines(96);
            Print($"{pokemon.Name}{EmptySpaces(16 - pokemon.Name.Length)}{pokemon.Status}{EmptySpaces(16 - pokemon.Status.ToString().Length)}{pokemon.Level}{EmptySpaces(16 - pokemon.Level.ToString().Length)}{pokemon.Ability.Name}{EmptySpaces(16 - pokemon.Ability.Name.Length)}{pokemon.HeldItem.Name}{EmptySpaces(16 - pokemon.HeldItem.Name.Length)}{pokemon.CurrentHP}/{pokemon.Stats.HP}");
            Print("");
            DrawLines(96, addNewLine: true);
        }
        private static void Print(PokemonParty party)
        {
            DrawLines(96);
            Print("Name\t\tStatus\t\tLevel\t\tAbility\t\tItem\t\tHP");
            DrawLines(96);
            foreach (Pokemon pokemon in party.Pokemons)
            {
                Print($"{pokemon.Name}{EmptySpaces(16 - pokemon.Name.Length)}{pokemon.Status}{EmptySpaces(16 - pokemon.Status.ToString().Length)}{pokemon.Level}{EmptySpaces(16 - pokemon.Level.ToString().Length)}{pokemon.Ability.Name}{EmptySpaces(16 - pokemon.Ability.Name.Length)}{pokemon.HeldItem.Name}{EmptySpaces(16 - pokemon.HeldItem.Name.Length)}{pokemon.CurrentHP}/{pokemon.Stats.HP}");
            }
            Print("");
            DrawLines(96, addNewLine: true);
        }
        private static void Print(List<Move> moves)
        {
            DrawLines(96);
            Print("Name\t\tType\t\tCategory\tBase Power\tAccuracy\tPower Points");
            DrawLines(96);
            foreach (Move move in moves)
            {
                Print($"{move.Name}{EmptySpaces(16 - move.Name.Length)}{move.MoveType}{EmptySpaces(16 - move.MoveType.ToString().Length)}{move.Category}{EmptySpaces(16 - move.Category.ToString().Length)}{move.BasePower}{EmptySpaces(16 - move.BasePower.ToString().Length)}{move.Accuracy}{EmptySpaces(16 - move.Accuracy.ToString().Length)}{move.PowerPointsLeft} / {move.PowerPoints}");
            }
            DrawLines(96, addNewLine: true);
        }
        private static void Print(Battle battle)
        {
            Print(battle.PlayerParty);
            Print(battle.EnemyParty);
        }
        private static string Input(string text = ">")
        {
            Print(text, false);
            var temp = System.Console.ReadLine();
            if (temp != null) return temp;
            return string.Empty;
        }
        private static Pokemon? GetPokemonInParty(PokemonParty party, string name)
        {
            foreach (Pokemon p in party.Pokemons)
            {
                if (p.Name == name) return p;
            }
            return null;
        }
        private static Move? GetMoveFromPokemon(Pokemon pokemon, string name)
        {
            foreach (Move m in pokemon.Moves)
            {
                if (m.Name == name) return m;
            }
            return null;
        }
        private void Start()
        {
            while (PlayerParty.IsAlive() && EnemyParty.IsAlive()) 
            {
                string s = Input();
                if (s == "show battle")
                {
                    Print(Battle);
                }
                if (s == "show moves")
                {
                    Print(Battle.PlayerParty.GetFirstAlivePokemon().Moves);
                }
                if (s.Contains("show pokemon "))
                {
                    Pokemon? temp = GetPokemonInParty(PlayerParty, s.Split(new[] { "show pokemon " }, StringSplitOptions.None)[1]);
                    if (temp != null) Print(temp);
                }
                if (s.Contains("use move "))
                {
                    Move? temp = GetMoveFromPokemon(PlayerParty.GetFirstAlivePokemon(), s.Split(new[] { "use move " }, StringSplitOptions.None)[1]);
                    if (temp != null) BattleLogic.BattleTurn(PlayerParty.GetFirstAlivePokemon(), EnemyParty.GetFirstAlivePokemon(), temp, GameController.RandomMove(EnemyParty.GetFirstAlivePokemon()), Battle);
                }
            }
            Print("Battle is over!");
        }
    }
}
