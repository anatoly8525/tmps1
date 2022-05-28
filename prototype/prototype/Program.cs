using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    interface ICar
    {
        void SetName(string name);
        string GetName();
        ICar Clone();

    }

    class Car: ICar
    {
        private string name;
        public Car(){ }
        private Car(Car copy) => this.name = copy.name;
        public void SetName(string name) => this.name = name;
        public string GetName() => name;
        public ICar Clone() => new Car(this);
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICar carcopy = new Car();
            carcopy.SetName("toyota");
            
            ICar ToyotaClone = carcopy.Clone();
            Console.WriteLine(carcopy.GetName());
            Console.WriteLine(ToyotaClone.GetName());
        }
    }
}