using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interfaces
{
    // Drive using Boxing and Unboxing
    internal class Driver02
    {
        public void DriveObject(object objVehicle)
        {
            Console.WriteLine("Driver is now driving a Vehicle Object");
            if (objVehicle is Car)
            {
                Car objCar = objVehicle as Car;                         // unboxing
                objCar.DriveCar();
            }
            else if(objVehicle is Scooter)
            {
                Scooter objScooter = objVehicle as Scooter;             // unboxing
                objScooter.DriveScooter();
            }
        }

    }
}
