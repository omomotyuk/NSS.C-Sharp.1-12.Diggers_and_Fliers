using System;

namespace _1_12.Diggers_and_Fliers
{

    class Fish : ISwimAnimal
    {
        public string Name {get;}

        public Fish( string name )
        {
            Name = name;
        }

        public void Swim()
        {
            Console.WriteLine($"I'm {Name}. I can move and live only in water.");
        }
    }
}