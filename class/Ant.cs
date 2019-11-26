using System;

namespace _1_12.Diggers_and_Fliers
{

    class Ant : IWalkAnimal, IDigAnimal
    {
        public string Name {get;}
        public int LegNumber {get;}

        public Ant( string name )
        {
            Name = name;
            LegNumber = 6;
        }

        public void Walk()
        {
            Console.WriteLine($"I'm {Name}. I have {LegNumber} legs to walk.");
        }

        public void Dig()
        {
            Console.WriteLine($"I'm {Name}. I dig the ground to build my home.");
        }
    }
}