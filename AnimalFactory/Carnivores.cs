using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    interface Carnivores
    {
        string Name { get; set; }
        bool IsEatingMeat { get; set; }
    }
}
