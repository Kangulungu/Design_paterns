using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton_Naif
    {
        private static Singleton_Naif _instance;

        public static Singleton_Naif GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton_Naif();
            }
            return _instance;
        }
        public void someBusinessLogic()
        {
            // ...
        }
    }
}
