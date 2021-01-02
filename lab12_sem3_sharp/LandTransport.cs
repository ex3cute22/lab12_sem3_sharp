using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_sem3_sharp
{
    class LandTransport : Transport //Производный класс
    {
        protected String name = " ";
        public LandTransport()
        {
            name = " ";
        }
        public LandTransport(string name)
        {
            this.name = name;
        }

        public void Buy()
        {
            Console.WriteLine($"Водитель купил {name}");
        }
        public void Drive()
        {
            Console.WriteLine($"Водитель поехал на {name}\n");
        }
        public virtual void Display()
        {
            Console.WriteLine($"Название транспорта: {name}");
        }
        public virtual void Read()
        {
            Console.WriteLine("Введите название транспорта: ");
            name = Console.ReadLine();
        }
        public object DeepClone()
        {
            return new LandTransport(this.name);
        }
        public object ShallowClone()
        {
            return this.MemberwiseClone();
        }
    }
}
