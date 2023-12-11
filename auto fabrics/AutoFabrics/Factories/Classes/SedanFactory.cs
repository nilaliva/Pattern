using AutoFabrics.Entities.Classes;
using AutoFabrics.Entities.Interfaces;
using AutoFabrics.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFabrics.Factories.Classes
{
    public class SedanFactory : IAutomobileFactory
    {
        public IAutomobile CreateAutomobile()
        {
            return new Sedan();
        }
    }
}
