using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class AustralianFactory : AbstractFactory
    {
        public override Carnivores CreateCarnivores()
        {
            return new AustralianCarnivores();
        }

        public override Herbivores CreateHerbivores()
        {
            return new AustralianHerbivores();
        }
    }
}
