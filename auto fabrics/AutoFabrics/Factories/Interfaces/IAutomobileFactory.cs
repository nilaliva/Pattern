using AutoFabrics.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFabrics.Factories.Interfaces
{
    public interface IAutomobileFactory
    {
        IAutomobile CreateAutomobile();
    }
}
