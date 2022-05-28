using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Phone
    {
        string data;
        public Phone() => data = "";
        public string AboutPhone() => data;
        public void AppendData(string str) => data += str;
    }

    interface IDeveloper
    {
        void CreateDisplay();
        void CreateBox();
        void SystemInstall();
        Phone GetPhone();
    }

    class AndroidDeveloper : IDeveloper
    {
        private Phone phone;
        public AndroidDeveloper() => phone = new Phone();
        public void CreateDisplay() => phone.AppendData("Произведен дисплей Samsung ");
        public void CreateBox() => phone.AppendData("Произведен корпус Самсунг ");
        public void SystemInstall() => phone.AppendData("Установлена система Андроид ");
        public Phone GetPhone() => phone;

    }
    

    class IphoneDeveloper: IDeveloper
        {
            private Phone phone;
            public IphoneDeveloper() => phone = new Phone();
            public void CreateDisplay() => phone.AppendData("Произведен дисплей Iphone ");
            public void CreateBox() => phone.AppendData("Произведен корпус iphone ");
            public void SystemInstall() => phone.AppendData("Установлена система IOS ");
            public Phone GetPhone() => phone;
        }
    

    class Director
    {
        private IDeveloper developer;
        public Director(IDeveloper developer) => this.developer = developer;
        public void SetDeveloper(IDeveloper developer) => this.developer = developer;

        public Phone MountOnlyPhone()
        {
            developer.CreateBox();
            developer.CreateDisplay();
            return developer.GetPhone();
            
        }

        public Phone MountFullPhone()
        {
            developer.CreateBox();
            developer.CreateDisplay();
            developer.SystemInstall();
            return developer.GetPhone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDeveloper androidDeveloper = new AndroidDeveloper();
            Director director = new Director(androidDeveloper);
            
            Phone samsung = director.MountFullPhone();
            Console.WriteLine(samsung.AboutPhone());

            IDeveloper iphoneDeveloper = new IphoneDeveloper();
            director.SetDeveloper(iphoneDeveloper);

            Phone iphone = director.MountFullPhone();
            Console.WriteLine(iphone.AboutPhone());


        }

    }
}
