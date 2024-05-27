using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_BoxingUnboxing
{
    internal class Demo04
    {
        public static void RunThis()
        {
            Car objCar = new Car();
            objCar.RegNo = "Car #007";
            objCar.BHP = 1000;
            objCar.NumberOfSeats = 5;

            Scooter objScooter = new Scooter();
            objScooter.RegNo = "Scooter #420";
            objScooter.Color = "Yellow";

            Driver objDriver = new Driver();

            objDriver.Drive(objCar);            // implicit boxing
            objDriver.Drive(objScooter);
        }
    }

    class Driver
    {
        public void Drive(object objVehicle)
        {
            Console.WriteLine("Driver is driving a Vehicle of the type: {0}", objVehicle.GetType().Name);
            if (objVehicle.GetType() == typeof(Car))
            {
                Car objCar = (Car)objVehicle;   // unboxing

                Console.WriteLine("\tRegNo : {0}", objCar.RegNo);
                Console.WriteLine("\tBHP : {0} ", objCar.BHP);
                Console.WriteLine("\tNumber Of Seats : {0} ", objCar.NumberOfSeats);
            }
            // IS OPERATOR = type-checking operator
            else if(objVehicle is Scooter)          //  if(objVehicle.GetType() == typeof(Scooter))
            {
                // AS OPERATOR = SAFE type-casting operator
                // Scooter objScooter = (Scooter)objVehicle;   // unboxing (throws Exception if object IS NOT scooter)
                Scooter objScooter = objVehicle as Scooter;    // SAFE unboxing (object == NULL if NOT Scooter)   

                if (objScooter != null)
                {
                    Console.WriteLine("\tRegNo : {0}", objScooter.RegNo);
                    Console.WriteLine("\tColor : {0}", objScooter.Color);
                }
            }
            Console.WriteLine();
        }

    }

    class Scooter
    {
        public string RegNo;
        public string Color;
    }

    class Car
    {
        public string RegNo;
        public int NumberOfSeats;
        public int BHP;
    }

}
