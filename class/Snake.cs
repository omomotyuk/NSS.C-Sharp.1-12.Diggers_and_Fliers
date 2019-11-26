using System;

namespace _1_12.Diggers_and_Fliers
{

    class Snake : ICrawlAnimal, ISwimAnimal
    {
        public string Name {get;}

        public Snake( string name )
        {
            Name = name;
        }

        public void Crawl()
        {
            Console.WriteLine($"I'm {Name}. My favorite move style is to crawl.");
        }

        public void Swim()
        {
            Console.WriteLine($"I'm {Name}. I can swim, but...");
        }
    }
}