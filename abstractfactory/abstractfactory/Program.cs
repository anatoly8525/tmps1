using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractfactory
{
    interface IEngine
    {
        void ReleaseEngine();
    }

    class JapaneseEngine: IEngine
    {
        public void ReleaseEngine() => Console.WriteLine("Японский двигатель");
    }

    class RussianEngine : IEngine
    {
        public void ReleaseEngine() => Console.WriteLine("Российский двигатель");
    }

    interface ICar
    {
        void ReleaseCar(IEngine engine);
    }

    class JapaneseCar : ICar
    {
        public void ReleaseCar(IEngine engine)
        {
            Console.WriteLine("Собрали японский автомобиль: ");
            engine.ReleaseEngine();
        }
    }
    class RussianCar : ICar
    {
        public void ReleaseCar(IEngine engine)
        {
            Console.WriteLine("Собрали российский автомобиль: ");
            engine.ReleaseEngine();
        }
    }

    interface IFabrika
    {
        IEngine createEngine();
        ICar createCar();
    }

    class JapaneseFactory: IFabrika
    {
        public ICar createCar() => new JapaneseCar();
        public IEngine createEngine() => new JapaneseEngine();
    }
    
    class RussianFactory: IFabrika
    {
        public ICar createCar() => new RussianCar();
        public IEngine createEngine() => new RussianEngine();
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFabrika jFabrika = new JapaneseFactory();
            IEngine jEngine = jFabrika.createEngine();

           ICar jCar = jFabrika.createCar(); 
           jCar.ReleaseCar(jEngine);

           IFabrika rfabrika = new RussianFactory();
           IEngine rEngine = rfabrika.createEngine();
           ICar rCar = rfabrika.createCar();
           rCar.ReleaseCar(rEngine);
        }

    }
}
