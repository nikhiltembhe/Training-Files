using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo01();
            Console.WriteLine();

            Demo02();
            Console.WriteLine();

            Demo03();
            Console.WriteLine();
        }

        private static void Demo03()
        {
            Console.WriteLine("--- Demo of Interface");

            Car objCar = new Car();
            Scooter objScooter = new Scooter();
            Driver03 objDriver = new Driver03();
            Bus objBus = new Bus();

            objDriver.DriveObject(objCar);          // pass the object implementing the interface
            objDriver.DriveObject(objScooter);
            objDriver.DriveObject(objBus);
        }


        private static void Demo02()
        {
            Console.WriteLine("--- Demo of Boxing and Unboxing");
            Car objCar = new Car();
            Scooter objScooter = new Scooter();
            Driver02 objDriver = new Driver02();

            objDriver.DriveObject(objCar);          // boxing
            objDriver.DriveObject(objScooter);
        }

        private static void Demo01()
        {
            Console.WriteLine("--- Demo of Overloading");

            Car objCar = new Car();
            Scooter objScooter = new Scooter();
            Driver01 objDriver = new Driver01();            // Overloading done in Driver Class

            objDriver.DriveTypedObject(objCar);
            objDriver.DriveTypedObject(objScooter);
        }
    }
}
