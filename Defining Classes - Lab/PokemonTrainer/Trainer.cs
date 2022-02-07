using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public string TrainerName { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            this.TrainerName = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }
    }
}
