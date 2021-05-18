using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class AfricanHerbivores : Herbivores
    {
        public string Name { get; set; }
        public bool IsEatingPlant { get; set; }
        public AfricanHerbivores()
        {
            Name = "African Herbivore";
            IsEatingPlant = true;
        }
    }
}
