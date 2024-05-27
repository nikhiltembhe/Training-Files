using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interfaces
{
    internal class Scooter : IVehicle
    {
        public void DriveScooter()
        {
            Console.WriteLine("Scooter is being driven");
        }

        #region IVehicle members

        public void Drive()
        {
            Console.WriteLine("Scooter is being driven");
        }

        #endregion

    }
}
