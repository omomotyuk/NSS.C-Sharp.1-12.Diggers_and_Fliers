namespace _1_12.Diggers_and_Fliers
{

    class Bird : IFlyAnimal, IWalklAnimal
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