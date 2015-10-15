using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            foreach (char letter in name.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    string article = "a";
                    foreach (char nonvoiced in "halfnorsemix")
                    {
                        if (letter == nonvoiced)
                        {
                            article = "an";
                        }
                    }
                    Console.WriteLine("Give me " + article + "... " + letter);
                }
            }
            name = name.ToUpper();
            Console.WriteLine(name + " is just GRAND!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}