namespace _1_12.Diggers_and_Fliers
{
    class BettaFish : ISwimAnimal
    {
        public void Swim()
        {
            Console.WriteLine("I need water to move (and live).");
        }
    }

    class TimberRattlesnake : ICrawlAnimal, ISwimAnimal
    {
        public void Swim()
        {
            Console.WriteLine("");
        }

        public void Crawl()
        { }
    }

    class CopperheadSnake : ICrawlAnimal, ISwimAnimal
    {
        public void Swim()
        {
            Console.WriteLine("");
        }

        public void Crawl()
        { }
    }

    class Earthworms : ICrawlAnimal
    {
        public void Crawl()
        { }
    }

    class Ants : IWalklAnimal
    {
        public void Walk()
        {
            Console.WriteLine($"I have {LegNumber} legs to walk.");
        }
    }

    class Terrapins : ISwimAnimal, IWalklAnimal
    {
        public void Swim()
        {

        }

        public void Walk()
        {
            Console.WriteLine($"I have {LegNumber} legs to walk.");
        }

    }

    class Mice : IWalklAnimal
    {
        public void Walk()
        {
            Console.WriteLine($"I have {LegNumber} legs to walk.");
        }
    }

    class Gerbils : Mammal
    {
        /*public void Walk()
        {
            Console.WriteLine($"I have {LegNumber} legs to walk.");
        }*/
    }

    class Parakeets : Bird
    {
        /*public void Fly()
        {
            Console.WriteLine($"I have {WingNumber} to fly.");
        }

        public void Walk()
        {
            Console.WriteLine($"I have {LegNumber} legs to walk.");
        }*/
    }

    class Finches : IFlyAnimal, IWalklAnimal
    {
        public void Fly()
        {
            Console.WriteLine($"I have {WingNumber} to fly.");
        }

        public void Walk()
        {
            Console.WriteLine($"I have {LegNumber} legs to walk.");
        }
    }
}