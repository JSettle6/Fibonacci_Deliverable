/*
Author: Justin Settle
Date: 2/2/2023
Description: This C# Console application uses arrays after getting input from users
*/

namespace Arrays_Deliverable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 25;
            int[] fibonacci = new int[num];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i =0; i < num; i++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }
        }
    }
}