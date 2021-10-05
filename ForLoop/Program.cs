using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will not skateboard ot the halls.

            //string message = "I will not skateboard ot the halls.".ToUpper();

            for(int i = 0; i < 10; i++) //int i = 0; iteratsiooni algus; i < 10; iteratsiooni lõpp; i++ = i = i + 1 - samm
            {
                Console.WriteLine($"{i+1}. I will not skateboard ot the halls.".ToUpper());
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
