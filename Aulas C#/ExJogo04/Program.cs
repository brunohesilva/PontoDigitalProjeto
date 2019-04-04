using System;

namespace ExJogo04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                System.Console.WriteLine(((i % 4 != 0)? i.ToString() : "PI"));
            }
        }
    }
}
