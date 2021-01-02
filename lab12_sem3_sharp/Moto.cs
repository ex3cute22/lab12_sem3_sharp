using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_sem3_sharp
{
    class Moto : LandTransport
    {
        String marka;
        int year;
        int price;

        public Moto() : base()
        {
            marka = " ";
            year = 0;
            price = 0;
        }
        public Moto(String _marka) : base(_marka)
        {
            marka = _marka;
            year = 0;
            price = 0;
        }
        public Moto(String _marka, int _year, int _price) : base(_marka)
        {
            marka = _marka;
            year = _year;
            price = _price;
        }

        public override void Read()
        {
            base.Read();
            Console.WriteLine("Марка: ");
            marka = Console.ReadLine();
            Console.WriteLine("Год: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Цена: ");
            price = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Марка : {marka}  Год: {year}г.  Цена: {price}\n");
        }
    }
}
