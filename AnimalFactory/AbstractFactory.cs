using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    abstract class AbstractFactory
    {
        public abstract Carnivores CreateCarnivores();
        public abstract Herbivores CreateHerbivores();
    }
}
