using AutoFabrics.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFabrics.Entities.Classes
{
    public class Suv : IAutomobile
    {
        public string GetModelInfo()
        {
            return "Suv: Fits 5-8 people" +
                "\n     Suvs can be used to transport cargo or luggage" +
                "\n     Many Suvs have advanced safety features, including stability control, airbags, and advanced safety features\n\n";
        }
    }
}
