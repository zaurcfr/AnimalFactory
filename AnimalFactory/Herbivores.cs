using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    interface Herbivores
    {
        string Name { get; set; }
        bool IsEatingPlant { get; set; }
    }
}
