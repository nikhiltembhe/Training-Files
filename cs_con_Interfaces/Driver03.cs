using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interfaces
{
    // Drive using the Interface
    internal class Driver03
    {
        public void DriveObject(IVehicle objVehicle)
        {
            Console.WriteLine("Driver is now driving a Vehicle: {0}.", objVehicle.GetType().Name);
            objVehicle.Drive();
        }

    }
}
