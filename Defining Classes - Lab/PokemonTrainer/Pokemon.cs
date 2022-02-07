using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Pokemon
    {
        public string PokemonsName { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            this.PokemonsName = name;
            this.Element = element;
            this.Health = health;
        }
    }
}
