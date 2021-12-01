using System;

namespace OOPPet
{
    class Program
    {
        class Dog
        {
            string name;
            int age;
            double weight;

            public Dog(string _name)
            {
                name = _name;
                weight = 0.1;
                age = 0;
                Console.WriteLine($"The dog {name} has been adopted.");
            }

            public string Name
            {
                get { return name; }
            }

            public int Age
            {
                get { return age; }
            }

            public double Weight
            {
                get { return weight; }
            }

            public void Eat()
            {
                Console.WriteLine("Munch-Munch");
                weight += 0.2;
            }

            public void Exercise()
            {
                Console.WriteLine("Tippy-Tippy-Tap-Tap");
                weight -= 0.1;
            }

            public void Rename(string newName)
            {
                name = newName;
            }

            static void Main(string[] args)
            {
                Dog myDog = new Dog("Doggo");


                myDog.Exercise();
                Console.WriteLine("Rename your dog:");
                string userInput = Console.ReadLine();
                myDog.Rename(userInput);

                Console.WriteLine($"Name: {myDog.Name}");
                Console.WriteLine($"Weight: {myDog.Weight}");
            }
        }
    }
}
