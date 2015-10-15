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
            Console.WriteLine("Hello, " + name + " what's your birthday? MM/DD");
            string birthday = Console.ReadLine();
            DateTime convertedBirthday = Convert.ToDateTime(birthday);
            DateTime today = DateTime.Today;

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

            if (convertedBirthday.Equals(today))
                {
                  Console.WriteLine("Today is your birthday!");
                }
                else 
                {
                if (convertedBirthday < today)
                {
                    convertedBirthday = convertedBirthday.AddYears(1);
                }
                 Console.WriteLine("Your Birthday is " + convertedBirthday.Subtract(today).Days + " days away.");
                }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}