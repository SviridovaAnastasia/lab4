using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем гараж
            var myCars = new List<Car>();
            //заполняем машинами
            myCars.Add(new Niva());
            myCars.Add(new Mersedes());
            myCars.Add(new Mersedes());
            myCars.Add(new Mersedes());
            myCars.Add(new MersedesSLK());
            myCars.Add(new Niva());
            myCars.Add(new Niva());
            myCars.Add(new Oka());
            Console.WriteLine("Мой гараж");
            Console.WriteLine("до сортировки:");
            myCars.ForEach(car => Console.Write("у " + car.GetName() + " " + car.GetWeel().ToString() + " колес(а) и масса " + car.GetMass() + " кг\n"));
            //сортируем массив
            myCars.Sort((emp1, emp2) => emp1.GetName().CompareTo(emp2.GetName()));
            Console.WriteLine("после сортировки:");
            myCars.ForEach(car => Console.Write("у " + car.GetName() + " " + car.GetWeel().ToString() + " колес(а) и масса " + car.GetMass() + " кг\n"));
            Console.ReadLine();
        }
    }
    public interface Mechanism
    {
        string GetName();
    }
    public interface Car : Mechanism
    {
        int GetWeel();

        string GetMass();
    }
    public class Niva : Car
    {
        public string GetName()
        {
            return "нива";
        }
        public int GetWeel()
        {
            return 4;
        }
        public string GetMass()
        {
            return "2000";
        }
    }
    public class Mersedes : Car
    {
        virtual//не знаю что значит
        public string GetName()
        {
            return "мерседес";
        }
        public int GetWeel()
        {
            return 4;
        }
        public string GetMass()
        {
            return "1500";
        }
    }

    public class MersedesSLK : Mersedes
    {
        override
        public string GetName()
        {
            return "мерседес SLK";
        }

    }
    public class Oka : Car
    {
        public string GetName()
        {
            return "ока";
        }
        public int GetWeel()
        {
            return 4;
        }
        public string GetMass()
        {
            return "700";
        }
    }
}





