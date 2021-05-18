using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class EurasianFactory : AbstractFactory
    {
        public override Carnivores CreateCarnivores()
        {
            return new EurasianCarnivores();
        }

        public override Herbivores CreateHerbivores()
        {
            return new EurasianHerbivores();
        }
    }
}
