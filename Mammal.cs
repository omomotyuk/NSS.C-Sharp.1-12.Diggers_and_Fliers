namespace _1_12.Diggers_and_Fliers
{

    class Mammal : IWalklAnimal
    {
        public void Walk()
        {
            Console.WriteLine($"I have {LegNumber} legs to walk.");
        }
    }
}