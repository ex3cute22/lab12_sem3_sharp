using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_sem3_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car("Toyota", 1998, 150000);
            toyota.Display();
            Car bmw = new Car("BMW", 2012, 350000);
            bmw.Display();
            Moto bmx = new Moto("BMX", 2020, 120000);
            bmx.Display();
            Plane boing = new Plane("Боинг", 120, 11000);
            boing.Display();
            Driver Ilya = new Driver();
            Ilya.ToBuy(boing);
            Ilya.ToDrive(boing);

            Ilya.ToBuy(bmx);
            Ilya.ToDrive(bmx);

            Ilya.ToBuy(toyota);
            Ilya.ToDrive(toyota);

            Ilya.ToBuy(bmw);
            Ilya.ToDrive(bmw);

            AirTransport il = new AirTransport("IL-154",300);
            AirTransport il1 = (AirTransport)il.ShallowClone(); //Мелкое копирование
            AirTransport il2 = (AirTransport)il.DeepClone(); //Глубокое копирование
            Console.WriteLine(il1.ToString());
            Console.WriteLine(il2.ToString());
        }
    }
}
