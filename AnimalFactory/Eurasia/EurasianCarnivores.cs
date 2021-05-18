using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class EurasianCarnivores : Carnivores
    {
        public string Name { get; set; }
        public bool IsEatingMeat { get; set; }
        public EurasianCarnivores()
        {
            Name = "Eurasian Carnivore";
            IsEatingMeat = true;
        }
    }
}
