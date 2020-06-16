using System;

namespace introduction
{
    class Encapsulation
    {
        private string name;
        private double age;
        private string DOB;
        private string pet;

        public void Information()
        {
            name = "James";
            age = 26;
            DOB = "Fifth of October, 1993";
            pet = "Hermes";
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I'm {age} years old");
            Console.WriteLine($"I was born on the {DOB}");
            Console.WriteLine($"My pet's name is {pet}");
            
        }
    }
}