using System;

namespace _1_12.Diggers_and_Fliers
{

    class Turtle : ISwimAnimal, IWalkAnimal
    {
        public string Name {get;}
        public int LegNumber {get;}

        public Turtle( string name )
        {
            Name = name;
            LegNumber = 4;
        }

        public void Swim()
        {
            Console.WriteLine($"I'm {Name}. I can swim fast enough.");
        }

        public void Walk()
        {
            Console.WriteLine($"I'm {Name}. I have {LegNumber} legs to walk.");
        }
    }
}