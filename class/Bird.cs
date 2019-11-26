using System;

namespace _1_12.Diggers_and_Fliers
{

    class Bird : IFlyAnimal, IWalkAnimal
    {
        public string Name {get;}
        public int WingNumber {get;}
        public int LegNumber {get;}

        public Bird( string name )
        {
            Name = name;
            WingNumber = 2;
            LegNumber = 2;
        }

        public void Fly()
        {
            Console.WriteLine($"I'm {Name}. I have {WingNumber} wings to fly.");
        }

        public void Walk()
        {
            Console.WriteLine($"I'm {Name}. I have {LegNumber} legs to walk.");
        }
    }
}