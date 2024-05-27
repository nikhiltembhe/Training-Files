using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_InterfacesExtended.Demo03
{
    interface IDemo
    {
        void m();
    }

    interface IAnotherDemo : IDemo                  // IAnotherDemo EXTENDS IDemo 
    {
        void n();
    }


    // Demo of Implicit implementation of Interface Signatures
    class Demo : IAnotherDemo                       // Demo IMPLEMENTS IAnotherDemo EXPLICITLY & IDemo IMPLICITLY
    {
        public void m()        
        {

        }

        public void n()        
        {

        }
    }

    // Demo of Explicit Implementation of Interface Signatures
    class Demo2 : IAnotherDemo                       // Demo IMPLEMENTS IAnotherDemo EXPLICITLY & IDemo EXPLICITLY
    {
        void IDemo.m()
        {
            
        }

        void IAnotherDemo.n()
        {
            
        }
    }
}
