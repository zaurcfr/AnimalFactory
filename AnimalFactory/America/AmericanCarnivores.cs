using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class AmericanCarnivores : Carnivores
    {
        public string Name { get; set; }
        public bool IsEatingMeat { get; set; }
        public AmericanCarnivores()
        {
            Name = "American Carnivore";
            IsEatingMeat = true;
        }
    }
}
