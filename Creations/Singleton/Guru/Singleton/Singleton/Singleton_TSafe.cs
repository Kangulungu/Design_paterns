using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton_TSafe
    {
        private static Singleton_TSafe _instance;
        private static readonly object _lock = new object();

        public string Value { get; set; }
        public static Singleton_TSafe GetInstance(string value)
        {

            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton_TSafe();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }
    }
}
