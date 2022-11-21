using Pokemon2022.Game.Entities;
using Pokemon2022.Game.Entities.Enums;
using Pokemon2022.Game.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pokemon2022.BattleUI
{
    /// <summary>
    /// Interaktionslogik für TeamBuilderUserControl.xaml
    /// </summary>
    public partial class TeamBuilderWindow : Window
    {
        private PokemonParty? CurrentParty;
        private List<PokemonParty> Parties;
        private Pokemon? CurrentPokemon;
        private readonly List<PokemonNature> Natures;
        private int CurrentPartyIndex;
        public TeamBuilderWindow()
        {
            CurrentParty = null;
            Parties = new();
            Natures = new() {
                PokemonNature.None, PokemonNature.Hardy, PokemonNature.Lonely,
                PokemonNature.Brave, PokemonNature.Adamant, PokemonNature.Naughty,
                PokemonNature.Bold, PokemonNature.Docile, PokemonNature.Relaxed,
                PokemonNature.Impish, PokemonNature.Lax, PokemonNature.Timid,
                PokemonNature.Hasty, PokemonNature.Serious, PokemonNature.Jolly,
                PokemonNature.Naive, PokemonNature.Modest, PokemonNature.Mild,
                PokemonNature.Quiet, PokemonNature.Bashful, PokemonNature.Rash,
                PokemonNature.Calm, PokemonNature.Gentle, PokemonNature.Sassy,
                PokemonNature.Careful, PokemonNature.Quirky
            };
            CurrentPokemon = null;
            CurrentPartyIndex = 0;
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            Pokemon1Name.Content = "";
            Pokemon1Ability.Content = "";
            Pokemon1Item.Content = "";
            Pokemon1Move1Name.Content = "";
            Pokemon1Move2Name.Content = "";
            Pokemon1Move3Name.Content = "";
            Pokemon1Move4Name.Content = "";
            Pokemon2Name.Content = "";
            Pokemon2Ability.Content = "";
            Pokemon2Item.Content = "";
            Pokemon2Move1Name.Content = "";
            Pokemon2Move2Name.Content = "";
            Pokemon2Move3Name.Content = "";
            Pokemon2Move4Name.Content = "";
            Pokemon3Name.Content = "";
            Pokemon3Ability.Content = "";
            Pokemon3Item.Content = "";
            Pokemon3Move1Name.Content = "";
            Pokemon3Move2Name.Content = "";
            Pokemon3Move3Name.Content = "";
            Pokemon3Move4Name.Content = "";
            Pokemon4Name.Content = "";
            Pokemon4Ability.Content = "";
            Pokemon4Item.Content = "";
            Pokemon4Move1Name.Content = "";
            Pokemon4Move2Name.Content = "";
            Pokemon4Move3Name.Content = "";
            Pokemon4Move4Name.Content = "";
            Pokemon5Name.Content = "";
            Pokemon5Ability.Content = "";
            Pokemon5Item.Content = "";
            Pokemon5Move1Name.Content = "";
            Pokemon5Move2Name.Content = "";
            Pokemon5Move3Name.Content = "";
            Pokemon5Move4Name.Content = "";
            Pokemon6Name.Content = "";
            Pokemon6Ability.Content = "";
            Pokemon6Item.Content = "";
            Pokemon6Move1Name.Content = "";
            Pokemon6Move2Name.Content = "";
            Pokemon6Move3Name.Content = "";
            Pokemon6Move4Name.Content = "";
        }

        private void InitializeTeam()
        {
            if (CurrentParty is null) return;
            if (CurrentParty.Pokemons.Count == 0) return;
            // Pokemon 1
            Pokemon1Name.Content = CurrentParty.Pokemons[0].Name;
            Pokemon1Ability.Content = CurrentParty.Pokemons[0].Ability;
            Pokemon1Item.Content = CurrentParty.Pokemons[0].HeldItem;
            try { Pokemon1Move1Name.Content = CurrentParty.Pokemons[0].Moves[0]; } catch { }
            try { Pokemon1Move2Name.Content = CurrentParty.Pokemons[0].Moves[1]; } catch { }
            try { Pokemon1Move3Name.Content = CurrentParty.Pokemons[0].Moves[2]; } catch { }
            try { Pokemon1Move4Name.Content = CurrentParty.Pokemons[0].Moves[3]; } catch { }

            if (CurrentParty.Pokemons.Count == 1) return;
            // Pokemon 2
            Pokemon2Name.Content = CurrentParty.Pokemons[1].Name;
            Pokemon2Ability.Content = CurrentParty.Pokemons[1].Ability;
            Pokemon2Item.Content = CurrentParty.Pokemons[1].HeldItem;
            try { Pokemon2Move1Name.Content = CurrentParty.Pokemons[1].Moves[0]; } catch { }
            try { Pokemon2Move2Name.Content = CurrentParty.Pokemons[1].Moves[1]; } catch { }
            try { Pokemon2Move3Name.Content = CurrentParty.Pokemons[1].Moves[2]; } catch { }
            try { Pokemon2Move4Name.Content = CurrentParty.Pokemons[1].Moves[3]; } catch { }

            if (CurrentParty.Pokemons.Count == 2) return;
            // Pokemon 3
            Pokemon3Name.Content = CurrentParty.Pokemons[2].Name;
            Pokemon3Ability.Content = CurrentParty.Pokemons[2].Ability;
            Pokemon3Item.Content = CurrentParty.Pokemons[2].HeldItem;
            try { Pokemon3Move1Name.Content = CurrentParty.Pokemons[2].Moves[0]; } catch { }
            try { Pokemon3Move2Name.Content = CurrentParty.Pokemons[2].Moves[1]; } catch { }
            try { Pokemon3Move3Name.Content = CurrentParty.Pokemons[2].Moves[2]; } catch { }
            try { Pokemon3Move4Name.Content = CurrentParty.Pokemons[2].Moves[3]; } catch { }

            if (CurrentParty.Pokemons.Count == 3) return;
            // Pokemon 4
            Pokemon4Name.Content = CurrentParty.Pokemons[3].Name;
            Pokemon4Ability.Content = CurrentParty.Pokemons[3].Ability;
            Pokemon4Item.Content = CurrentParty.Pokemons[3].HeldItem;
            try { Pokemon4Move1Name.Content = CurrentParty.Pokemons[3].Moves[0]; } catch { }
            try { Pokemon4Move2Name.Content = CurrentParty.Pokemons[3].Moves[1]; } catch { }
            try { Pokemon4Move3Name.Content = CurrentParty.Pokemons[3].Moves[2]; } catch { }
            try { Pokemon4Move4Name.Content = CurrentParty.Pokemons[3].Moves[3]; } catch { }

            if (CurrentParty.Pokemons.Count == 4) return;
            // Pokemon 5
            Pokemon5Name.Content = CurrentParty.Pokemons[4].Name;
            Pokemon5Ability.Content = CurrentParty.Pokemons[4].Ability;
            Pokemon5Item.Content = CurrentParty.Pokemons[4].HeldItem;
            try { Pokemon5Move1Name.Content = CurrentParty.Pokemons[4].Moves[0]; } catch { }
            try { Pokemon5Move2Name.Content = CurrentParty.Pokemons[4].Moves[1]; } catch { }
            try { Pokemon5Move3Name.Content = CurrentParty.Pokemons[4].Moves[2]; } catch { }
            try { Pokemon5Move4Name.Content = CurrentParty.Pokemons[4].Moves[3]; } catch { }

            if (CurrentParty.Pokemons.Count == 5) return;
            // Pokemon 6
            Pokemon6Name.Content = CurrentParty.Pokemons[5].Name;
            Pokemon6Ability.Content = CurrentParty.Pokemons[5].Ability;
            Pokemon6Item.Content = CurrentParty.Pokemons[5].HeldItem;
            try { Pokemon6Move1Name.Content = CurrentParty.Pokemons[5].Moves[0]; } catch { }
            try { Pokemon6Move2Name.Content = CurrentParty.Pokemons[5].Moves[1]; } catch { }
            try { Pokemon6Move3Name.Content = CurrentParty.Pokemons[5].Moves[2]; } catch { }
            try { Pokemon6Move4Name.Content = CurrentParty.Pokemons[5].Moves[3]; } catch { }
        }

        private static int GetPokemonNameIndexFromName(string name)
        {
            int index = 0;
            foreach (Pokemon p in PokemonFactory.Pokemons)
            {
                if (p.Name == name) return index;
                index++;
            }
            return -1;
        }
        private static int GetMoveNameIndexFromName(string name)
        {
            int index = 0;
            foreach (Move p in MoveFactory.Moves)
            {
                if (p.Name == name) return index;
                index++;
            }
            return -1;
        }
        private void FillPokemonData()
        {
            if (CurrentPokemon is null) return;
            SelectedSpecies.ItemsSource = PokemonFactory.Pokemons;
            SelectedSpecies.SelectedIndex = GetPokemonNameIndexFromName(CurrentPokemon.Name);
            SelectedBaseHP.Text = CurrentPokemon.BaseStats.HP.ToString();
            SelectedBaseAtk.Text = CurrentPokemon.BaseStats.Attack.ToString();
            SelectedBaseDef.Text = CurrentPokemon.BaseStats.Defense.ToString();
            SelectedBaseSpAtk.Text = CurrentPokemon.BaseStats.SpecialAttack.ToString();
            SelectedBaseSpDef.Text = CurrentPokemon.BaseStats.SpecialDefense.ToString();
            SelectedBaseSpeed.Text = CurrentPokemon.BaseStats.Speed.ToString();
            SelectedType1.Text = CurrentPokemon.Types[0].ToString();
            try { SelectedType2.Text = CurrentPokemon.Types[1].ToString(); } catch { }
            List<Ability> AvailableAbilities = new();
            foreach (Ability a in CurrentPokemon.AvailableAbilities) AvailableAbilities.Add(a);
            AvailableAbilities.Add(CurrentPokemon.AvailableHiddenAbility);
            SelectedAbility.ItemsSource = AvailableAbilities;
            SelectedAbility.SelectedIndex = 0;
            SelectedItem.ItemsSource = new List<Item>() { }; // TODO ItemFactory woo
            SelectedEVHP.Text = CurrentPokemon.EVs.HP.ToString();
            SelectedEVAtk.Text = CurrentPokemon.EVs.Attack.ToString();
            SelectedEVDef.Text = CurrentPokemon.EVs.Defense.ToString();
            SelectedEVSpAtk.Text = CurrentPokemon.EVs.SpecialAttack.ToString();
            SelectedEVSpDef.Text = CurrentPokemon.EVs.SpecialDefense.ToString();
            SelectedEVSpeed.Text = CurrentPokemon.EVs.Speed.ToString();
            SelectedIVHP.Text = CurrentPokemon.IVs.HP.ToString();
            SelectedIVAtk.Text = CurrentPokemon.IVs.Attack.ToString();
            SelectedIVDef.Text = CurrentPokemon.IVs.Defense.ToString();
            SelectedIVSpAtk.Text = CurrentPokemon.IVs.SpecialAttack.ToString();
            SelectedIVSpDef.Text = CurrentPokemon.IVs.SpecialDefense.ToString();
            SelectedIVSpeed.Text = CurrentPokemon.IVs.Speed.ToString();
            SelectedNature.ItemsSource = Natures;
            SelectedNature.SelectedIndex = 0;
            SelectedMove1.ItemsSource = MoveFactory.Moves;
            try { SelectedMove1.SelectedIndex = GetMoveNameIndexFromName(CurrentPokemon.Moves[0].Name); } catch { SelectedMove1.SelectedIndex = -1; }
            SelectedMove2.ItemsSource = MoveFactory.Moves;
            try { SelectedMove2.SelectedIndex = GetMoveNameIndexFromName(CurrentPokemon.Moves[1].Name); } catch { SelectedMove2.SelectedIndex = -1; }
            SelectedMove3.ItemsSource = MoveFactory.Moves;
            try { SelectedMove3.SelectedIndex = GetMoveNameIndexFromName(CurrentPokemon.Moves[2].Name); } catch { SelectedMove3.SelectedIndex = -1; }
            SelectedMove4.ItemsSource = MoveFactory.Moves;
            try { SelectedMove4.SelectedIndex = GetMoveNameIndexFromName(CurrentPokemon.Moves[3].Name); } catch { SelectedMove4.SelectedIndex = -1; }
        }
        private void AddTeam(object sender, RoutedEventArgs e)
        {
            Parties.Add(new() { Pokemons = new() { PokemonFactory.Charmander.Clone() } });
            TeamListBox.ItemsSource = null;
            TeamListBox.ItemsSource = Parties;
        }

        private void SelectTeam(object sender, SelectionChangedEventArgs e)
        {
            CurrentParty = TeamListBox.SelectedItem as PokemonParty;
            if (CurrentParty is null) return;
            // Initialize Pokemon Data
            InitializeTeam();
        }

        private void EditPokemon1(object sender, RoutedEventArgs e)
        {
            if (CurrentParty is null) return;
            if (CurrentParty.Pokemons.Count == 0) CurrentParty.Pokemons.Add(PokemonFactory.Bulbasaur.Clone());
            CurrentPokemon = CurrentParty.Pokemons[0];
            CurrentPartyIndex = 0;
            FillPokemonData();
        }

        private void EditPokemon2(object sender, RoutedEventArgs e)
        {

            if (CurrentParty is null) return;
            if (CurrentParty.Pokemons.Count == 1) CurrentParty.Pokemons.Add(PokemonFactory.Bulbasaur.Clone());
            CurrentPokemon = CurrentParty.Pokemons[1];
            CurrentPartyIndex = 1;
            FillPokemonData();
        }

        private void EditPokemon3(object sender, RoutedEventArgs e)
        {

            if (CurrentParty is null) return;
            if (CurrentParty.Pokemons.Count == 2) CurrentParty.Pokemons.Add(PokemonFactory.Bulbasaur.Clone());
            CurrentPokemon = CurrentParty.Pokemons[2];
            CurrentPartyIndex = 2;
            FillPokemonData();
        }

        private void EditPokemon4(object sender, RoutedEventArgs e)
        {

            if (CurrentParty is null) return;
            if (CurrentParty.Pokemons.Count == 3) CurrentParty.Pokemons.Add(PokemonFactory.Bulbasaur.Clone());
            CurrentPokemon = CurrentParty.Pokemons[3];
            CurrentPartyIndex = 3;
            FillPokemonData();
        }

        private void EditPokemon5(object sender, RoutedEventArgs e)
        {

            if (CurrentParty is null) return;
            if (CurrentParty.Pokemons.Count == 4) CurrentParty.Pokemons.Add(PokemonFactory.Bulbasaur.Clone());
            CurrentPokemon = CurrentParty.Pokemons[4];
            CurrentPartyIndex = 4;
            FillPokemonData();
        }

        private void EditPokemon6(object sender, RoutedEventArgs e)
        {

            if (CurrentParty is null) return;
            if (CurrentParty.Pokemons.Count == 5) CurrentParty.Pokemons.Add(PokemonFactory.Bulbasaur.Clone());
            CurrentPokemon = CurrentParty.Pokemons[5];
            CurrentPartyIndex = 5;
            FillPokemonData();
        }

        private void ApplyChanges(object sender, RoutedEventArgs e)
        {
            if (CurrentParty is null) return;
            if (CurrentPokemon is null) return;
            if (SelectedAbility.SelectedItem is Ability ability) CurrentPokemon.Ability = ability;
            if (SelectedItem.SelectedItem is Item item) CurrentPokemon.HeldItem = item;
            CurrentPokemon.Level = Convert.ToInt32(SelectedLevel.Text);
            CurrentPokemon.EVs.HP = Convert.ToInt32(SelectedEVHP.Text);
            CurrentPokemon.EVs.Attack = Convert.ToInt32(SelectedEVAtk.Text);
            CurrentPokemon.EVs.Defense = Convert.ToInt32(SelectedEVDef.Text);
            CurrentPokemon.EVs.SpecialAttack = Convert.ToInt32(SelectedEVSpAtk.Text);
            CurrentPokemon.EVs.SpecialDefense = Convert.ToInt32(SelectedEVSpDef.Text);
            CurrentPokemon.EVs.Speed = Convert.ToInt32(SelectedEVSpeed.Text);
            CurrentPokemon.IVs.HP = Convert.ToInt32(SelectedIVHP.Text);
            CurrentPokemon.IVs.Attack = Convert.ToInt32(SelectedIVAtk.Text);
            CurrentPokemon.IVs.Defense = Convert.ToInt32(SelectedIVDef.Text);
            CurrentPokemon.IVs.SpecialAttack = Convert.ToInt32(SelectedIVSpAtk.Text);
            CurrentPokemon.IVs.SpecialDefense = Convert.ToInt32(SelectedIVSpDef.Text);
            CurrentPokemon.IVs.Speed = Convert.ToInt32(SelectedIVSpeed.Text);
            CurrentParty.Pokemons[CurrentPartyIndex] = CurrentPokemon.Clone();
            if (SelectedNature.SelectedItem is PokemonNature nature) CurrentPokemon.Nature = nature;
            if (SelectedMove1.SelectedItem is Move move1) CurrentPokemon.Moves[0] = move1;
            if (SelectedMove2.SelectedItem is Move move2) CurrentPokemon.Moves[1] = move2;
            if (SelectedMove3.SelectedItem is Move move3) CurrentPokemon.Moves[2] = move3;
            if (SelectedMove4.SelectedItem is Move move4) CurrentPokemon.Moves[3] = move4;
        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }

        private void SelectOtherSpecies(object sender, SelectionChangedEventArgs e)
        {
            CurrentPokemon = SelectedSpecies.SelectedItem as Pokemon;
            if (CurrentPokemon is null) return;
            FillPokemonData();
        }
    }
}
