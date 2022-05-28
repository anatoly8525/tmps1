using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton single = null;

        protected Singleton()
        {
            
        }

        public static Singleton Intialize()
        {
            if (single == null)
                single = new Singleton();
            return single;
        }
    }
}