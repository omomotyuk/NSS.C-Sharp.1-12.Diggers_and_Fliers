using System;
using System.Collections.Generic;

namespace _1_12.Diggers_and_Fliers
{

    class SnakeContainer
    {
        public List<Snake> snakes {get;}

        public SnakeContainer()
        {
            snakes = new List<Snake>();
        }

        public void AddSnake( Snake snake )
        {
            snakes.Add( snake );
        }
    }
}