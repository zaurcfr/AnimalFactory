using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class AfricanCarnivores : Carnivores
    {
        public string Name { get; set; }
        public bool IsEatingMeat { get; set; }

        public AfricanCarnivores()
        {
            Name = "African Carnivore";
            IsEatingMeat = true;
        }
    }
}
