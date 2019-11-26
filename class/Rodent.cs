using System;

namespace _1_12.Diggers_and_Fliers
{

    class Rodent : IWalkAnimal
    {
        public string Name {get;}
        public int LegNumber {get;}

        public Rodent( string name )
        {
            Name = name;
            LegNumber = 4;
        }

        public void Walk()
        {
            Console.WriteLine($"I'm {Name}. I have {LegNumber} legs to walk.");
        }
    }
}