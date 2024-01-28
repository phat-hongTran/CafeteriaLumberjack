using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaLumberjack
{
    class Lumberjack
    {
        private Random random = new Random();

        public readonly string Name;
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();
        public void TakeFlapjack(int number)
        {
            for(int i = 0; i < number; i++)
            {
                flapjackStack.Push((Flapjack)random.Next(4));
            }
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            foreach (var item in flapjackStack)
            {
                Console.WriteLine($"{Name} ate a {item.ToString().ToLower()} flapjack");
            }
        }

        public Lumberjack(string name)
        {
            Name = name;
        }
    }

    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana,
    }
}
