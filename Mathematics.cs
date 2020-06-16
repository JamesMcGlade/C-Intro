using System;
using System.Collections.Generic;
//a library that will be essential for the majority of our first week...
// without it we will have lenghty paths.

namespace introduction

//any class inside the namespace will be available...

{
    class Mathematics
    {
        public float Addition(float numberOne, float numberTwo)
        {
            return numberOne + numberTwo;
        }

        public float Subtraction(float numberOne, float numberTwo)
        {
            return numberOne - numberTwo;
        }

        public float Multiplication(float numberOne, float numberTwo)
        {
            return numberOne * numberTwo;
        }

        public float Division(float numberOne, float numberTwo)
        {
            //decimal = floating point number
            return numberOne / numberTwo;
            // float allows 6 to 7 decimals
        }
        // public void AddingTogether()
        // {
        //     int number = Addition(10,20);
        //     Console.WriteLine(number);
        //     return number;
        // }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mathematics maths = new Mathematics(); // create new instance of Mathematics
            students.Dean myDeanNotYoursMine = new students.Dean();
            float addMePlease = maths.Addition(10, 20);
            float subtractMePlz = maths.Subtraction(100, 200);
            float multiplyMePlz = maths.Multiplication(23.3f, 5.43f);
            float divideMePlz = maths.Division(10, 3);
            Encapsulation example = new Encapsulation();

            example.Information();

            Console.WriteLine(addMePlease);
            Console.WriteLine(subtractMePlz);
            Console.WriteLine(multiplyMePlz);
            Console.WriteLine(divideMePlz);
        }
    }
}


// int = Stores whole numbers from -2,147,483,648 to 2,147,843,647
// long = Sotres whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
// number = 1.2345684930234
// naomiNumber = 3
// harryNumber = 1.129832+307