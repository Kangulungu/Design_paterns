using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Singleton_Naif
            //Singleton_Naif s1 = Singleton_Naif.GetInstance();
            //Singleton_Naif s2 = Singleton_Naif.GetInstance();

            //if (s1 == s2)
            //{
            //    Console.WriteLine("Singleton works, both variables contain the same instance.");
            //}
            //else
            //{
            //    Console.WriteLine("Singleton failed, variables contain different instances.");
            //}

            ////ingleton_TSafe
            
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
            Console.ReadLine();
        }

        public static void TestSingleton(string value)
        {
            Singleton_TSafe singleton = Singleton_TSafe.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
