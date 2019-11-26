using System;
using System.Collections.Generic;


namespace _1_12.Diggers_and_Fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            /*
                Betta Fish:         swim
                Timber Rattlesnake: swim, crawl
                Copperhead snake:   swim, crawl
                Earthworms: crawl, dig
                Ants:       walk, dig
                Terrapins:  swim, walk
                Mice:       walk, dig
                Gerbils:    walk, dig
                Parakeets:  walk, fly
                Finches:    walk, fly
            */
            // 1. Before you write any classes for the above animals, determine the common properties and behaviors that some of them share and define interfaces first.

            // 2. Once you believe you have a good set of interfaces, then start creating your specific animal classes and have them implement the appropriate interface.

            // 3. Then define classes to represent the containers that will hold various animals. Each container class should have a single property - a list to hold animal instances.

            // 4. Lastly, in Main() create one (or more if you like) instances of each type of animal and each container. Then add the animals to their corresponding container.

            BirdContainer birdCage = new BirdContainer();
            RodentContainer rodentCage = new RodentContainer();
            SnakeContainer snakeBox = new SnakeContainer();
            FishContainer fishAquarium = new FishContainer();
            AntContainer antBox = new AntContainer();

            Bird parakeet = new Bird("Parakeet");
            Bird finch = new Bird("Finch");

            Rodent mouse = new Rodent("Mouse");
            Rodent gerbil = new Rodent("Gerbil");

            Snake copperheadSnake = new Snake("Copperhead Snake");
            Snake timberRattlesnake = new Snake("Timber Rattlesnake");

            Fish bettaFish = new Fish("Betta Fish");
            Turtle terrapin = new Turtle("Terrapin");

            Ant ant = new Ant("Ant");
            Worm worm = new Worm("Earthworm");

            birdCage.AddBird( parakeet );
            birdCage.AddBird( finch );

            rodentCage.AddRodent( mouse );
            rodentCage.AddRodent( gerbil );

            snakeBox.AddSnake( copperheadSnake );
            snakeBox.AddSnake( timberRattlesnake );

            fishAquarium.AddFish( bettaFish );
            fishAquarium.AddFish( terrapin );

            antBox.AddAnimal( ant );
            antBox.AddAnimal( worm );

            foreach( Bird bird in birdCage.birds )
            {
                bird.Fly();
                bird.Walk();
            }

            foreach( Rodent rodent in rodentCage.rodents )
            {
                rodent.Walk();
            }

            foreach( Snake snake in snakeBox.snakes )
            {
                snake.Crawl();
                snake.Swim();
            }

            foreach( ISwimAnimal animal in fishAquarium.animals )
            {
                animal.Swim();
            }

            foreach( IDigAnimal animal in antBox.animals )
            {
                animal.Dig();
            }
        }
    }
}
