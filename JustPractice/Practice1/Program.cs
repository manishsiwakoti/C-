using System;

namespace Practice1
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Hello World!");

            var sum = 1;
            for (var Index = 1; Index <= 10; Index++)
                {
                sum *= Index;
                }

            Console.WriteLine($"Sum is {sum}");

            }
        }
        }
    
