using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class AfricanFactory : AbstractFactory
    {
        public override Carnivores CreateCarnivores()
        {
            return new AfricanCarnivores();
        }

        public override Herbivores CreateHerbivores()
        {
            return new AfricanHerbivores();
        }
    }
}
