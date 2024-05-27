using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_InterfacesExtended
{
    namespace Demo01
    {
        interface IDemo
        {
            void m();
        }

        interface IAnotherDemo
        {
            void n();
        }

        class Demo : IDemo, IAnotherDemo
        {
            public void m()
            {

            }

            public void n()
            {

            }
        }
    }
}
