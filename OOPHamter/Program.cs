using System;

namespace OOPHamter
{
    class Program
    {
        class Hamster
        {
            string name;
            int weight;

            public Hamster(string _name, int _weight)
            {
                name = _name;
                weight = _weight;
                Console.WriteLine($"The hamster {name} has been created."); 
            }


            public double Weight
            {
                get { return weight; }
            }

            public int Age
            {
                get; set;
            }

            public void ShowPetdata()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Weight: {Weight}");
            }
        }


        static void Main(string[] args)
        {
            
        }
    }
}
