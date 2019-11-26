using System;
using System.Collections.Generic;

namespace _1_12.Diggers_and_Fliers
{

    class FishContainer
    {
        public List<ISwimAnimal> animals {get;}

        public FishContainer()
        {
            animals = new List<ISwimAnimal>();
        }

        public void AddFish( ISwimAnimal animal )
        {
            animals.Add( animal );
        }
    }
}