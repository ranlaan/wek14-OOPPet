using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string regNumber;
            string color;
            int odo;
            int fueltank;

            public Car(string _mark, string _model, string _regNumber)
            {
                mark = _mark;
                model = _model;
                regNumber = _regNumber;
                odo = 0;
                fueltank = 60;

                Console.WriteLine($"{mark} {model} {regNumber} has been created");
            }
        }

        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Supra", "696969");

        }
    }
}
