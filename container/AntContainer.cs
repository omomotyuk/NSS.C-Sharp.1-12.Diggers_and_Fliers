using System;
using System.Collections.Generic;

namespace _1_12.Diggers_and_Fliers
{

    class AntContainer
    {
        public List<IDigAnimal> animals {get;}

        public AntContainer()
        {
            animals = new List<IDigAnimal>();
        }

        public void AddAnimal( IDigAnimal animal )
        {
            animals.Add( animal );
        }
    }
}