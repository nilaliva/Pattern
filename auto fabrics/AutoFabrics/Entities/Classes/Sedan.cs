using AutoFabrics.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFabrics.Entities.Classes
{
    public class Sedan : IAutomobile
    {
        public string GetModelInfo()
        {
            return "Sedan: Fits 4-5 people" +
                "\n       Very comfortable have various options such as air conditioning, heated seats, security systems " +
                "\n       Sedans are widely used for everyday driving\n\n";
        }
    }
}
