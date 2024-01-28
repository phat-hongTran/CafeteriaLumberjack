using System;
using System.Collections.Generic;
using System.Linq;

namespace CafeteriaLumberjack
{
    class Program
    {
        public static Queue<Lumberjack> queue = new Queue<Lumberjack>();
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("First lumberjack's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Number of flapjacks: ");
            int.TryParse(Console.ReadLine(), out number);            

            Lumberjack first = new Lumberjack(name);
            first.TakeFlapjack(number);
            queue.Enqueue(first);

            while (true)
            {
                Console.WriteLine("Next lumberjack's name (blank to end): ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name)) break;
                Console.WriteLine("Number of flapjacks: ");
                int.TryParse(Console.ReadLine(), out number);

                Lumberjack nextPerson = new Lumberjack(name);
                nextPerson.TakeFlapjack(number);
                queue.Enqueue(nextPerson);
            }

            while (queue.Any())
            {
                Lumberjack person = queue.Dequeue();
                person.EatFlapjacks();
            }
        }
    }
}
