using System;
using HouseFuction;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            House Oisin = new House();

            Oisin.MiceName = "Stewart";

            Oisin.Owner = "Oisin";

            Console.WriteLine(Oisin.MiceName);

            Console.WriteLine(Oisin.Owner);

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("You are " + age + " years old.");
        }
    }
}
