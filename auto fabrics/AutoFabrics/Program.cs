using AutoFabrics.Factories.Classes;
using System;

class Program
{
    static void Main()
    {
        var sedanFactory = new SedanFactory();
        var suvFactory = new SuvFactory();
        var truckFactory = new TruckFactory();
        
        var sedanCar = sedanFactory.CreateAutomobile();
        var suvCar = suvFactory.CreateAutomobile();
        var truckCar = truckFactory.CreateAutomobile();

        Console.WriteLine(sedanCar.GetModelInfo());
        Console.WriteLine(suvCar.GetModelInfo());
        Console.WriteLine(truckCar.GetModelInfo());
    }
}