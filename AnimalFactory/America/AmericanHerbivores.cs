using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class AmericanHerbivores : Herbivores
    {
        public string Name { get; set; }
        public bool IsEatingPlant { get; set; }
        public AmericanHerbivores()
        {
            Name = "American Herbivore";
            IsEatingPlant = true;
        }
    }
}
