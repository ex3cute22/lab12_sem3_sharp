using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_sem3_sharp
{
    class Plane : AirTransport
    {
        String name;
        int numberOfPassengers;
        int MaxHeight;

        public Plane() : base()
        {
            name = " ";
            numberOfPassengers = 0;
            MaxHeight = 0;
        }
        public Plane(String name, int numberOfPassengers, int MaxHeight) : base(name,numberOfPassengers)
        {
            this.name = name;
            this.numberOfPassengers = numberOfPassengers;
            this.MaxHeight = MaxHeight;
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Название: ");
            name = Console.ReadLine();
            Console.WriteLine("Кол-во пассажирова: ");
            numberOfPassengers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Максимальная высота: ");
            MaxHeight = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Название : {name}  Кол-во пассажиров: {numberOfPassengers}  Максимальная высота: {MaxHeight} м.\n");
        }
    }
}
