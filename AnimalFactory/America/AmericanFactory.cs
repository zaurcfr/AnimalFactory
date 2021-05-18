using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class AmericanFactory : AbstractFactory
    {
        public override Carnivores CreateCarnivores()
        {
            return new AmericanCarnivores();
        }

        public override Herbivores CreateHerbivores()
        {
            return new AmericanHerbivores();
        }
    }
}
