using System;
using System.Collections.Generic;
using System.Text;

namespace Tuples
{
    public class Threeple<TheRock, JohnCena, BateBoyko>
    {
        public Threeple(TheRock theBeast, JohnCena thedancer, BateBoyko theBoss)
        {
            TheBeast = theBeast;
            TheDancer = thedancer;
            TheBoss = theBoss;
        }

        public TheRock TheBeast { get; set; }
        public JohnCena TheDancer { get; set; }
        public BateBoyko TheBoss { get; set; }

        public string GetItems()
        {
            return $"{TheBeast} -> {TheDancer} -> {TheBoss}";
        }
    }
}
