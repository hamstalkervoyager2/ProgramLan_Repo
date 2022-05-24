using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// See https://aka.ms/new-console-template for more information

namespace StrawberryCPU
{
    class Program
    {
        // "static void Main (string[] args)" is actually part of the "Program" class that is the Console that runs the instructions
        // and processes the code that is being input into it. Eccentually, it is the part of the console running the code.
        static void Main(string[] args)
        {

            // SIMPLE CONSOLE GREETING USING C-SHARP(C#):
            Console.WriteLine("Hello User! May name is Strawberry-AI. I will be your testing CPU for Programming with C-Sharp");
            Console.ReadLine();

            // BUILDING A SHAPE USING C-SHARP(C#):
            Console.WriteLine();
            Console.WriteLine("Here is a 'Right Triangle' Shape I made using C#!");
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
            Console.ReadLine();

            // It is important for you to understand that the order in which you place your code is a very critical factor in how
            // it will be utilized or viewed within the console. for example:

            //Console.WriteLine();
            // Console.WriteLine("Here is a 'Right Triangle' Shape I made using C#!");
            // Console.WriteLine("   /|");
            // Console.WriteLine("  / |");
            // Console.WriteLine("/___|");
            // Console.WriteLine(" /  |");
            // Console.ReadLine();

            // Particularly C# is primarily a set of instructions that are placed in a particular order.
            // Though you will eventually find that parts of the code for C# will become more complex as time goes on from
            // the basics to more complex commands and sets of instructions.

            // VARIABLES USING C-SHARP(C#):
            Console.WriteLine("There was once a man named George");
            Console.WriteLine("He was 70-years old");
            Console.WriteLine("He really liked being named George");
            Console.WriteLine("He didn't likw being 70-years old");
            Console.ReadLine();

            // Variables are containers that store data or pieces of information inside themselves.
            // They help manage and keep track of data within a Program console.

            // Here is a secondary testing of an example of variables:
            string charName = "Sakura";
            int Kunai = 4;
            string hairColor = "Pink";
            string crushName = "Sasuke";
            

            Console.WriteLine("There was a lovely girl named Sakura");
            Console.WriteLine("She has 4 Kunai in her pocket");
            Console.WriteLine("She has Pink hair");
            Console.WriteLine("She loves a boy named Sasuke"); // Haha "Naruto" reference in code...lol
            Console.ReadLine();

            // string = " Plain Text Variable "
            // int = " Number Variable that represents a "Whole Number" "
            // to incorparate values from your created variables you must "append" or link variables to text inside the 
            // Console.WriteLine() code. for example adding a + sign after text. For example:


            // Console.WriteLine("Hello" + username ", welcome to the coding play pen! Please test your code here!"
            // Using the test code above you can set it up like this to get these results:


            Console.WriteLine("There was a lovely girl named " + charName);
            Console.WriteLine("She has " + Kunai + " Kunai in her pocket");
            Console.WriteLine("She has " + hairColor + " hair");
            Console.WriteLine("She loves a boy named " + crushName); // Haha "Naruto" reference in code...lol
            Console.ReadLine();

            // adding two or more "+" symbols is a technique called "concatenating" which adds more than one part of a string 
            // or variable together.

            // You are able to modify and change variables whenever you feel the need to.

            // DATATYPES IN C-SHARP(C#):
        }
    }
}

