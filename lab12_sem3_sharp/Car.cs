﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_sem3_sharp
{
    class Car : LandTransport
    {
        String marka;
        int year;
        int price;
        static int count = 0;

        public Car() : base()
        {
            marka = "";
            year = 0;
            price = 0;
            count++;
        }
        public Car(String _marka) : base(_marka)
        {
            marka = _marka;
            year = 0;
            price = 0;
            count++;
        }
        public Car(String _marka, int _year, int _price) : base(_marka)
        {
            marka = _marka;
            year = _year;
            price = _price;
            count++;
        }
        ~Car()
        {
            RemoveItem();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Марка : {marka}  Год: {year}г.  Цена: {price}\n");
        }
        public void Add(Car obj)
        {
            count++;
            int sum = price + obj.price;
            if (sum > 350000)
            {
                marka = "Ferrari"; year = 2018; price = 350000;
            }
            else if (sum > 250000)
            {
                marka = "Nissan"; year = 2004; price = 250000;
            }
            else if (sum > 150000)
            {
                marka = "ВАЗ"; year = 1988; price = 150000;
            }
            else
            {
                marka = "ЗАЗ"; year = 1966; price = 0;
            }
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
            count++;
        }
        public void ClassCar(String classAuto)
        {
            classAuto = "B";
            Console.WriteLine(classAuto);
        }

        public void ClassCarRef(ref String classAuto)
        {
            classAuto = "B";
            Console.WriteLine(classAuto);
        }

        public void ClassCarOut(out String classAuto)
        {
            classAuto = "B";
            Console.WriteLine(classAuto);
        }
        public void addTag()
        {
            marka += " (purchased)";
        }
        public static Car operator ++(Car a)
        {
            return new Car { marka = a.marka, year = a.year + 1, price = a.price + 100000 };
        }
        public static Car operator +(Car a, Car b)
        {
            Car c = a;
            c.Add(b);
            return c;
        }
        public static void RemoveItem()
        {
            count--;
        }
        public static int InfoCount()
        {
            return count;
        }

        //Метод ToString
        public override string ToString()
        {
            return name.ToString();
        }
    }
}
