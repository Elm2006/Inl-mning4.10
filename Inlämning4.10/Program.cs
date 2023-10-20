using System;
namespace Inlämning_4.__10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv hur långa kateterna ska vara");
            int längd = int.Parse(Console.ReadLine());
            for(int i = 0;i<längd;i++)
            {
                for(int j = 0; j <i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}