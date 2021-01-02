using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_sem3_sharp
{
    class AirTransport : Transport //Производный класс
    {
        String name;
        int numberOfPassengers;
        public int NumberOfPassengers
        {
            get
            {
                return numberOfPassengers;
            }
            set
            {
                numberOfPassengers = NumberOfPassengers;
            }
        }
        public AirTransport()
        {
            name = " ";
        }
        public AirTransport(string name, int NumberOfPassengers)
        {
            this.name = name;
            this.numberOfPassengers = NumberOfPassengers;
        }
        public void Buy()
        {
            Console.WriteLine($"Пилот купил {name} (Кол-во пассажиров: {numberOfPassengers})");
        }
        public void Drive()
        {
            Console.WriteLine($"Пилот полетел на {name}\n");
        }
        public virtual void Display()
        {
            Console.WriteLine($"Название транспорта: {name} Кол-во пассажиров: {numberOfPassengers}");
        }
        public virtual void Read()
        {
            Console.WriteLine("Введите название транспорта: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите максимальное кол-во пассажиров: ");
            numberOfPassengers = Convert.ToInt32(Console.ReadLine());
        }
        public object DeepClone()
        {
            return new AirTransport(this.name, this.numberOfPassengers);
        }
        public object ShallowClone()
        {
            return this.MemberwiseClone();
        }
        //Метод ToString
        public override string ToString()
        {
            return name.ToString();
        }
    }
}
