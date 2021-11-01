using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            var fullName = Console.ReadLine();

            Console.WriteLine($"Hi, {fullName}, what's your favorite color?");
            var faveColor = Console.ReadLine();

            Console.WriteLine("what's your favorite animal");
            var faveAnimal = Console.ReadLine();

            Console.WriteLine("what's your favorite college football team?");
            var faveCfb = Console.ReadLine();

            Console.WriteLine($"One day, {fullName} was walking down the streeat wearing {faveColor} hoodie,");
            Console.WriteLine($"suddenly, a {faveAnimal} appeared with an Ipad.");
            Console.WriteLine($"then, the {faveCfb} football game started playing on the ipad.");
            Console.WriteLine($"now, {fullName} is very confused because a {faveAnimal} just popped up out of nowhere.");
            Console.WriteLine($"{faveAnimal} starts to explain himself.......");
            Console.WriteLine($"oh no! {fullName} fainted and was taken to the hospital.");
            Console.WriteLine($"{fullName} wakes up from his dream.... To be continued.");
            Console.WriteLine($"written by Logan Maloney"); 
        }
    }
}
