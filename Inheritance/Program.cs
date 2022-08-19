using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            Bird BlueJay = new Bird();
            BlueJay.CanFly = true;
            BlueJay.isPrey = true;
            BlueJay.isPredator = false;
            BlueJay.Lifespan = 7;
            BlueJay.Color = "blue";
            BlueJay.Species = "Bird";
            BlueJay.Sound = "whisper song";
            BlueJay.TypeOfBird = "Blue Jay";

            Console.WriteLine($"The species of animal is {BlueJay.Species}.");
            Console.WriteLine($"The type of bird is {BlueJay.TypeOfBird}.");
            Console.WriteLine($"The {BlueJay.TypeOfBird} sounds like {BlueJay.Sound}.");
            Console.WriteLine($"The color of the {BlueJay.TypeOfBird} is {BlueJay.Color}.");
            Console.WriteLine($"The average lifespan of the {BlueJay.TypeOfBird} is {BlueJay.Lifespan} years.");
            Console.WriteLine($"The {BlueJay.TypeOfBird} is a pedator: {BlueJay.isPredator}.");
            Console.WriteLine($"The {BlueJay.TypeOfBird} is a prey: {BlueJay.isPrey}.");
            Console.WriteLine($"The {BlueJay.TypeOfBird} can fly: {BlueJay.CanFly}.");
            

            Reptile Turtle = new Reptile();
            Turtle.Species = "Reptile";
            Turtle.TypeOfReptile = "Box Turtle";
            Turtle.Lifespan = 25;
            Turtle.isPrey = true;
            Turtle.isPredator = false;
            Turtle.CanSwim = true;
            Turtle.HasScales = false;
            Turtle.HasTeeth = false;

            Console.WriteLine();
            Console.WriteLine($"The species of animal is {Turtle.Species}.");
            Console.WriteLine($"The type of reptile is {Turtle.TypeOfReptile}.");
            Console.WriteLine($"The average lifespan of the {Turtle.TypeOfReptile} is {Turtle.Lifespan} years.");
            Console.WriteLine($"The {Turtle.TypeOfReptile} is a predator: {Turtle.isPredator}");
            Console.WriteLine($"The {Turtle.TypeOfReptile} is a prey: {Turtle.isPrey}");
            Console.WriteLine($"The {Turtle.TypeOfReptile} has teeth: {Turtle.HasTeeth}");


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
