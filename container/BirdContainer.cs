using System;
using System.Collections.Generic;

namespace _1_12.Diggers_and_Fliers
{

    class BirdContainer
    {
        public List<Bird> birds {get;}

        public BirdContainer()
        {
            birds = new List<Bird>();
        }

        public void AddBird( Bird bird )
        {
            birds.Add( bird );
        }
    }
}
