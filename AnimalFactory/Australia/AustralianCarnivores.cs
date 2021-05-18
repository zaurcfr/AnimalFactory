using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class AustralianCarnivores : Carnivores
    {
        public string Name { get; set; }
        public bool IsEatingMeat { get; set; }
        public AustralianCarnivores()
        {
            Name = "Australian Carnivore";
            IsEatingMeat = true;
        }
    }
}
