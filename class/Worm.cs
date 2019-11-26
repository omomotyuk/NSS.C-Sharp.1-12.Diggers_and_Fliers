using System;

namespace _1_12.Diggers_and_Fliers
{

    class Worm : ICrawlAnimal, IDigAnimal
    {
        public string Name {get;}

        public Worm( string name )
        {
            Name = name;
        }

        public void Crawl()
        {
            Console.WriteLine($"I'm {Name}. My favorite move style is to crawl.");
        }

        public void Dig()
        {
            Console.WriteLine($"I'm {Name}. I dig the ground a lot!");
        }
    }
}