using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada numbrit;
            //programm kuvab korrutustabelit 1 kuni 10 sestatud numbri jaoks
            //1 * 5 = 5
            // 2 * 5 = 10;
            //jne
            Console.WriteLine("Sisesta number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} * {userNumber} = {i*userNumber}");
            }
        }
    }
}
