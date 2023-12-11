using AutoFabrics.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFabrics.Entities.Classes
{
    public class Truck : IAutomobile
    {
        public string GetModelInfo()
        {
            return "Truck: Fits 2-3 people" +
                "\n       Trucks are used for long-distance transportation of goods, construction work, commercial deliveries and etc" +
                "\n       Trucks can have a variety of cab types, including single cabs, double cabs, and cabin cabs      ";
        }
    }
}
