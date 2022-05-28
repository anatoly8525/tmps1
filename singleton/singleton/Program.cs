using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton iphone = Singleton.Intialize();
            Console.WriteLine(iphone.GetHashCode());
            Singleton xiaomi = Singleton.Intialize();
            Console.WriteLine(xiaomi.GetHashCode());
            Console.ReadKey();
        }
    }
}