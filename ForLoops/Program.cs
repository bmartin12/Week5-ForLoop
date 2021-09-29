using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++) //int i = 0 - start; 1 < 10 - end; i++ - step/iteration
            {
                Console.WriteLine($"{i+i}IM IN YOUR WALLS");
            }
        }
    }
}
