using System;
using System.Collections.Generic;

namespace _1_12.Diggers_and_Fliers
{

    class RodentContainer
    {
        public List<Rodent> rodents {get;}

        public RodentContainer()
        {
            rodents = new List<Rodent>();
        }

        public void AddRodent( Rodent rodent )
        {
            rodents.Add( rodent );
        }
    }
}