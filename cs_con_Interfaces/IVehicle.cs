using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Interfaces
{
    // all members ARE public
    // no member can have a body (pure-abstract signatures only)
    // To provide standardization across class heirarchies.
    internal interface IVehicle
    {
        void Drive();
    }
}
