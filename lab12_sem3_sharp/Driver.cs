using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_sem3_sharp
{
    class Driver
    {
        public Driver()
        {   
            Console.WriteLine("Человек получил водительское удостоверение\n");
        }
        public void ToDrive(Transport transport)
        {
            transport.Drive();
        }
        public void ToBuy(Transport transport)
        {
            transport.Buy();
        }
    }
}
