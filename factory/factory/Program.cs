using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    interface IProduction
    {
        void Release();
    }

    class Car : IProduction
    {
        public void Release() => Console.WriteLine("Произведен автомобиль");
    }

    class Truck : IProduction
    {
        public void Release() => Console.WriteLine(("Произведен грузовик"));
    }

    interface IWorkShop
    {
        IProduction create();
    }

    class CarWorkShop : IWorkShop
    {
        public IProduction create() => new Car();

    }

    class TruckWorkshop : IWorkShop
    {
        public IProduction create() => new Truck();
    }



    class Program
    {
        static void Main(string[] args)
        {
            IWorkShop creator = new CarWorkShop();
            IProduction car = creator.create();
            creator = new TruckWorkshop();
            IProduction truck = creator.create();
            car.Release();
            truck.Release();
        }
    }
}
