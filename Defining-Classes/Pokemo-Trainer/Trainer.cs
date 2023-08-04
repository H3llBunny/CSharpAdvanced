using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    internal class Trainer
    {
        public Trainer(string name, int numberOfBadges, List<Pokemon> pokemonCollection)
        {
            Name = name;
            NumberOfBadges = numberOfBadges;
            PokemonCollection = pokemonCollection;
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> PokemonCollection { get; set; }
    }
}
